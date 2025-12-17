namespace Backend.Models
{
    public class UsuarioPartida
    {
        public int IdUsuarioPartida { get; set; }

        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public int IdPartida { get; set; }
        public Partida Partida { get; set; }

        public int PosicionFinal { get; set; }
        public bool EsGanador { get; set; }
    }
}
