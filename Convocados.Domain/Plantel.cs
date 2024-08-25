namespace Convocados.Domain
{
    public class Plantel
    {
        public int Temporada { get; set; }

        public string Equipo { get; set; }

        public List<Jugador> JugadorList { get; set; }
    }
}
