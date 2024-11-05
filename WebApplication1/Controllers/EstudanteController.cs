using Estudantes.Entidade;
using Estudantes.Service;
using Estudantes.Service.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudanteController : ControllerBase
    {
        private readonly IEstudanteService _service;

        public EstudanteController(IConfiguration config, IEstudanteService service)
        {
            string connect = config.GetConnectionString("DefaultConnection");

            _service = service;

        }

        [HttpPost("adicionar-Avaliação")]
        public void adicionar(Estudante u)
        {

            _service.Adicionar(u);
        }

        [HttpGet("Listar-Avaliações")]
        public List<Estudante> Listar()
        {
            return _service.Listar();
        }
    }
}
