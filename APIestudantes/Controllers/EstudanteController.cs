using Estudantes.Entidade;
using Estudantes.Service;
using Microsoft.AspNetCore.Mvc;

namespace APIestudantes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudanteController
    {
        

            private readonly EstudanteService _service;
            
            public EstudanteController(IConfiguration config)
            {
                string connect = config.GetConnectionString("DefaultConnection");

               _service = new EstudanteService(connect);      

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
