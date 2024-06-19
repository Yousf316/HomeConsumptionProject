using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using HomeC_DataAccess;
using HomeConsuption;

namespace HomeC_Business
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

        private  string _Password;
       public int UserID { get; set; }
       public int PersonID { get; set; }
       public string Password { get; set; }
       public string UserName { get; set; }
       public bool IsActive { get; set; }
        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.Password = "";
            this.UserName = "";
            this.IsActive = false;
            _mode = enMode.AddNew;
        }
        private clsUser(int UserID,string UserName, int PersonID, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.Password = "*****";
            this.UserName = UserName;
            this.IsActive = IsActive;
            this._Password = Password;
            _mode = enMode.Update;
        }

        public void SetValues (int PersonID,string UserName, string Password, bool IsActive)
        {
          
            this.PersonID = PersonID;
            //this.Password = Password;
            this._Password = clsValidatoinBus.HashCodeCompute(Password);
            this.UserName = UserName;
            this.IsActive = IsActive;
            
        }
        private bool _AddNewUsers()
        {
            int ID = -1;
            clsUserData.InsertUser(ref ID, UserName, this.PersonID, this._Password, this.IsActive);
            this.UserID = ID;
            return this.UserID != -1;
        }
        private bool _UpdateUsers()
        {
            return clsUserData.UpdateUser(this.UserID, UserName, this.PersonID, this._Password, this.IsActive);
        }
        public bool SaveUsers()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewUsers())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUsers();
            }
            return false;
        }
        public static clsUser FindUser(int UserID)
        {
            int PersonID = -1;
            string Password = "";
            string UserName = "";
            bool IsActive = false;

            if (clsUserData.FindUser(UserID,ref UserName, ref PersonID, ref Password, ref IsActive))
            {
                
                return new clsUser(UserID,UserName, PersonID, Password, IsActive);
            }
            else
            {
                return null;
            }
        }


        static public bool IsExist(int PersonID)
        {
            return clsUserData.IsExist(PersonID);
        }

        static public bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }
         
        static public DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static clsUser FindUserByUserNameAndPassword(string UserName, string Password)
        {
            int PersonID = -1;
            int UserID = -1;

            Password = clsValidatoinBus.HashCodeCompute(Password);
            bool IsActive = false;

            if (clsUserData.FindUserByUsernameAndPassword(UserName, Password, ref UserID, ref PersonID, ref IsActive))
            {

                return new clsUser(UserID,  UserName, PersonID, Password, IsActive);
            }
            else
            {
                return null;
            }


        }

        public  bool IsPasswordMatching(string Password)
        {
          string HashPassword =clsValidatoinBus.HashCodeCompute(Password);
            return (HashPassword == _Password);
        }

        public string GetCurrentPassword()
        {
            return _Password;
        }
        public void setPassword(string Password)
        {
           string HashinPassword = clsValidatoinBus.HashCodeCompute(Password);
             _Password = HashinPassword;
        }
    }

}
