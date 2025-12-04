using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class HistorialRecompensa
    {
        public int Id { get; set; }
        public DateTime FechaReclamacion { get; set; }

        // Muchos a muchos
        public List<Usuario> Usuarios { get; set; } = new();
        public List<Recompensa> Recompensas { get; set; } = new();
    }

}
