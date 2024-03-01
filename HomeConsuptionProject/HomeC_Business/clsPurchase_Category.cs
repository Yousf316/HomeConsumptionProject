using HomeC_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_Business
{
    public class clsPurchase_Category
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

       public int PCategoryID { get; set; }
       public string CategoryName { get; set; }
        public clsPurchase_Category()
        {
            this.PCategoryID = -1;
            this.CategoryName = "";
            _mode = enMode.AddNew;
        }
        private clsPurchase_Category(int PCategoryID, string CategoryName)
        {
            this.PCategoryID = PCategoryID;
            this.CategoryName = CategoryName;
            _mode = enMode.Update;
        }
        private bool _AddNewPurchase_Categories()
        {
            int ID = -1;
            clsPurchase_CategoriesData.Insert_Purchase_Categories(ref ID, this.CategoryName);
            this.PCategoryID = ID;
            return this.PCategoryID != -1;
        }
        private bool _UpdatePurchase_Categories()
        {
            return clsPurchase_CategoriesData.Update_Purchase_Categories(this.PCategoryID, this.CategoryName);
        }
        public bool SavePurchase_Categories()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewPurchase_Categories())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePurchase_Categories();
            }
            return false;
        }


        public static clsPurchase_Category FindPurchase_Category(int PCategoryID)
        {
            string CategoryName = "";

            if (clsPurchase_CategoriesData.FindPurchase_Categories(PCategoryID, ref CategoryName))
            {

                return new clsPurchase_Category(PCategoryID, CategoryName);
            }
            else
            {
                return null;
            }
        }
         public static clsPurchase_Category FindPurchase_Category(string CategoryName)
        {
          
            int PCategoryID = -1;
            if (clsPurchase_CategoriesData.FindPurchase_Categories(ref PCategoryID,  CategoryName))
            {

                return new clsPurchase_Category(PCategoryID, CategoryName);
            }
            else
            {
                return null;
            }
        }


        public static DataTable GetAllPurchase_Categories()
        {
            return clsPurchase_CategoriesData.GetAllPurchase_Categories();
        }

    }


}
