using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Penerangan.Emedia2u.Web.DTO;
using Penerangan.Emedia2u.Web.Provider;

namespace Penerangan.Emedia2u.Web.Managers
{
    public static class UserManager
    {
        #region load

        /*public static string[] GetRoles(string userName)
        {
            return new AduanRoleProvider().GetRolesForUser(userName);
        }*/

        /*public static int GetUserID(string userName)
        {
            return UserProvider.GetUserID(userName);
        }*/

        public static string GetPassword(string username)
        {
            return LoginProvider.GetPassword(username);
        }

        /*public static UserDTO Load(string userName)
        {
            return UserProvider.Load(userName);
        }*/

        /*public static void GetUserInfo(string userName, out string nickName, out string tarikhlastLogin)
        {
            UserProvider.GetUserInfo(userName, out nickName, out tarikhlastLogin);
        }*/

        /*public static void UpdateLastLogin(string userName)
        {
            UserProvider.UpdateLastLogin(userName);
        }*/
       

        /*public static List<UserDTO> LoadAll()
        {
            return UserProvider.LoadAll();
        }*/
        #endregion

        #region insert
        /*public static int AddUser(string UserID, string NickName, string UserName, string LoginPwd, string IsActive, string CreatedBy,string UserRole)
        {
            return UserProvider.AddUser(UserID, NickName, UserName, LoginPwd, IsActive, CreatedBy, UserRole);
        }*/
        #endregion

        #region update
        /*public static void Update(string userID, string NickName, string isActive, string userRole ,string modifiedBy)
        {
            UserProvider.Update(userID, NickName, isActive, userRole, modifiedBy);
        }*/

        //public static void UpdateLastLogin(string userID)
        //{
        //    UserProvider.UpdateLastLogin(userID);
        //}

        /*public static void UpdatePassword(string userName, string pwd)
        {
            UserProvider.UpdatePassword(userName, pwd);
        }*/
        #endregion

        #region static delete
        /*public static void DeleteUser(string UserID)
        {
            UserProvider.DeleteUser(UserID);
        }*/
        #endregion



    }
}
