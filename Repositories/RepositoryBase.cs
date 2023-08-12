using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseno_Moderno_WPF.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;

        public RepositoryBase()
        {
            _connectionString = "Server=DESKTOP-JDKVK24\\SQLEXPRESS; DataBase=MVVMLoginDb;Integrated Security=true";
        }

        protected SqlConnection GetConnection() 
        {
            return new SqlConnection( _connectionString );
        }
    }
}
