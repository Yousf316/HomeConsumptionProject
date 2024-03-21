using HomeC_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_Business
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

        int PersonID { get; set; }
        string FirstName { get; set; }
        string SecondName { get; set; }
        string ThirdName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }
        int NationalityCountryID { get; set; }
        public clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.PhoneNumber = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            _mode = enMode.AddNew;
        }
        private clsPerson(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName, string PhoneNumber, string Email, int NationalityCountryID)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            _mode = enMode.Update;
        }

        public void SetValues( string FirstName, string SecondName, string ThirdName, string LastName, string PhoneNumber, string Email, int NationalityCountryID)
        {
           
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            
        }

        private bool _AddNewPeople()
        {
            int ID = -1;
            clsPersonData.Insert_Person(ref ID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.PhoneNumber, this.Email, this.NationalityCountryID);
            this.PersonID = ID;
            return this.PersonID != -1;
        }
        private bool _UpdatePeople()
        {
            return clsPersonData.Update_Person(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.PhoneNumber, this.Email, this.NationalityCountryID);
        }
        public bool SavePeople()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewPeople())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePeople();
            }
            return false;
        }

        public static clsPerson FindPerson(int PersonID)
        {
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            string PhoneNumber = "";
            string Email = "";
            int NationalityCountryID = -1;

            if (clsPersonData.FindPerson(PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref PhoneNumber, ref Email, ref NationalityCountryID))
            {

                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, PhoneNumber, Email, NationalityCountryID);
            }
            else
            {
                return null;
            }
        }

         public bool DeletePerson()
        {
            return clsPersonData.DeletePerson(this.PersonID);
        }

        static public bool DeletePerson(int PersonID)
        { 
            return clsPersonData.DeletePerson(PersonID);
        }

    }

}
