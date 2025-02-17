using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUD
{
    internal class ConexaoBanco
    {
        private const string server = "localhost";
        private const string user = "root";
        private const string password = "123456";
        private const string database = "dbAlunos";
        public static string conexaoBanco = $"server={server};user={user};password={password};database={database};";
    }
}
