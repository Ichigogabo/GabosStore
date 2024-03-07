using GaboStore.Context;
using GaboStore.Modelo;
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
    public partial class UC_Ventas : UserControl
    {
        GaboStoreContext db;
        public UC_Ventas()
        {
            db = new GaboStoreContext();
            InitializeComponent();
        }

        private void UC_Ventas_Load(object sender, EventArgs e)
        {
            /* Llama al metodo listar*/
            listar(dgvVentas);
            llenarCmbx();
        }

        private void listar(DataGridView dataGridView)
        {
            /* Pasa la lista de productos al dataGridView*/
            dataGridView.DataSource = (from c in db.Ventas
                                       join p in db.Productos on c.ProductoId equals p.Id
                                       select new
                                       {
                                           Producto = p.Descripcion,
                                           c.Cantidad,
                                           c.PrecioUnitario,
                                           c.FechaDeVenta
                                       }).ToList();
            /* Se ajusta de manera automatica las columnas al dataGridView*/
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        public void Nuevo(Venta venta)
        {
            try
            {
                /* se asigna el "ValidationContext" a la variable context usando la clase "venta"*/
                var context = new ValidationContext(venta, serviceProvider: null, items: null);
                /* se declara e inicializa la variable "validationResults" la cual contendra la lista de validaciones al validar el objeto "venta"*/
                var validationResults = new List<ValidationResult>();

                /* se verifica que el objeto "venta" sea valido para poder insertarlo en la BD*/
                if (Validator.TryValidateObject(venta, context, validationResults, true))
                {
                    /* se guarda el nuevo registro de compra en la BD*/
                    db.Ventas.Add(venta);
                    db.SaveChanges();
                    /* se muestra un mensaje de exito*/
                    MessageBox.Show("El Registro se Guardo con Exito", "Registro Guardado Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    /* se llama el metodo listar para que actualice la lista de productos*/
                    listar(dgvVentas);

                }
                else
                {
                    /* se muestra un mensaje de error si el objeto "venta" no es valido*/
                    MessageBox.Show("Debe llenar todos los campos", "Error al Guardar el Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                /* se muestra un mensaje de error en caso que ocurra algun error en la BD*/
                MessageBox.Show("A ocurrido un Error al guardar el registro", "Error al Guardar el Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            Venta venta = new Venta();

            /* se genera un codigo aleatorio para el producto*/
            venta.ProductoId = Convert.ToInt32(cmbProductos.SelectedValue.ToString());
            venta.FechaDeVenta = dateTimePicker1.Value;
            venta.Cantidad = Convert.ToInt32(numericUpDown1.Value);
            venta.PrecioUnitario = Convert.ToDecimal(numericUpDown2.Value);
            Nuevo(venta);
        }
    }
}
