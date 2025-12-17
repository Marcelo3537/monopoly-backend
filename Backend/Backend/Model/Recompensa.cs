using System.Collections.Generic;

namespace Backend.Models
{
    public class Recompensa
    {
        public int IdRecompensa { get; set; }

        public string Nombre { get; set; }
        public string Tipo { get; set; } // DIARIA / PARTIDA
        public int PuntosOtorgados { get; set; }

        public ICollection<HistorialRecompensa> Historiales { get; set; }
    }
}
