using System;

namespace Backend.Models
{
    public class UsuarioLogro
    {
        public int IdUsuarioLogro { get; set; }

        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public int IdLogro { get; set; }
        public Logro Logro { get; set; }

        public DateTime FechaObtenido { get; set; }
    }
}
