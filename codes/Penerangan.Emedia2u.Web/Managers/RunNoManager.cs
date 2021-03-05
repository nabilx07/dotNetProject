using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Penerangan.Emedia2u.Web.DTO;
using Penerangan.Emedia2u.Web.Provider;

namespace Penerangan.Emedia2u.Web.Managers
{
    public static class RunNoManager
    {
        public static RunNoDTO GetRunNo(string runNoType)
        {
            return RunNoProvider.GetRunNo(runNoType);
        }

        public static void UpdateRunNo(string runNoType)
        {
            RunNoProvider.UpdateRunNo(runNoType);
        }
    }
}
