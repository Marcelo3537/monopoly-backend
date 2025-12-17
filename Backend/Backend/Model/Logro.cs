using System.Collections.Generic;

namespace Backend.Models
{
    public class Logro
    {
        public int IdLogro { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public ICollection<UsuarioLogro> UsuarioLogros { get; set; }
    }
}
