namespace Backend.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }

        public int Coste { get; set; }
        public bool EsComprobable { get; set; }

        public string Imagen { get; set; }

        public ICollection<Inventario> Inventarios { get; set; }
    }
}
