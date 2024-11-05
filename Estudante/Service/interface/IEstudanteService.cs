using Estudantes.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudantes.Service.interfaces
{
    public interface IEstudanteService
    {
        void Adicionar(Estudante a);
        List<Estudante> Listar();
    }
}
