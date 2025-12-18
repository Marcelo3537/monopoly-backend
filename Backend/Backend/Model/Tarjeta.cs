using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Tarjeta
    {
        [Key]
        public int IdTarjeta { get; set; }

        [Required]
        public string Tipo { get; set; }

        [Required]
        public string Texto { get; set; }
        public string Efecto { get; set; }
        public int ValorEfecto { get; set; }
    }
}
