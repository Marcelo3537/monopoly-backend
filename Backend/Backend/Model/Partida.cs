using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Partida
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }

        public int RondaActual { get; set; }
        public TimeSpan Duracion { get; set; }

        public int NumJugadores { get; set; }
        public int PosicionFinal { get; set; }
        public bool EsGanador { get; set; }

        public int PuntosIniciales { get; set; }
        public int PuntosFinales { get; set; }

        // Relaciones
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }

        public List<Posesion> Posesiones { get; set; } = new();
    }

}
