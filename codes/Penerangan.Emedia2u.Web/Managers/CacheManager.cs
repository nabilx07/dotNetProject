using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using Penerangan.Emedia2u.Web.DTO;

namespace Penerangan.Emedia2u.Web.Managers
{
    public static class CacheManager
    {
        //User role
        public const string ROLE_KEY = "Role";
        //all the lookup
        public const string KEY_LOAD_ALL = "Load_All";

        public static bool ManageCache(string codeType, out List<LookupDTO> lookUp)
        {
            List<LookupDTO> lookUp1 = new List<LookupDTO>();
            
            Cache myCache = null;
          
            myCache = HttpContext.Current.Cache;

            if (myCache != null && myCache[codeType] != null)
            {
                lookUp = myCache[codeType] as List<LookupDTO>;

                return true;
            }
            lookUp = lookUp1;

            return false;
           
            
        }

        public static void InsertCache(string key, List<LookupDTO> lookUp)
        {
            Cache myCache = null;

            myCache = HttpContext.Current.Cache;

            myCache.Insert(key, lookUp);

        }



        public static void DeleteCache(string key)
        {
            Cache myCache = null;

            myCache = HttpContext.Current.Cache;

            if (myCache != null && myCache[key] != null)
            {

                myCache.Remove(key);
            }
        }
        

         

    }
}