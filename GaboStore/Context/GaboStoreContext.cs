using GaboStore.Modelo;
using Microsoft.EntityFrameworkCore;

namespace GaboStore.Context;

    public class GaboStoreContext:DbContext
    {
        /*Se referencian las clases a utilizar*/
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Venta> Ventas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        /*Se declara la cadena de conexion al BD*/
        string conexion = @"Server=.;Database=GaboStore;Integrated Security=True";
        optionsBuilder.UseSqlServer(conexion);
    }

}

