using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projects._Repositories
{
    public class DasRepository
    {
        protected readonly string ConnectingString;
        public DasRepository()
        {
            ConnectingString = "Data Source=\"localhost, 1433\";Initial Catalog=Transporting;User ID=sa;Password=Monster1@3";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectingString);
        }

    }
}
