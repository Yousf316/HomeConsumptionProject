using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeC_DataAccess;
namespace HomeC_Business
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

        int UserID { get; set; }
        int PersonID { get; set; }
        string Password { get; set; }
        bool IsActive { get; set; }
        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.Password = "";
            this.IsActive = false;
            _mode = enMode.AddNew;
        }
        private clsUser(int UserID, int PersonID, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.Password = Password;
            this.IsActive = IsActive;
            _mode = enMode.Update;
        }
        private bool _AddNewUsers()
        {
            int ID = -1;
            clsUserData.InsertUser(ref ID, this.PersonID, this.Password, this.IsActive);
            this.UserID = ID;
            return this.UserID != -1;
        }
        private bool _UpdateUsers()
        {
            return clsUserData.UpdateUser(this.UserID, this.PersonID, this.Password, this.IsActive);
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
            bool IsActive = false;

            if (clsUserData.FindUser(UserID, ref PersonID, ref Password, ref IsActive))
            {

                return new clsUser(UserID, PersonID, Password, IsActive);
            }
            else
            {
                return null;
            }
        }


    }

}
