using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Management_System.BLL;

namespace Attendance_Management_System.DAL
{
    class ParentsDAL
    {
        public string connection = ConfigurationManager.ConnectionStrings["RFIDConnection"].ConnectionString;

        public bool Insert(ParentsBLL pbll)
        {
            bool IsSuccess = false;
            SqlConnection con = new SqlConnection(connection);
            string sql = "INSERT INTO[dbo].[Parents]"+
                                        "([FIRSTNAME]"+
                                        ",[LASTNAME]"+
                                        ",[PHONE]"+
                                        ",[EMAIL]"+
                                        ",[ADDRESS]"+
                                        ",[STUDENTID]"+
                                        ",[USERNAME]"+
                                        ",[PASSWORD])"+
                                    "VALUES"+
                                        "(@FIRSTNAME"+
                                        ",@LASTNAME"+
                                        ",@PHONE"+
                                        ",@EMAIL"+
                                        ",@ADDRESS"+
                                        ",@STUDENTID"+
                                        ",@USERNAME"+
                                        ",@PASSWORD)";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@FIRSTNAME", pbll.FirstName);
                cmd.Parameters.AddWithValue("@LASTNAME", pbll.LastName);
                cmd.Parameters.AddWithValue("@PHONE", pbll.Phone);
                cmd.Parameters.AddWithValue("@EMAIL", pbll.Email);
                cmd.Parameters.AddWithValue("@ADDRESS", pbll.Address);
                cmd.Parameters.AddWithValue("@STUDENTID", pbll.StudentID);
                cmd.Parameters.AddWithValue("@USERNAME", pbll.UserName);
                cmd.Parameters.AddWithValue("@PASSWORD", pbll.Password);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    IsSuccess = true;
                }
                else
                {
                    IsSuccess = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Data Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            finally
            {
                con.Close();
            }
            return IsSuccess;
        }

    }
}
