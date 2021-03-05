using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Recaptcha;

namespace Penerangan.Emedia2u.Web
{
    public partial class LamanUtama : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TODO: Remove this after test
            //if (!Page.IsPostBack)
            //{
            //    recaptcha.PublicKey = System.Configuration.ConfigurationManager.AppSettings["reCAPTCHAPublicKey"].ToString();
            //    recaptcha.PrivateKey = System.Configuration.ConfigurationManager.AppSettings["reCAPTCHAPrivateKey"].ToString();
            //}
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //TODO: Remove this after test
            /*(if (recaptcha.IsValid)
            {
                if (chxboxTerma.Checked == true)
                {
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                    lblResult.Text = "Incorrect!!!"; // try again 
                }
            }
            lblResult.Text = "Sila klik pada kotak semak"; // try again*/
        }
    }
}
