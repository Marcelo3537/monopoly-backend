using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class UsuarioLogro
    {
        [Key]
        public int IdUsuarioLogro { get; set; }

        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        [ForeignKey("Logro")]
        public int IdLogro { get; set; }
        public Logro Logro { get; set; }

        public DateTime FechaObtenido { get; set; }
    }
}
