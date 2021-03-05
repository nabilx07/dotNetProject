using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Penerangan.Emedia2u.Web.DTO;
using Penerangan.Emedia2u.Web.Provider;

namespace Penerangan.Emedia2u.Web.Managers
{
    public class Emedia2uManager
    {
        public static List<LookupDTO> Load(string codeType)
        {
            List<LookupDTO> lookUp;
            if (!CacheManager.ManageCache(codeType, out lookUp))
            {
            lookUp = EmediaProvider.Load(codeType);
                CacheManager.InsertCache(codeType, lookUp);
            }
            return lookUp;
        }

        public static List<MediaDTO> Load()
        {
            return EmediaProvider.LoadMedia();
        }

        public static ApplicantDTO LoadViaNoBorang(string borangNo)
        {
            ApplicantDTO  Applicant;
            Applicant = EmediaProvider.LoadViaCardNo(borangNo);
            return Applicant;
        }

        public static ApplicantDTO LoadViaCardNo(string icNo)
        {
            ApplicantDTO Applicant;
            Applicant = EmediaProvider.LoadViaIcNo(icNo);
            return Applicant;
        }


        #region insert
        public static int MasukkanPermohonanBaru(string applicant_form,
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
                                                bool IsAktif)
        {
            int status = EmediaProvider.InsertNewApplicant(applicant_form,
                                                         applicant_name,
                                                         nationality_code,
                                                         applicant_icno,
                                                         applicant_malaysian,
                                                         applicant_visit,
                                                         applicant_arrival,
                                                         applicant_pass_placeissue,
                                                         applicant_pass_expiry,
                                                         cardstatus_code,
                                                         applicant_dob,
                                                         gender_code,
                                                         applicant_cardno,
                                                         applicant_photo,
                                                         applicant_photo_type,
                                                         applicant_oldcardno,
                                                         cardcolor_code,
                                                         applicant_address,
                                                         applicant_postcode,
                                                         state_code,
                                                         country_code,
                                                         applicant_telono,
                                                         applicant_telhno,
                                                         applicant_hpno,
                                                         applicant_email,
                                                         media_id,
                                                         applicant_designation,
                                                         applicant_ense_name,
                                                         applicant_ense_des,
                                                         applicant_ense_org,
                                                         officer_id,
                                                         applicant_dateissue,
                                                         applicant_dateexpiry,
                                                         validfor_code,
                                                         enterby_id,
                                                         enter_date,
                                                         editby_id,
                                                         edit_date,
                                                         printby_id,
                                                         print_date,
                                                         applicant_comment,
                                                         Application_date,
                                                         Record_Type,
                                                         OldCard,
                                                         PoliceReport,
                                                         Application_Approval,
                                                         StatusKad,
                                                         NoBorang,
                                                         Catatan,
                                                         NamaPegawaiPengesahan ,
                                                         JawatanPegawaiPengesahan ,
                                                         TarikhPengesahan ,
                                                         IsAktif);
            return status;

        }
        #endregion

        public static bool ValidateUser(string username, string password)
        {
            return EmediaProvider.Authenticate(username, password);
        }

        public static string GetPassword(string username)
        {
            return EmediaProvider.GetPassword(username);
        }

    }
}