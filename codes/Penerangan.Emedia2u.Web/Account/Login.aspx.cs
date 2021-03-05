using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Penerangan.Emedia2u.Web.Managers;
using Penerangan.Emedia2u.Web.Helper;
using System.Web.Configuration;

namespace Penerangan.Emedia2u.Web.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //recaptcha.PublicKey = WebConfigurationManager.AppSettings["reCAPTCHAPublicKey"].ToString();
                //recaptcha.PrivateKey = WebConfigurationManager.AppSettings["reCAPTCHAPrivateKey"].ToString();   
            }
            RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
        }
        
        protected void LoginButton_Click1(object sender, EventArgs e)
        {
            //if (recaptcha.IsValid)
           //{
                var login = LoginUser;
                string us = login.UserName;
                string pswd = login.Password;
                
                bool result = Emedia2uManager.ValidateUser(us, pswd);
                if (result)
                {
                    Response.Redirect("~/SenaraiPermohonan.aspx");
                }
                else
                {

                }
           // }

            return;
        }
    }
}
