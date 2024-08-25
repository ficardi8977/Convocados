using Convocados.Domain;
using Convocados.UseCases.ListarJugadores;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Convocados.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantelController : ControllerBase
    {
        IListarJugadoresUseCase listarJugadores;
        public PlantelController(IListarJugadoresUseCase listarJugadores) 
        {
            this.listarJugadores = listarJugadores;
        }

        // GET: api/<PlantelController>
        [HttpGet]
        public IEnumerable<Jugador> Get()
        {
            return this.listarJugadores.EjecutarAsync().Result;
        }

        // GET api/<PlantelController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PlantelController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PlantelController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlantelController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }



}
