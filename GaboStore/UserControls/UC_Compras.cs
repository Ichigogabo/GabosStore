using GaboStore.Context;
using GaboStore.Modelo;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaboStore.UserControls
{
    public partial class UC_Compras : UserControl
    {
        GaboStoreContext db;
        public UC_Compras()
        {
            db = new GaboStoreContext();
            InitializeComponent();
        }

        private void UC_Compras_Load(object sender, EventArgs e)
        {
            /* Llama al metodo listar*/
            listar(dgvCompras);
            llenarCmbx();

        }

        private void listar(DataGridView dataGridView)
        {
            /* Pasa la lista de productos al dataGridView*/
            dataGridView.DataSource = (from c in db.Compras
                                       join p in db.Productos on c.ProductoId equals p.Id
                                       select new
                                       {
                                           Producto = p.Descripcion,
                                           c.Cantidad,
                                           c.PrecioUnitario,
                                           c.FechaDeCompra
                                       }).ToList();
            /* Se ajusta de manera automatica las columnas al dataGridView*/
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        public void Nuevo(Compra compra)
        {
            try
            {
                /* se asigna el "ValidationContext" a la variable context usando la clase "compra"*/
                var context = new ValidationContext(compra, serviceProvider: null, items: null);
                /* se declara e inicializa la variable "validationResults" la cual contendra la lista de validaciones al validar el objeto "Compra"*/
                var validationResults = new List<ValidationResult>();

                /* se verifica que el objeto "compra" sea valido para poder insertarlo en la BD*/
                if (Validator.TryValidateObject(compra, context, validationResults, true))
                {
                    /* se guarda el nuevo registro de compra en la BD*/
                    db.Compras.Add(compra);
                    db.SaveChanges();
                    /* se muestra un mensaje de exito*/
                    MessageBox.Show("El Registro se Guardo con Exito", "Registro Guardado Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    /* se llama el metodo listar para que actualice la lista de productos*/
                    listar(dgvCompras);
                    
                }
                else
                {
                    /* se muestra un mensaje de error si el objeto "compra" no es valido*/
                    MessageBox.Show("Debe llenar todos los campos", "Error al Guardar el Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                /* se muestra un mensaje de error en caso que ocurra algun error en la BD*/
                MessageBox.Show("A ocurrido un Error al guardar el registro", "Error al Guardar el Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void llenarCmbx()
        {
            /* Se declara una lista de tipo tuple para obtener los productos "Id" , "Codigo + Descripcion"*/
            List<Tuple<int, string>> lp = db.Productos.Select(p => new Tuple<int, string>(p.Id, (p.Codigo + " => " + p.Descripcion))).ToList();

            /* Se asignan los valores de la lista al combobox correspondientes*/
            cmbProductos.DataSource = lp;
            cmbProductos.ValueMember = "item1";
            cmbProductos.DisplayMember = "item2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();

            /* se genera un codigo aleatorio para el producto*/
            compra.ProductoId = Convert.ToInt32(cmbProductos.SelectedValue.ToString());
            compra.FechaDeCompra = dateTimePicker1.Value;
            compra.Cantidad = Convert.ToInt32(numericUpDown1.Value);
            compra.PrecioUnitario = Convert.ToDecimal(numericUpDown2.Value);
            Nuevo(compra);
        }
    }
}
