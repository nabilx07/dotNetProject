using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Penerangan.Emedia2u.Web.Helper;
using System.Data.SqlClient;
using System.Data;
using Penerangan.Emedia2u.Web.DTO;

namespace Penerangan.Emedia2u.Web.Provider
{
    public class RunNoProvider
    {
        static string connStr = null;

        static RunNoProvider()
        {
            connStr = ConnectionString.GetConnectionString();
        }

        internal static RunNoDTO GetRunNo(string runNoType)
        {

            RunNoDTO dto = new RunNoDTO();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("p_MSSYS_RunNo_sel", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@RunNoType", SqlDbType.VarChar).Value = runNoType;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dto.RunNoType = reader["RunNoType"].ToString();
                    dto.RunNoLength = (int)reader["RunNoLength"];
                    dto.PaddingChr = reader["PaddingChr"].ToString();
                    dto.RunNoValue = reader["RunNoValue"].ToString();

                }

            }

            return dto;
        }

        internal static void UpdateRunNo(string runNoType)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("p_MSSYS_RunNo_upd_RunNoValue", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@RunNoType", SqlDbType.VarChar).Value = runNoType;
                cmd.ExecuteNonQuery();

            }
        }
    }
}