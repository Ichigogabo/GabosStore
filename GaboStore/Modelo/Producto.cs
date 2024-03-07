using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaboStore.Modelo
{
    [Table("Productos")]
    public class Producto
    {
        public Producto()
        {
            this.Compras = new HashSet<Compra>();
            this.Ventas = new HashSet<Venta>();
        }


        [Key]
        public int Id { get; set; }
        [DisplayName("Còdigo")]
        public string Codigo { get; set; }
        [DisplayName("Descripciòn")]
        public string Descripcion { get; set; }


        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<Venta> Ventas { get; set; }

    }
}
