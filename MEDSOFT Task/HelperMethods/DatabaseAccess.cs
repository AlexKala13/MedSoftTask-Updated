using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDSOFT_Task
{
    class DatabaseAccess
    {
        public static SqlConnection Connect()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString; // connection string-ის მიღება app.config ფაილიდან
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}
