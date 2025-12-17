namespace Backend.Models
{
    public class Tarjeta
    {
        public int IdTarjeta { get; set; }

        public string Tipo { get; set; } // SUERTE / COMUNIDAD
        public string Texto { get; set; }
        public string Efecto { get; set; }
        public int ValorEfecto { get; set; }
    }
}
