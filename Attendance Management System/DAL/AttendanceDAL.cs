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
        
        Connection con = new Connection();
        public DataTable ScanIn(string serial)
        {
            DataTable dt = null;
            SqlConnection con = new SqlConnection(this.con.connection);
            //Join tables
            string sql = "SELECT [dbo].[Student].[STUDENTID]" +
                                                ",[FIRSTNAME]" +
                                                ",[LASTNAME]" +
                                                ",[CLASSNAME]" +
                                                ",[TIMEIN]"+
                                                ",[TIMEOUT]"+
                                                ",[DATEATTENDED]"+
                                                ",DATEDIFF(HOUR,[TIMEIN],[TIMEOUT])) AS[HOURS]"+
                                                "FROM[dbo].[Student]" +
                                                "INNER JOIN[dbo].[TagsSerials]" +
                                                "ON[dbo].[Student].[STUDENTID] = [dbo].[TagsSerials].[STUDENTID]" +
                                                "INNER JOIN[dbo].[Class]" +
                                                "ON[dbo].[Student].[CLASSID] = [dbo].[Class].[CLASSID]" +
                                                "INNER JOIN[dbo].[Attendance]"+
                                                "ON[dbo].[Student].[STUDENTID] = [dbo].[Attendance].[STUDENTID]"+
                                                "WHERE[dbo].[TagsSerials].[TAGSERIAL] = " + serial;


            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
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
