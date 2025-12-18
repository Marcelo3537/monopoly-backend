using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class UsuarioPartida
    {
        [Key]
        public int IdUsuarioPartida { get; set; }

        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        [ForeignKey("Partida")]
        public int IdPartida { get; set; }
        public Partida Partida { get; set; }

        public int PosicionFinal { get; set; }
        public bool EsGanador { get; set; }
    }
}
