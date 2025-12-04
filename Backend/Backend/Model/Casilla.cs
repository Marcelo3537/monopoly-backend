using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Casilla
    {
        [Key] // Esta es la Clave Primaria
        public int Id { get; set; }
    }
}
