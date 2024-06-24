using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HomeC_DataAccess;

namespace HomeC_Business
{
    public class clsPurchase_SubCategory
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

        private int _PSCategoryID;

        public int PSCategoryID { get => _PSCategoryID; }
        public string SubCategoryName { get; set; }

        public int? CreatedByUserID { get; set; }
        public int? UpdatedByUserID { get; set; }

        public clsPurchase_SubCategory()
        {
            this._PSCategoryID = -1;
            this.SubCategoryName = "";
            _mode = enMode.AddNew;
        }
        private clsPurchase_SubCategory(int PSCategoryID, string SubCategoryName, int? CreatedByUserID, int? UpdatedByUserID)
        {
            this._PSCategoryID = PSCategoryID;
            this.SubCategoryName = SubCategoryName;
            this.CreatedByUserID = CreatedByUserID;
            this.UpdatedByUserID = UpdatedByUserID;
            _mode = enMode.Update;
        }
        public void SetValues(string SubCategoryName,int UserID)
        {

            this.SubCategoryName = SubCategoryName;
            if(_mode == enMode.AddNew)
                this.CreatedByUserID = UserID;
            else
                this.UpdatedByUserID = UserID;
        }


        private bool _AddNewPurchase_SubCategories()
        {
            int ID = -1;
            clsPurchase_SubCategoriesData.Insert_Purchase_SubCategories(ref ID, this.SubCategoryName,this.CreatedByUserID,this.UpdatedByUserID);
            this._PSCategoryID = ID;
            return this._PSCategoryID != -1;
        }
        private bool _UpdatePurchase_SubCategories()
        {
            return clsPurchase_SubCategoriesData.Update_Purchase_SubCategories(this._PSCategoryID, this.SubCategoryName,CreatedByUserID,UpdatedByUserID);
        }
        public bool SavePurchase_SubCategories()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewPurchase_SubCategories())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePurchase_SubCategories();
            }
            return false;
        }



        public static clsPurchase_SubCategory FindPurchase_SubCategories(int PSCategoryID)
        {
            string CategoryName = "";
            int? CreatedByUserID = null;
            int? UpdatedByUserID = null;


            if (clsPurchase_SubCategoriesData.FindPurchase_SubCategories(PSCategoryID, ref CategoryName,ref CreatedByUserID,ref UpdatedByUserID))
            {

                return new clsPurchase_SubCategory(PSCategoryID, CategoryName,CreatedByUserID,UpdatedByUserID);
            }
            else
            {
                return null;
            }
        }
        public static clsPurchase_SubCategory FindPurchase_SubCategories(string CategoryName)
        {

            int PSCategoryID = -1;
            int? CreatedByUserID = null;
            int? UpdatedByUserID = null;
            if (clsPurchase_SubCategoriesData.FindPurchase_SubCategories(ref PSCategoryID, CategoryName,ref CreatedByUserID,ref UpdatedByUserID))
            {

                return new clsPurchase_SubCategory(PSCategoryID, CategoryName, CreatedByUserID, UpdatedByUserID);
            }
            else
            {
                return null;
            }
        }


        public static DataTable GetAllPurchase_SubCategories()
        {
            return clsPurchase_SubCategoriesData.GetAllPurchase_Categories();
        }
        public static DataTable GetAllPurchase_SubCategoriesByPCategory(int PCategory)
        {
            return clsPurchase_SubCategoriesData.GetAllPurchase_CategoriesByPCategory(PCategory);
        }


        public static bool DeletePurchase_SubCategories(int PSCategoryID)
        {

           //if( !clsPurchaseSubBaseCategories.DeleteSubBaseCategory(PSCategoryID))
           //     return false;

                return clsPurchase_SubCategoriesData.DeletePurchase_SubCategories(PSCategoryID);
            
        }

        public  bool DeletePurchase_SubCategories()
        {

            //if( !clsPurchaseSubBaseCategories.DeleteSubBaseCategory(PSCategoryID))
            //     return false;

            return clsPurchase_SubCategoriesData.DeletePurchase_SubCategories(this.PSCategoryID);

        }
    }

}
