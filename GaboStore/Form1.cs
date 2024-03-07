using GaboStore.Context;
using GaboStore.Modelo;
using GaboStore.UserControls;

namespace GaboStore
{
    public partial class Form1 : Form
    {
        GaboStoreContext db;
        public Form1()
        {
            InitializeComponent();

            /* Se inicializa la conexion a la BD*/
            db = new GaboStoreContext();

            /* Se asegura que la BD exista de lo contrario se crea*/
            db.Database.EnsureCreated();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void agregarUserControl(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            /* Se limpia el "Contenedor"*/
            Contenedor.Controls.Clear();
            /* Se agrega un nuevo control*/
            Contenedor.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            /* Se Inicializa el el container*/
            UC_Productos up = new UC_Productos();
            
            agregarUserControl(up);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo de la Aplicaciòn", "Adios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /* Cerrando la aplicaciòn"*/
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            /* Se Inicializa el el container*/
            UC_Compras uc = new UC_Compras();
            agregarUserControl(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            /* Se Inicializa el el container*/
            UC_Ventas uv = new UC_Ventas();
            agregarUserControl(uv);
        }
    }
}