using GaboStore.Context;
using GaboStore.Modelo;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

    public partial class UC_Productos : UserControl
    {
        GaboStoreContext db;
        public UC_Productos()
        {
            db = new GaboStoreContext();
            InitializeComponent();
        }

        private void UC_Productos_Load(object sender, EventArgs e)
        {
            /* Llama al metodo listar*/
            listar(dGVProductos);
            limpiar();
        }

        private void limpiar()
        {
            Descripcion.Text = "";
        }

        private void listar(DataGridView dataGridView)
        {
            /* Pasa la lista de productos al dataGridView*/
            dataGridView.DataSource = db.Productos.Select(x=> new { x.Codigo, x.Descripcion }).ToList();
            /* Se ajusta de manera automatica las columnas al dataGridView*/
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
            
        }

        public void Nuevo(Producto producto)
        {
            try
            {
                /* se asigna el "ValidationContext" a la variable context usando la clase "Producto"*/
                var context = new ValidationContext(producto, serviceProvider: null, items: null);
                /* se declara e inicializa la variable "validationResults" la cual contendra la lista de validaciones al validar el objeto "Producto"*/
                var validationResults = new List<ValidationResult>();

                /* se verifica que el objeto "producto" sea valido para poder insertarlo en la BD*/
                if (Validator.TryValidateObject(producto, context, validationResults, true))
                {
                    /* se guarda el nuevo registro de producto en la BD*/
                    db.Productos.Add(producto);
                    db.SaveChanges();
                    /* se muestra un mensaje de exito*/
                    MessageBox.Show("El Registro se Guardo con Exito", "Registro Guardado Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    /* se llama el metodo listar para que actualice la lista de productos*/
                    listar(dGVProductos);
                    limpiar();
                }
                else
                {
                    /* se muestra un mensaje de error si el objeto "Prodcuto" no es valido*/
                    MessageBox.Show("Debe llenar todos los campos", "Error al Guardar el Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                /* se muestra un mensaje de error en caso que ocurra algun error en la BD*/
                MessageBox.Show("A ocurrido un Error al guardar el registro", "Error al Guardar el Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            /* se genera un codigo aleatorio para el producto*/
            producto.Codigo = Guid.NewGuid().ToString().Substring(0, 10);
            producto.Descripcion = Descripcion.Text;
            Nuevo(producto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
