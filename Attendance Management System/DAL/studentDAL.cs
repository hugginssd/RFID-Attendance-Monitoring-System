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
    class StudentDAL
    {
        public string connection = ConfigurationManager.ConnectionStrings["RFIDConnection"].ConnectionString;

        public Boolean Insert(StudentBLL sbll)
        {
            bool IsSuccess = false;
            SqlConnection con = new SqlConnection(connection);
            string sql = "INSERT INTO [dbo].[Student]"+
                                            "([FIRSTNAME]"+
                                            ",[LASTNAME]"+
                                            ",[EMAIL]"+
                                            ",[CLASSID]"+
                                            ",[DOB]"+
                                            ",[PICTURE]"+
                                            ",[GENDER]"+
                                            ",[ADDRESS]"+
                                            ",[ADDRESS2]"+
                                            ",[PREVIOUS CANDIDATE NO]"+
                                            ",[NO OF SUBJECTS]"+
                                            ",[SCHOOL ADDRESS])"+
                                        "VALUES"+
                                            "(@FIRSTNAME"+
                                            ",@LASTNAME"+
                                            ",@EMAIL"+
                                            ",@CLASSID"+
                                            ",@DOB"+
                                            ",@PICTURE"+
                                            ",@GENDER"+
                                            ",@ADDRESS"+
                                            ",@ADDRESS2"+
                                            ",@PREVIOUS"+
                                            ",@NOOFSUBJECTS"+
                                            ",@SCHOOLADDRESS)";
            try
            {

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@FIRSTNAME", sbll.FirstName);
                cmd.Parameters.AddWithValue("@LASTNAME", sbll.LastName);
                cmd.Parameters.AddWithValue("@EMAIL", sbll.Email);
                cmd.Parameters.AddWithValue("@CLASSID", sbll.ClassID);
                cmd.Parameters.AddWithValue("@DOB", sbll.DOB);
                cmd.Parameters.AddWithValue("@PICTURE", sbll.Picture);
                cmd.Parameters.AddWithValue("@GENDER", sbll.Gender);
                cmd.Parameters.AddWithValue("@ADDRESS", sbll.Address);
                cmd.Parameters.AddWithValue("@ADDRESS2", sbll.Address2);
                cmd.Parameters.AddWithValue("@PREVIOUS", sbll.CandidateNo);
                cmd.Parameters.AddWithValue("@NOOFSUBJECTS", sbll.NoOfSubjects);
                cmd.Parameters.AddWithValue("@SCHOOLADDRESS", sbll.SchoolAddress);
                con.Open();
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
