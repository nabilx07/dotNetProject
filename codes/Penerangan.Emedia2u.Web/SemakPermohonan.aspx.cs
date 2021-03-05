using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Penerangan.Emedia2u.Web.Helper;
using Penerangan.Emedia2u.Web.Managers;
using Penerangan.Emedia2u.Web.DTO;

namespace Penerangan.Emedia2u.Web
{
    public partial class SemakPermohonan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rdBtnListBorang.SelectedIndex = 0;
            }
        }

        protected void btnHantar_Click(object sender, EventArgs e)
        {
            if (rdBtnListBorang.SelectedItem.Value == "0" && !string.IsNullOrEmpty(txtBoxNoBorang.Text))
            {
                string NoBorang = txtBoxNoBorang.Text;
                var applicantNoBorang = Emedia2uManager.LoadViaNoBorang(NoBorang);
                txtRsltNoBorang.Text = applicantNoBorang.CardNo;
                txtRsltMedia.Text = applicantNoBorang.Name;
                txtRsltTarikh.Text = applicantNoBorang.DateIssue;
                txtRsltStatus.Text = applicantNoBorang.StatusKad;

            }

            if (rdBtnListBorang.SelectedItem.Value == "1" && !string.IsNullOrEmpty(txtBoxKadPengenalan.Text))
            {
                string icNo = txtBoxKadPengenalan.Text;
                var applicantKadPengenalan = Emedia2uManager.LoadViaCardNo(icNo);
                txtRsltNoBorang.Text = applicantKadPengenalan.CardNo;
                txtRsltMedia.Text = applicantKadPengenalan.Name;
                txtRsltTarikh.Text = applicantKadPengenalan.DateIssue;
                txtRsltStatus.Text = applicantKadPengenalan.StatusKad;
            }

        }
        
    }
}