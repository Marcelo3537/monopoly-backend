using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    [Table("HistorialRecompensa")]
    public class HistorialRecompensa
    {
        [Key]
        public int IdHistorial { get; set; }

        [Required]
        public int IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario Usuario { get; set; }

        [Required]
        public int IdRecompensa { get; set; }

        [ForeignKey(nameof(IdRecompensa))]
        public Recompensa Recompensa { get; set; }

        [Required]
        public DateTime FechaReclamacion { get; set; }
    }
}
