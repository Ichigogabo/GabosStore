using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GaboStore.Modelo
{
    [Table("Compras")]
    public class Compra
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Precio Unitario")]
        public decimal PrecioUnitario { get; set; }

        [DisplayName("Cantidad")]
        public int Cantidad { get; set; }

        [DisplayName("Fecha de Compra")]
        public DateTime FechaDeCompra { get; set; }

        [DisplayName("Producto")]
        public int ProductoId { get; set; }

        public virtual Producto Productos { get; set; }

    }
}
