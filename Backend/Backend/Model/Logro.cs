using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    [Table("Logro")]
    public class Logro
    {
        [Key]
        public int IdLogro { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        public ICollection<UsuarioLogro> UsuarioLogros { get; set; }
    }
}
