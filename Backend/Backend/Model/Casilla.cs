using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Casilla
    {
        public int Id { get; set; }

        public List<Posesion> Posesiones { get; set; } = new();
    }

}
