using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Partida
    {
        [Key]
        public int IdPartida { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        [Required]
        public int RondaActual { get; set; }

        [Required]
        public int Duracion { get; set; }

        [Required]
        public int NumJugadores { get; set; }

        [Required]
        public int PuntosIniciales { get; set; }

        [Required]
        public int PuntosFinales { get; set; }

        public ICollection<UsuarioPartida> UsuarioPartidas { get; set; }
    }
}
