using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Recompensa
    {
        [Key]
        public int IdRecompensa { get; set; }

        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Tipo { get; set; } 
        public int PuntosOtorgados { get; set; }

        public ICollection<HistorialRecompensa> Historiales { get; set; }
    }
}
