using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }

        [Required]
        public int Coste { get; set; }

        [Required]
        public bool EsComprobable { get; set; }

        [Required]
        public string Imagen { get; set; }

        public ICollection<Inventario> Inventarios { get; set; }
    }
}
