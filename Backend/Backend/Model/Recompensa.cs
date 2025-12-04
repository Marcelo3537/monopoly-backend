using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Recompensa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        // "diaria" o "partida"
        public string Tipo { get; set; }

        public int PuntosOtorgados { get; set; }

        // Muchos a muchos
        public List<HistorialRecompensa> Historiales { get; set; } = new();
    }

}
