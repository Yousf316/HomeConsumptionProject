using HomeC_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_Business
{
    public class clsStore
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

        int StoreID { get; set; }
       public string StoreName { get; set; }
       public string Location { get; set; }
        public clsStore()
        {
            this.StoreID = -1;
            this.StoreName = "";
            this.Location = "";
            _mode = enMode.AddNew;
        }
        private clsStore(int StoreID, string StoreName, string Location)
        {
            this.StoreID = StoreID;
            this.StoreName = StoreName;
            this.Location = Location;
            _mode = enMode.Update;
        }
        private bool _AddNewStores()
        {
            int ID = -1;
            clsStoreData.InsertStore(ref ID, this.StoreName, this.Location);
            this.StoreID = ID;
            return this.StoreID != -1;
        }
        private bool _UpdateStores()
        {
            return clsStoreData.UpdateStore(this.StoreID, this.StoreName, this.Location);
        }
        public bool SaveStores()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewStores())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateStores();
            }
            return false;
        }


        public static clsStore Findstore(int StoreID)
        {
            string StoreName = "";
            string Location = "";

            if (clsStoreData.FindStore(StoreID, ref StoreName, ref Location))
            {

                return new clsStore(StoreID, StoreName, Location);
            }
            else
            {
                return null;
            }
        }

        public static bool DeleteStore(int StoreID)
        {
          return clsStoreData.DeleteStore(StoreID);
        }
        public  bool DeleteStore()
        {
          return clsStoreData.DeleteStore(this.StoreID);
        }


        public static DataTable GetAllStores()
        {
          return clsStoreData.GetAllStores();
        }
         public static DataTable GetStoresByName(string StoreNAme)
        {
          return clsStoreData.GetStoreByName(StoreNAme);
        }

        public int GetStoreID ()
        {
            return StoreID;
        }

    }

}
