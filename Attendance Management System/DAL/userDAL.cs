using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Attendance_Management_System.BLL;
using System.Data;

namespace Attendance_Management_System.DAL
{
    class userDAL
    {
        public string connection = ConfigurationManager.ConnectionStrings["RFIDConnection"].ConnectionString;

        public bool Insert(userBLL bll)
        {
            bool success = false;
            string sql = "INSERT INTO [dbo].[Users]" +
                                               "([Id]" +
                                               ",[Name]" +
                                               ",[LastName]" +
                                               ",[Role]" +
                                               ",[CreatedBy]" +
                                               ",[Active]" +
                                               ",[Username]" +
                                               ",[Password])" +
                                               "VALUES" +
                                               "(@Id" +
                                               ",@Name" +
                                               ",@LastName" +
                                               ",@Role" +
                                               ",@CreatedBy" +
                                               ",@Active" +
                                               ",@Username" +
                                               ",@Password)";
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", bll.Name);
            cmd.Parameters.AddWithValue("@LastName", bll.LastName);
            cmd.Parameters.AddWithValue("@Role", bll.Role);
            cmd.Parameters.AddWithValue("@CreatedBy", bll.CreatedBy);
            cmd.Parameters.AddWithValue("@Active", bll.Active);
            cmd.Parameters.AddWithValue("@Username", bll.UserName);
            cmd.Parameters.AddWithValue("@Password", bll.Password);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            if (i > 0)
            {
                success = true;
            }
            else
            {
                success = false;
            }
            return success;
        }
        public DataTable Select(string keywords)
        {
            DataTable dt = null;
            string sql = "SELECT [Id]" +
                            ",[Name]" +
                            ",[LastName]" +
                            ",[Role]" +
                            ",[CreatedBy]" +
                           " ,[Active]" +
                           " ,[Username]" +
                            ",[Password]" +
                            "FROM[dbo].[Users]" +
                            " WHERE [Name] LIKE '%" + keywords + "%' OR [LastName] LIKE '%" + keywords + "%'  OR [Username] LIKE '%" + keywords + "%'";
            SqlConnection conn = new SqlConnection(connection);
            SqlDataAdapter da;
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();

            return dt;

        }
        public bool Delete(userBLL bll)
        {
            bool success = false;
            string sql = "DELETE FROM [dbo].[Users]" +
                                    "WHERE [Id]= @Id ";
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", bll.ID);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i > 0)
            {
                success = true;
            }
            else
            {
                success = false;
            }

            return success;
        }
        public bool Update(userBLL bll)
        {
            bool success = false;
            string sql = "UPDATE [dbo].[Users]" +
                                      "SET[Id] = @Id" +
                                      ",[Name] = @Name" +
                                      ",[LastName] = @LastName" +
                                      ",[Role] = @Role" +
                                      ",[CreatedBy] = @CreatedBy" +
                                      ",[Active] = @Active" +
                                      ",[Username] = @Username" +
                                      ",[Password] = @Password" +
                                      " WHERE [Username] = @Username AND [Id] = @Id";
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Username", bll.UserName);
            cmd.Parameters.AddWithValue("@Id", bll.ID);

            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            if (i > 0)
            {
                success = true;
            }
            else
            {
                success = false;
            }

            return success;
        }
        public bool Search(userBLL bll)
        {
            bool success = false;
            string sql = "SELECT [Id]" +
                              ",[Name]" +
                              ",[LastName]" +
                              ",[Role]" +
                              ",[CreatedBy]" +
                              ",[Active]" +
                              ",[Username]" +
                              ",[Password]" +
                              "FROM[dbo].[Users]" +
                              "WHERE [Username]=@Username AND [Password] =@Password";
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = null;
            cmd.Parameters.AddWithValue("@Username", bll.UserName);
            cmd.Parameters.AddWithValue("@Password", bll.Password);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                success = true;
            }
            else
            {
                success = false;
            }
            conn.Close();
            return success;
        }
    }
}
