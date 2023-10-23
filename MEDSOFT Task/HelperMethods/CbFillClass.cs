using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDSOFT_Task.HelperMethods
{
    public class CbFillClass
    {
        public static void InitializeCb(ComboBox comboBox)
        {
            DataTable dataTable = new DataTable();
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter("GetGenders", DatabaseAccess.Connect()))
            {
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.Fill(dataTable);

                comboBox.DataSource = dataTable;
                comboBox.DisplayMember = "GenderName";
                comboBox.ValueMember = "GenderID";
            }
        }
    }
}
