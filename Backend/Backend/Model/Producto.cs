using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public int Coste { get; set; }
        public bool EsComprobable { get; set; }
        public string Imagen { get; set; }

        // Relación muchos a muchos
        public List<Usuario> Usuarios { get; set; } = new();
    }

}
