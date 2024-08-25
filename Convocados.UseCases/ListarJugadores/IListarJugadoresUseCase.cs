using Convocados.Domain;

namespace Convocados.UseCases.ListarJugadores
{
    public interface IListarJugadoresUseCase
    {
        Task<List<Jugador>> EjecutarAsync();
    }
}
