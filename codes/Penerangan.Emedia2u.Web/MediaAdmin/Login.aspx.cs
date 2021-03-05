using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Penerangan.Emedia2u.Web.Managers;
using Penerangan.Emedia2u.Web.Helper;
using System.Web.Configuration;

namespace Penerangan.Emedia2u.Web.MediaAdmin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            recaptcha.PublicKey = WebConfigurationManager.AppSettings["reCAPTCHAPublicKey"].ToString();
            recaptcha.PrivateKey = WebConfigurationManager.AppSettings["reCAPTCHAPrivateKey"].ToString();   
        }

        protected void txtButtonLoginSubmit_Click(object sender, EventArgs e)
        {
            if (recaptcha.IsValid)
            {
                string username = txtboxUsername.Text;
                string password = txtboxPassword.Text;

                bool result = Emedia2uManager.ValidateUser(username, password);
                if (result == true) 
                {
                    Response.Redirect("~/SenaraiPermohonan.aspx");
                }
                else
                {
                    lblError.Enabled = true;
                    lblError.Text = "Akaun anda tidak betul , sila log sekali lagi";
                    return;
                }
            }
            else
            {
                lblError.Enabled = true;
                lblError.Text = "Captcha tidak betul sila masuk sekali lagi.";
            }
        }

    }
}