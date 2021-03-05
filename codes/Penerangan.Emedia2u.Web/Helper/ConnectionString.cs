using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
namespace Penerangan.Emedia2u.Web.Helper
{
    public class ConnectionString
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["EmediaConnStringMSSQL"].ConnectionString;
        }
    }
}