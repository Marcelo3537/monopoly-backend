using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string UsuarioNombre { get; set; }
        public string Correo { get; set; }
        public string ContrasenyaHash { get; set; }
        public DateTime FechaRegistro { get; set; }

        public int Oro { get; set; }
        public int Pesetas { get; set; }
        public int Gemas { get; set; }

        public int Nivel { get; set; }
        public double ProgresoPorcentaje { get; set; }

        public int TotalPartidas { get; set; }
        public int TotalVictorias { get; set; }
        public double RatioVictoria { get; set; }

        public int EloRating { get; set; }
        public TimeSpan TiempoJugado { get; set; }

        // Relaciones
        public List<Producto> Inventario { get; set; } = new();
        public List<Partida> Partidas { get; set; } = new();
        public List<Logro> Logros { get; set; } = new();
        public List<HistorialRecompensa> HistorialRecompensas { get; set; } = new();
        public List<Posesion> Posesiones { get; set; } = new();
    }

}
