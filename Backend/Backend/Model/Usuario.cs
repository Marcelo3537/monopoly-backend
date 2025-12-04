using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Usuario
    {
        [Key] // Esta es la Clave Primaria
        public int Id { get; set; }

        [Required] // Este campo no puede ser nulo
        public string Username { get; set; }

        // La contraseña la maneja ASP.NET Identity, pero la guardamos hasheada
        public string PasswordHash { get; set; }

        // El dinero del juego
        public int Pesetas { get; set; }
    }
}
