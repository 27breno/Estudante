using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudantes.Repository.Data
{
    public static class InicializadorBD
    {
        private const string ConnectionString = "Data Source=Estudante.db";


        public static void Inicializar()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string commandoSQL = @"   
                 CREATE TABLE IF NOT EXISTS Estudantes(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Altura REAL NOT NULL,
                 Peso REAL NOT NULL,
                 Idade INT NOT NULL,
                 Nome TEXT NOT NULL
                );";

            

               connection.Execute(commandoSQL);
            }
        }
    }
}
