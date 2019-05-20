using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAOLIbrary
{
    class MyConnection
    {
        SqlConnection con1;
        public SqlConnection getConnection()
        {
            con1 = new SqlConnection();
            con1.ConnectionString = "Data Source=CGI-JAVA-185\\MSSQLSERVER1;Initial Catalog=Sample08;Integrated Security=true";
            return con1;
        }
    }
}
