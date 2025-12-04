using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Tarjeta
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Texto { get; set; }
        public string Efecto { get; set; }
        public int ValorEfecto { get; set; }
    }

}
