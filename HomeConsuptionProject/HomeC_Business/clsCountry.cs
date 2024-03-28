using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using HomeC_DataAccess;

namespace HomeC_Business
{
    public class clsCountry
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

       public int CountryID { get; set; }
       public string CountryName { get; set; }
        public clsCountry()
        {
            this.CountryID = -1;
            this.CountryName = "";
            _mode = enMode.AddNew;
        }
        private clsCountry(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            _mode = enMode.Update;
        }
        private bool _AddNewCountries()
        {
            int ID = -1;
            clsCountriesData.InsertCountry(ref ID, this.CountryName);
            this.CountryID = ID;
            return this.CountryID != -1;
        }
        private bool _UpdateCountries()
        {
            return clsCountriesData.UpdateCountry(this.CountryID, this.CountryName);
        }
        public bool SaveCountries()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountries())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateCountries();
            }
            return false;
        }

        static public DataTable GetAllCountries()
        {
            return clsCountriesData.GetAllCountries();
        }

        public static clsCountry FindCountry(int CountryID)
        {
            string CountryName = "";

            if (clsCountriesData.FindCountry(CountryID, ref CountryName))
            {

                return new clsCountry(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }


    }

}
