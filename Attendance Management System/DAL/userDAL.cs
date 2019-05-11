using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Attendance_Management_System.BLL;
using System.Data;
using System.Windows.Forms;

namespace Attendance_Management_System.DAL
{
    class UserDAL
    {
        //public string connection = ConfigurationManager.ConnectionStrings["RFIDConnection"].ConnectionString;
        Connection con = new Connection();
        public bool Insert(UserBLL bll)
        {
            bool IsSuccess = false;
            SqlConnection conn = new SqlConnection(this.con.connection);
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

            try
            {
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
                conn.Close();
            }
            return IsSuccess;
        }
        public DataTable Select(string keywords)
        {
            DataTable dt = null;
            SqlConnection conn = new SqlConnection(this.con.connection);
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
          
            try
            {
                SqlDataAdapter da;
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Data Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }
        public bool Delete(UserBLL bll)
        {
            bool IsSuccess = false;
            SqlConnection conn = new SqlConnection(this.con.connection);
            string sql = "DELETE FROM [dbo].[Users]" +
                                    "WHERE [Id]= @Id ";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", bll.ID);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
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
                conn.Close();
            }

            return IsSuccess;
        }
        public bool Update(UserBLL bll)
        {
            bool IsSuccess = false;
            SqlConnection conn = new SqlConnection(this.con.connection);
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
            
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", bll.UserName);
                cmd.Parameters.AddWithValue("@Id", bll.ID);
                conn.Open();
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
                conn.Close();
            }

            return IsSuccess;
        }
        public bool Search(UserBLL bll)
        {
            bool IsSuccess = false;
            SqlConnection conn = new SqlConnection(this.con.connection);
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
            try
            {
                
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = null;
                cmd.Parameters.AddWithValue("@Username", bll.UserName);
                cmd.Parameters.AddWithValue("@Password", bll.Password);
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IsSuccess = true;
                }
                else
                {
                    IsSuccess = false;
                }

                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Data Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            finally
            {
                conn.Close();
            }
            return IsSuccess;
        }
    }
}
