using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    [Table("Inventario")]
    public class Inventario
    {
        [Key]
        public int IdInventario { get; set; }

        [Required]
        public int IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario Usuario { get; set; }

        [Required]
        public int IdProducto { get; set; }

        [ForeignKey(nameof(IdProducto))]
        public Producto Producto { get; set; }

        [Required]
        public int Cantidad { get; set; }
    }
}
