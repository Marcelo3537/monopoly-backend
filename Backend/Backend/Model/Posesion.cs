using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Posesion
    {
        public int Id { get; set; }
        public bool EstaHipotecada { get; set; }

        // Relaciones
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int PartidaId { get; set; }
        public Partida Partida { get; set; }

        public int CasillaId { get; set; }
        public Casilla Casilla { get; set; }
    }

}
