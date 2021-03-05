using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Recaptcha;

namespace Penerangan.Emedia2u.Web
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var filePath = HttpContext.Current.Request.FilePath;

            if (filePath.Contains("Login.aspx") || filePath.Contains("SyaratMemohon.aspx") || filePath.Contains("SenaraiPermohonan.aspx"))
            {
                NavigationMenu.Visible = false;
            }
            
        }
    }
}
