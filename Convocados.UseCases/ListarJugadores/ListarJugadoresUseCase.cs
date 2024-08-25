using Convocados.Domain;
using Convocados.UseCases.ListarJugadores;

public class ListarJugadoresUseCase : IListarJugadoresUseCase
{
    public ListarJugadoresUseCase()
    {
    }

    public async Task<List<Jugador>> EjecutarAsync()
    {
        return new List<Jugador>
{
    new Jugador
    {
        Numero = 1,
        Nombre = "Lionel",
        Apellido = "Messi",
        Posicion = "Delantero",
        Nacionalidad = "Argentina"
    },
    new Jugador
    {
        Numero = 2,
        Nombre = "Cristiano",
        Apellido = "Ronaldo",
        Posicion = "Delantero",
        Nacionalidad = "Portugal"
    },
    new Jugador
    {
        Numero = 3,
        Nombre = "Neymar",
        Apellido = "Junior",
        Posicion = "Delantero",
        Nacionalidad = "Brasil"
    },
    new Jugador
    {
        Numero = 4,
        Nombre = "Sergio",
        Apellido = "Ramos",
        Posicion = "Defensor",
        Nacionalidad = "España"
    },
    new Jugador
    {
        Numero = 5,
        Nombre = "Manuel",
        Apellido = "Neuer",
        Posicion = "Portero",
        Nacionalidad = "Alemania"
    }
};
    }
}