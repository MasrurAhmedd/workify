using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Job_Management_System_Kamao.Model
{
    public class SqlDbDataAccess
    {
        private const string connectionString = @"Data Source=DESKTOP-L8I29OJ\SQLEXPRESS; Initial Catalog=Online_Job_Management_System(Kamao); Trusted_Connection=True";
        public SqlCommand GetQuery(string query)
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = connection;

            return cmd;
        }
    }
}
