using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Penerangan.Emedia2u.Web.Managers;
using Penerangan.Emedia2u.Web.DTO;
using System.IO;
using System.Globalization;
using Penerangan.Emedia2u.Web.Helper;


namespace Penerangan.Emedia2u.Web.Borang
{
    public partial class KKMMJaPen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                recaptcha.PublicKey = System.Configuration.ConfigurationManager.AppSettings["reCAPTCHAPublicKey"].ToString();
                recaptcha.PrivateKey = System.Configuration.ConfigurationManager.AppSettings["reCAPTCHAPrivateKey"].ToString();
            }
                        
            List<LookupDTO> LookupNegara = Emedia2uManager.Load("Negara");
            foreach (var negaraName in LookupNegara) {
                ddlNegara.Items.Add(negaraName.CodeValue1);
            }

            List<LookupDTO> LookupNegeri = Emedia2uManager.Load("Negeri");
            foreach (var negeriName in LookupNegeri)
            {
                ddlNegeri.Items.Add(negeriName.CodeValue1);
            }

            List<LookupDTO> LookupCardColor = Emedia2uManager.Load("CardColor");
            foreach (var warnaKad in LookupCardColor)
            {
                ddlWarnaKad.Items.Add(warnaKad.CodeValue1);
            }

            List<LookupDTO> LookupJantina = Emedia2uManager.Load("Jantina");
            foreach (var jantina in LookupJantina)
            {
                ddlJantina.Items.Add(jantina.CodeValue1);
            }

            List<LookupDTO> LookupWarganegara = Emedia2uManager.Load("WargaNegara");
            foreach (var wargaNegara in LookupWarganegara)
            {
                ddlWargaNegara.Items.Add(wargaNegara.CodeValue1);
            }

            List<MediaDTO> LookupMedia = Emedia2uManager.Load();
            foreach (var mediaList in LookupMedia)
            {
                string mediaId = mediaList.ID + " | "+  mediaList.Name;
                ddlMediaId.Items.Add(mediaId);
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (recaptcha.IsValid)
            {
                System.Drawing.Image imag = System.Drawing.Image.FromStream(fileUpload.PostedFile.InputStream);

                string applicant_form = string.Empty;
                string applicant_name = txtBoxNama.Text;
                string nationality_code = ddlWargaNegara.SelectedItem.ToString();
                string applicant_icno = txtBoxKadPengenalan.Text;
                string applicant_malaysian = string.Empty;
                int applicant_visit = 0;
                DateTime applicant_arrival = GetDate("00-00-0000");
                string applicant_pass_placeissue = string.Empty;
                DateTime applicant_pass_expiry = GetDate("00-00-0000");
                string cardstatus_code = "New";
                DateTime applicant_dob = Convert.ToDateTime(txtBoxTarikhLahir.Text);
                string gender_code = ddlJantina.SelectedItem.ToString();
                string applicant_cardno = string.Empty;
                Byte[] applicant_photo = ConvertImageToByteArray(imag, System.Drawing.Imaging.ImageFormat.Jpeg);
                string applicant_photo_type = string.Empty;
                string applicant_oldcardno = txtBoxNomborKadLama.Text;
                string cardcolor_code = ddlWarnaKad.SelectedItem.ToString();
                string applicant_address = txtBoxAlamat.Text;
                string applicant_postcode = txtBoxPoskod.Text;
                string state_code = ddlNegeri.SelectedItem.Text;
                string country_code = ddlNegara.SelectedItem.Text;
                string applicant_telono = txtBoxTelefonPejabat.Text;
                string applicant_telhno = txtBoxNoTelKediaman.Text;
                string applicant_hpno = txtBoxBimbit.Text;
                string applicant_email = txtBoxEmel.Text;
                int media_id = GetMediaId(ddlMediaId.Text);
                string applicant_designation = txtBoxJawatanPekerjaan.Text;
                string applicant_ense_name = txtBoxNamaKetuaJawatan.Text;
                string applicant_ense_des = txtBoxJawatanKetuaOrg.Text;
                string applicant_ense_org = txtBoxNamaMedia.Text;
                int officer_id = 0;
                DateTime applicant_dateissue = GetDate("00-00-0000");
                DateTime applicant_dateexpiry = GetDate("00-00-0000");
                string validfor_code = string.Empty;
                int enterby_id = 0;
                DateTime enter_date = GetDate("00-00-0000");
                int editby_id = 0;
                DateTime edit_date = GetDate("00-00-0000");
                int printby_id = 0;
                DateTime print_date = GetDate("00-00-0000");
                string applicant_comment = string.Empty;
                DateTime Application_date = Convert.ToDateTime(DateTime.Now);
                int Record_Type = 0;
                string OldCard = string.Empty;//to insert code
                string PoliceReport = string.Empty;//to insert code
                string Application_Approval = string.Empty;
                string StatusKad = "Baru";
                string NoBorang = Utility.GetRunNo("NoBorang");
                string Catatan = string.Empty;
                string NamaPegawaiPengesahan = string.Empty;// to be updated on semakan page
                string JawatanPegawaiPengesahan = string.Empty; // to be updated on semakan page
                DateTime TarikhPengesahan = GetDate("00-00-0000"); // to be updated on semakan page
                bool IsAktif = true;

                int status = Emedia2uManager.MasukkanPermohonanBaru(applicant_form,
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
                                                                     NamaPegawaiPengesahan,
                                                                     JawatanPegawaiPengesahan,
                                                                     TarikhPengesahan,
                                                                     IsAktif);

                Response.Redirect("~/SemakPermohonan.aspx");
            }
        }

        public int GetMediaId(string text) 
        { 
            string s = text;
            string[] separate = s.Split('|');
            return Convert.ToInt16(separate[0]);
        }

        public static DateTime GetDate(string date)
        {
            try
            {
                return DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception err)
            {

                return new DateTime(1900, 01, 01);
            }
        }

        private string AutoGenerateNoBorang()
        {
            Random generator = new Random();
            String r = generator.Next(0, 1000000).ToString("D6");
           
            return string.Format("J{0}P",r);
        }

        private byte[] ConvertImageToByteArray(System.Drawing.Image imageToConvert,System.Drawing.Imaging.ImageFormat formatOfImage)
        {
            byte[] Ret;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageToConvert.Save(ms, formatOfImage);
                    Ret = ms.ToArray();
                }
            }
            catch (Exception) { throw; }
            return Ret;
        }

        protected void calendarTarikhLahir_SelectionChanged(object sender, EventArgs e)
        {
            txtBoxTarikhLahir.Text = calendarTarikhLahir.SelectedDate.ToString();
        }
    }
}