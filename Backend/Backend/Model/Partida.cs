using System;
using System.Collections.Generic;

namespace Backend.Models
{
    public class Partida
    {
        public int IdPartida { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }

        public int RondaActual { get; set; }
        public int Duracion { get; set; }
        public int NumJugadores { get; set; }

        public int PuntosIniciales { get; set; }
        public int PuntosFinales { get; set; }

        public ICollection<UsuarioPartida> UsuarioPartidas { get; set; }
    }
}