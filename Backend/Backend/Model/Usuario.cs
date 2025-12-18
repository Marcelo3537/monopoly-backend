using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [MaxLength(50)]
        public string UsuarioNombre { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Correo { get; set; }
        public string ContrasenyaHash { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int Oro { get; set; }
        public int Pesetas { get; set; }
        public int Gemas { get; set; }

        public int Nivel { get; set; }

        [Range(0, 100)]
        public decimal ProgresoPorcentaje { get; set; }

        public int TotalPartidas { get; set; }
        public int TotalVictorias { get; set; }

        [Range(0, 1)]
        public decimal RatioVictoria { get; set; }

        public int EloRating { get; set; }
        public int TiempoJugado { get; set; }

        // Relaciones
        public ICollection<UsuarioPartida> UsuarioPartidas { get; set; }
        public ICollection<Inventario> Inventario { get; set; }
        public ICollection<UsuarioLogro> UsuarioLogros { get; set; }
        public ICollection<HistorialRecompensa> HistorialRecompensas { get; set; }
        public ICollection<Posesion> Posesiones { get; set; }
    }

}
