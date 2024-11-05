using Estudantes.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudantes.Repository.interfaces
{
    public interface IEstudanteRepository
    {
        void Adicionar(Estudante u);

        List<Estudante> listar();
    }
}
