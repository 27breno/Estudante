using Estudantes.Entidade;
using Estudantes.Repository;
using Estudantes.Service.interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudantes.Service
{
    public class EstudanteService : IEstudanteService
    {
       EstudanteRepository repositorio { get; set; }

        public EstudanteService( IConfiguration configu)
        {
            repositorio = new EstudanteRepository(configu);
        }
        public void Adicionar(Estudante a)
        {
            repositorio.Adicionar(a);
        }

        public List<Estudante> Listar()
        {
            return repositorio.listar();
        }
        public void Remover(int id)
        {
            repositorio.Remover(id);
        }
        public Estudante BuscarPorId(int id)
        {
            return repositorio.BuscarPorId(id);
        }
        public void Editar(Estudante editPessoa)
        {
            repositorio.Editar(editPessoa);
        }
    }
}
