using System;

namespace Backend.Models
{
    public class HistorialRecompensa
    {
        public int IdHistorial { get; set; }

        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public int IdRecompensa { get; set; }
        public Recompensa Recompensa { get; set; }

        public DateTime FechaReclamacion { get; set; }
    }
}
