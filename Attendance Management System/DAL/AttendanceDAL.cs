using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.DAL
{
    class AttendanceDAL
    {
        public string connection = ConfigurationManager.ConnectionStrings["RFIDConnection"].ConnectionString;

        public DataTable ScanIn()
        {
            DataTable dt = null;
            SqlConnection con = new SqlConnection(connection);
            //Join tables
            string sql = "";


            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Data Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            finally
            {
                con.Close();
            }

            return dt;
        }
    }
}
