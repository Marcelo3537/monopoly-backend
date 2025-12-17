namespace Backend.Models
{
    public class Posesion
    {
        public int IdPosesion { get; set; }

        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public int IdCasilla { get; set; }
        public Casilla Casilla { get; set; }

        public bool EstaHipotecada { get; set; }
    }
}
