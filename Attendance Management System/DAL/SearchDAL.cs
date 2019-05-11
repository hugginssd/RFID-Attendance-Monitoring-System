using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.DAL
{
    class SearchDAL 
    {
        Connection _con = new Connection();
        public DataTable SearchStudentAttendanceAndDetails(string StudentID)
        {
            DataTable dt = null;
            SqlConnection con = new SqlConnection(_con.connection);
            string sql = "SELECT  [dbo].[Student].[STUDENTID]" +
                                  ",[FIRSTNAME]"+
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
                                  ",[SCHOOL ADDRESS]"+
                                  ",[ATTENDANCEID]"+
                                  ",[ATTENDANCE]"+
                                  ",[DATEATTENDED]"+
                                  ",[dbo].[Attendance].[TIMEIN]"+
                                  ",[dbo].[Attendance].[TIMEOUT]"+
                                  ",[dbo].[Class].[CLASSNAME]"+
                              "FROM[dbo].[Student]"+
                              "INNER JOIN[dbo].[Attendance]"+
                              "ON[dbo].[Attendance].[STUDENTID] = [dbo].[Student].[STUDENTID]"+
                              "INNER JOIN[dbo].[Class]"+
                              "ON[dbo].[Class].[CLASSID] = [dbo].[Student].[CLASSID]"+
                              "WHERE[dbo].[Student].[STUDENTID] =" +StudentID;
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
                MessageBox.Show(ex.ToString(),"Data Access Error");
            }
            finally
            {
                con.Close();
            }

            return dt;
        }
        public DataTable SearchStudentHours(string StudentID)
        {

            DataTable dt = null;
            SqlConnection con = new SqlConnection(_con.connection);
            string sql = "SELECT [ATTENDANCEID]"+
                                ",[STUDENTID]"+
                                ",[ATTENDANCE]"+
                                ",[DATEATTENDED]"+
                                ",COUNT(DATEDIFF(HOUR,[TIMEIN],[TIMEOUT])) AS [HOURS]"+
                            "FROM [dbo].[Attendance] "+
                            "WHERE [dbo].[Attendance].[STUDENTID] = "+ StudentID;
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
                MessageBox.Show(ex.ToString(),"Data Access Error");
            }finally
            {
                con.Close();
            }
            return dt;
        }
        public DataTable SearchStudentAttendance(string StudentID)
        {
            DataTable dt = null;
            SqlConnection con = new SqlConnection(_con.connection);
            string sql = "SELECT [ATTENDANCEID]"+
                                      ",[STUDENTID]"+
                                      ",[ATTENDANCE]"+
                                      ",[DATEATTENDED]"+
                                      ",[TIMEIN]" +
                                      ",[TIMEOUT]" +
                                      ", COUNT(DATEDIFF(HOUR,[TIMEIN],[TIMEOUT])) AS[HOURS]"+
                                  "FROM[dbo].[Attendance]" +
                                  "WHERE[dbo].[Student].[STUDENTID] =" + StudentID;
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                dt = new DataTable();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }       
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Data Acces Error");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}
