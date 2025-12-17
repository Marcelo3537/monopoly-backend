namespace Backend.Models
{
    public class Inventario
    {
        public int IdInventario { get; set; }

        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public int IdProducto { get; set; }
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }
    }
}
