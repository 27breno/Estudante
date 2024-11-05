using Dapper.Contrib.Extensions;
using Estudantes.Entidade;
using Estudantes.Repository.interfaces;
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;

namespace Estudantes.Repository
{
    public class EstudanteRepository : IEstudanteRepository
    {
        private readonly string ConnectionString;
        public EstudanteRepository( IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }
        public void Adicionar(Estudante u)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Estudante>(u);

        }
        public List<Estudante> listar()
        {
            {
                using var connection = new SQLiteConnection(ConnectionString);
                {
                    List<Estudante> u = connection.GetAll<Estudante>().ToList();
                    return u;
                }
            }
        }

    }
}
