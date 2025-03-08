using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusiness
{
    public class clsUser
    {
        enum enMode { AddUser = 0, UpdateUser = 1 };
        enMode _Mode = enMode.AddUser;

        public int userID { get; set; }
        public int personID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public clsPerson person { get; set; }

        public clsUser()
        {
            
        }

        public clsUser(int userID, int PersonID,string UserName, string Password, bool IsActive)
        {
            this.userID = userID;
            this.personID = PersonID;
            this.userName = UserName;
            this.isActive = IsActive;
            this.password = password;
            this._Mode = enMode.UpdateUser;
        }

        public bool isActive { get; set; }

        static public DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static clsUser FindUserByID(int userID)
        {
            int PersonID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool user =  clsUserData.GetUserById(userID, ref PersonID, ref UserName, ref Password, ref IsActive);

            if(user == true)
            {
                return new clsUser(userID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }
        }

        public static clsUser FindUserByPersonID(int PersonID)
        {
            int UserID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool user = clsUserData.GetUserByPersonID(ref UserID, PersonID, ref UserName, ref Password, ref IsActive);

            if (user == true)
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }
        }

        public static clsUser FindUserByUserNameAndPassword(string UserName, string Password)
        {
            int UserID = -1;
            int PersonID = -1;
            bool IsActive = false;

            bool user = clsUserData.GetUserByUserNameAndPassword(ref UserID, ref PersonID, UserName, Password, ref IsActive);

            if (user)
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }
        }

        public static bool isUserExist(int UserID)
        {
           return clsUserData.IsUserExists(UserID);
        }
    }
}
