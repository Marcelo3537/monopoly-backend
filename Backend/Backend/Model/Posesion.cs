using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Posesion
    {
        [Key]
        public int IdPosesion { get; set; }

        [Required]
        public int IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario Usuario { get; set; }

        [Required]
        public int IdCasilla { get; set; }

        [ForeignKey(nameof(IdCasilla))]
        public Casilla Casilla { get; set; }

        [Required]
        public bool EstaHipotecada { get; set; }
    }
}
