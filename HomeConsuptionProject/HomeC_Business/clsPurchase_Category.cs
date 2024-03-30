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
        public int? CreatedByUserID { get; set; }
        public int? UpdatedByUserID { get; set; }
        public clsPurchase_Category()
        {
            this.PCategoryID = -1;
            this.CategoryName = "";
            _mode = enMode.AddNew;
        }
        private clsPurchase_Category(int PCategoryID, string CategoryName, int? CreatedByUserID,int? UpdatedByUser)
        {
            this.PCategoryID = PCategoryID;
            this.CategoryName = CategoryName;
            this.CreatedByUserID = CreatedByUserID;
            this.UpdatedByUserID = UpdatedByUser;
            _mode = enMode.Update;
        }
        private bool _AddNewPurchase_Categories()
        {
            int ID = -1;
            clsPurchase_CategoriesData.Insert_Purchase_Categories(ref ID, this.CategoryName,this.CreatedByUserID,this.UpdatedByUserID);
            this.PCategoryID = ID;
            return this.PCategoryID != -1;
        }
        private bool _UpdatePurchase_Categories()
        {
            return clsPurchase_CategoriesData.Update_Purchase_Categories(this.PCategoryID, this.CategoryName, this.CreatedByUserID, this.UpdatedByUserID);
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
            int? CreatedByUserID = null;
            int? UpdatedByUserID = null;

            if (clsPurchase_CategoriesData.FindPurchase_Categories(PCategoryID, ref CategoryName,ref CreatedByUserID,ref UpdatedByUserID))
            {

                return new clsPurchase_Category(PCategoryID, CategoryName,CreatedByUserID,UpdatedByUserID);
            }
            else
            {
                return null;
            }
        }
         public static clsPurchase_Category FindPurchase_Category(string CategoryName)
        {
          
            int PCategoryID = -1;
            int? CreatedByUserID = null;
            int? UpdatedByUserID = null;
            if (clsPurchase_CategoriesData.FindPurchase_Categories(ref PCategoryID,  CategoryName,ref CreatedByUserID, ref UpdatedByUserID))
            {

                return new clsPurchase_Category(PCategoryID, CategoryName, CreatedByUserID, UpdatedByUserID);
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
