using Estudantes.Entidade;
using Estudantes.Service;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudanteController : ControllerBase
    {
        private readonly EstudanteService _service;

        public EstudanteController(IConfiguration config)
        {
            string connect = config.GetConnectionString("DefaultConnection");

            _service = new EstudanteService(config);

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
