using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaboStore.Modelo
{

    [Table("Ventas")]
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Precio Unitario")]
        public decimal PrecioUnitario { get; set; }

        [DisplayName("Cantidad")]
        public int Cantidad { get; set; }

        [DisplayName("Fecha de Venta")]
        public DateTime FechaDeVenta { get; set; }

        [DisplayName("Producto")]
        public int ProductoId { get; set; }

        public virtual Producto Productos { get; set; }

    }
}
