using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Penerangan.Emedia2u.Web.Helper;
/*
     create procedure sp_Test
     (
          @Id int, @Name varchar(50)
     )
          Insert into table1(Id, FullName) values(@Id,@Name)
      
      try
      {
         sqlConnection = new SqlConnection(dbConnectionString);
         SqlCommand command = new SqlCommand("sp_Test", sqlConnection);
         command.CommandType = CommandType.StoredProcedure;
         command.Parameters.Add("@Id", SqlDbType.VarChar).Value = txtId.Text;
         command.Parameters.Add("@Name", SqlDbType.DateTime).Value = txtName.Text;
         sqlConnection.Open();
         return command.ExecuteNonQuery();
         sqlConnection.Close();
    }
    catch (SqlException ex)
    {
     Console.WriteLine("SQL Error" + ex.Message.ToString());
     return 0;
    }*/

namespace Penerangan.Emedia2u.Web.Provider
{
    internal static class LoginProvider
    {
        static string connStr ;

        static LoginProvider()
        {
            connStr = ConnectionString.GetConnectionString();
        }

        internal static Boolean Authenticate(string username,string pwd)
        {
            string hashPwd = Encoding.ASCII.GetString(Utility.HashPassword(pwd));

            using(SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("p_MS_UserProfile_Authenticate", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar)).Value = username;
                                
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["LoginPwd"].ToString().Equals(hashPwd))
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        internal static string GetPassword(string username)
        {
            string pwd = string.Empty;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("p_MS_UserProfile_sel_by_UserName", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar)).Value = username;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pwd = reader["LoginPwd"].ToString();
                    
                }

            }

            return pwd;

        }

        internal static MembershipUser CreateUser(string username, string pwd, out MembershipCreateStatus status)
        {
            MembershipUser newUser = null;

            pwd = Encoding.UTF8.GetString(Utility.HashPassword(pwd));

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "insert into user(email,password) values(@username,@password)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar)).Value = username;
                cmd.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar)).Value = pwd;

               int i = cmd.ExecuteNonQuery();
               status = MembershipCreateStatus.Success;
               

            }

            return newUser;
        }
    }
}
