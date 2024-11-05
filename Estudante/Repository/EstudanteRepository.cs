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
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Estudante estudante = BuscarPorId(id);
            connection.Delete<Estudante>(estudante);
        }
        public void Editar(Estudante endereco)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Estudante>(endereco);
        }
        public Estudante BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Estudante>(id);
        }

    }
}
