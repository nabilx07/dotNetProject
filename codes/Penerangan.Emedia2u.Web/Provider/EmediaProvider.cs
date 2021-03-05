using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Penerangan.Emedia2u.Web.Helper;
using System.Data.SqlClient;
using System.Data;
using Penerangan.Emedia2u.Web.DTO;
using System.Text;

namespace Penerangan.Emedia2u.Web.Provider
{
    internal static class EmediaProvider
    {
        static string connString = null;

        static EmediaProvider()
        {
            connString = ConnectionString.GetConnectionString();
        }

        internal static List<LookupDTO> Load(string codeType) 
        {
            List<LookupDTO> dTO = new List<LookupDTO>();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("p_MS_Code_sel_by_CodeType", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CodeType", SqlDbType.VarChar).Value = codeType;

                SqlDataReader reader = cmd.ExecuteReader();

                dTO.Add(new LookupDTO { CodeID = "", CodeValue1 = "", IsActive = "Y" });

                while (reader.Read())
                {
                    dTO.Add(new LookupDTO
                    {
                        CodeID = reader["CodeID"].ToString(),
                        CodeValue1 = reader["CodeValue1"].ToString(),
                        IsActive = reader["IsActive"].ToString()
                    });

                }
            }

            return dTO;

        }

        internal static List<MediaDTO> LoadMedia()
        {
            List<MediaDTO> dTO = new List<MediaDTO>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("p_Media_Lookup", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dTO.Add(new MediaDTO
                    {
                        ID = (int)reader["media_id"],
                        Name = reader["media_name"].ToString()
                    });
                }
            }

            return dTO;

        }

        #region insert
        internal static int InsertNewApplicant(string applicant_form,
                string applicant_name,
                string nationality_code,
                string applicant_icno,
                string applicant_malaysian,
                int applicant_visit,
                DateTime applicant_arrival,
                string applicant_pass_placeissue,
                DateTime applicant_pass_expiry,
                string cardstatus_code,
                DateTime applicant_dob,
                string gender_code,
                string applicant_cardno,
                Byte[] applicant_photo,
                string applicant_photo_type,
                string applicant_oldcardno,
                string cardcolor_code,
                string applicant_address,
                string applicant_postcode,
                string state_code,
                string country_code,
                string applicant_telono,
                string applicant_telhno,
                string applicant_hpno,
                string applicant_email,
                int media_id,
                string applicant_designation,
                string applicant_ense_name,
                string applicant_ense_des,
                string applicant_ense_org,
                int officer_id,
                DateTime applicant_dateissue,
                DateTime applicant_dateexpiry,
                string validfor_code,
                int enterby_id,
                DateTime enter_date,
                int editby_id,
                DateTime edit_date,
                int printby_id,
                DateTime print_date,
                string applicant_comment,
                DateTime Application_date,
                int Record_Type,
                string OldCard,
                string PoliceReport,
                string Application_Approval,
                string StatusKad,
                string NoBorang,
                string Catatan,
                string NamaPegawaiPengesahan,
                string JawatanPegawaiPengesahan,
                DateTime TarikhPengesahan,
                bool IsAktif
            )
        {
            int status = -1;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("p_MediaApplicant_ins", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@applicant_form", SqlDbType.NVarChar).Value = applicant_form;
                cmd.Parameters.Add("@applicant_name", SqlDbType.NVarChar).Value = applicant_name;
                cmd.Parameters.Add("@nationality_code", SqlDbType.NVarChar).Value = nationality_code;
                cmd.Parameters.Add("@applicant_icno", SqlDbType.NVarChar).Value = applicant_icno;
                cmd.Parameters.Add("@applicant_malaysian", SqlDbType.NVarChar).Value = applicant_malaysian;
                cmd.Parameters.Add("@applicant_visit", SqlDbType.SmallInt).Value = applicant_visit;
                cmd.Parameters.Add("@applicant_arrival", SqlDbType.DateTime2).Value = applicant_arrival;
                cmd.Parameters.Add("@applicant_pass_placeissue", SqlDbType.NVarChar).Value = applicant_pass_placeissue;
                cmd.Parameters.Add("@applicant_pass_expiry", SqlDbType.DateTime2).Value = applicant_pass_expiry;
                cmd.Parameters.Add("@cardstatus_code", SqlDbType.NVarChar).Value = cardstatus_code;
                cmd.Parameters.Add("@applicant_dob", SqlDbType.DateTime2).Value = applicant_dob;
                cmd.Parameters.Add("@gender_code", SqlDbType.NVarChar).Value = gender_code;
                cmd.Parameters.Add("@applicant_cardno", SqlDbType.NVarChar).Value = applicant_cardno;
                cmd.Parameters.Add("@applicant_photo", SqlDbType.VarBinary).Value = applicant_photo;
                cmd.Parameters.Add("@applicant_photo_type", SqlDbType.NVarChar).Value = applicant_photo_type;
                cmd.Parameters.Add("@applicant_oldcardno", SqlDbType.NVarChar).Value = applicant_oldcardno;
                cmd.Parameters.Add("@cardcolor_code", SqlDbType.NVarChar).Value = cardcolor_code;
                cmd.Parameters.Add("@applicant_address", SqlDbType.NVarChar).Value = applicant_address;
                cmd.Parameters.Add("@applicant_postcode", SqlDbType.NVarChar).Value = applicant_postcode;
                cmd.Parameters.Add("@state_code", SqlDbType.NChar).Value = state_code;
                cmd.Parameters.Add("@country_code", SqlDbType.NVarChar).Value = country_code;
                cmd.Parameters.Add("@applicant_telono", SqlDbType.NVarChar).Value = applicant_telono;
                cmd.Parameters.Add("@applicant_telhno", SqlDbType.NVarChar).Value = applicant_telhno;
                cmd.Parameters.Add("@applicant_hpno", SqlDbType.NVarChar).Value = applicant_hpno;
                cmd.Parameters.Add("@applicant_email", SqlDbType.NVarChar).Value = applicant_email;
                cmd.Parameters.Add("@media_id", SqlDbType.Int).Value = media_id;
                cmd.Parameters.Add("@applicant_designation", SqlDbType.NVarChar).Value = applicant_designation;
                cmd.Parameters.Add("@applicant_ense_name", SqlDbType.NVarChar).Value = applicant_ense_name;
                cmd.Parameters.Add("@applicant_ense_des", SqlDbType.NVarChar).Value = applicant_ense_des;
                cmd.Parameters.Add("@applicant_ense_org", SqlDbType.NVarChar).Value = applicant_ense_org;
                cmd.Parameters.Add("@officer_id", SqlDbType.Int).Value = officer_id;
                cmd.Parameters.Add("@applicant_dateissue", SqlDbType.DateTime2).Value = applicant_dateissue;
                cmd.Parameters.Add("@applicant_dateexpiry", SqlDbType.DateTime2).Value = applicant_dateexpiry;
                cmd.Parameters.Add("@validfor_code", SqlDbType.NVarChar).Value = validfor_code;
                cmd.Parameters.Add("@enterby_id", SqlDbType.Int).Value = enterby_id;
                cmd.Parameters.Add("@enter_date", SqlDbType.DateTime2).Value = enter_date;
                cmd.Parameters.Add("@editby_id", SqlDbType.Int).Value = editby_id;
                cmd.Parameters.Add("@edit_date", SqlDbType.DateTime2).Value = edit_date;
                cmd.Parameters.Add("@printby_id", SqlDbType.Int).Value = printby_id;
                cmd.Parameters.Add("@print_date", SqlDbType.DateTime2).Value = print_date;
                cmd.Parameters.Add("@applicant_comment", SqlDbType.NVarChar).Value = applicant_comment;
                cmd.Parameters.Add("@Application_date", SqlDbType.DateTime2).Value = Application_date;
                cmd.Parameters.Add("@Record_Type", SqlDbType.SmallInt).Value = Record_Type;
                cmd.Parameters.Add("@OldCard", SqlDbType.NVarChar).Value = OldCard;
                cmd.Parameters.Add("@PoliceReport", SqlDbType.NVarChar).Value = PoliceReport;
                cmd.Parameters.Add("@Application_Approval", SqlDbType.NVarChar).Value = Application_Approval;
                cmd.Parameters.Add("@StatusKad", SqlDbType.NVarChar).Value = StatusKad;
                cmd.Parameters.Add("@NoBorang", SqlDbType.NVarChar).Value = NoBorang;
                cmd.Parameters.Add("@Catatan", SqlDbType.NVarChar).Value = Catatan;
                cmd.Parameters.Add("@NamaPegawaiPengesahan", SqlDbType.NVarChar).Value = NamaPegawaiPengesahan;
                cmd.Parameters.Add("@JawatanPegawaiPengesahan", SqlDbType.NVarChar).Value = JawatanPegawaiPengesahan;
                cmd.Parameters.Add("@TarikhPengesahan", SqlDbType.DateTime).Value = TarikhPengesahan;
                cmd.Parameters.Add("@IsAktif", SqlDbType.Bit).Value = IsAktif;

                status = cmd.ExecuteNonQuery();

            }

            return status;
        }

        #endregion

        internal static ApplicantDTO LoadViaCardNo(string cardNo)
        {
            ApplicantDTO dTO = new ApplicantDTO();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("p_Applicant_sel_by_NoBorang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NoBorang", SqlDbType.NVarChar).Value = cardNo;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dTO.CardNo = reader["NoBorang"].ToString();
                    dTO.Name = reader["applicant_name"].ToString();
                    dTO.Address = reader["applicant_address"].ToString();
                    dTO.OldCardNo = reader["applicant_oldcardno"].ToString();
                    dTO.IcNo = reader["applicant_icno"].ToString();
                    dTO.Designation = reader["applicant_designation"].ToString();
                }
            }

            return dTO;
        }

        internal static ApplicantDTO LoadViaIcNo(string icNo)
        {
            ApplicantDTO dTO = new ApplicantDTO();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("p_Applicant_sel_by_Applicant_KadPengenalan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Applicant_Icno", SqlDbType.NVarChar).Value = icNo;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dTO.CardNo = reader["NoBorang"].ToString();
                    dTO.Name = reader["applicant_name"].ToString();
                    dTO.Address = reader["applicant_address"].ToString();
                    dTO.OldCardNo = reader["applicant_oldcardno"].ToString();
                    dTO.IcNo = reader["applicant_icno"].ToString();
                    dTO.Designation = reader["applicant_designation"].ToString();
                }
            }

            return dTO;
        }

        internal static Boolean Authenticate(string username, string pwd)
        {
            string hashPwd = Encoding.ASCII.GetString(Utility.HashPassword(pwd));

            using (SqlConnection conn = new SqlConnection(connString))
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

            using (SqlConnection conn = new SqlConnection(connString))
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
    }

}