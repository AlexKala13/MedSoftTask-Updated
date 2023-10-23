using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDSOFT_Task
{
    public class MainHandler
    {
        public static DataTable GetPatients()
        {
            DataTable dataTable = new DataTable();

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter("GetPatientsData", DatabaseAccess.Connect()))
            {
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                
                dataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

        public static void DeletePatients(List<int> patientIDs)
        {
            DataTable table = new DataTable();
            table.Columns.Add("PatientID", typeof(int));

            foreach (int patientID in patientIDs)
            {
                table.Rows.Add(patientID);
            }

            using (SqlConnection connection = DatabaseAccess.Connect())
            {
                connection.Open(); 

                using (SqlCommand command = new SqlCommand("DeletePatients", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PatientIDs", table);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

    }
}
