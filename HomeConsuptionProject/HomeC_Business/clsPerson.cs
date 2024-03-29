﻿using HomeC_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_Business
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

       public int PersonID { get; set; }
       public string FirstName { get; set; }
       public string SecondName { get; set; }
       public string ThirdName { get; set; }
       public string LastName { get; set; }
       public string PhoneNumber { get; set; }
       public string Email { get; set; }
       public int NationalityCountryID { get; set; }

        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }

        }


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
        

        static public bool IsPersonExsits(int PersonID)
        {
            return clsPersonData.IsPersonExsits(PersonID);
        }

        static public DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }
        
    }

}
