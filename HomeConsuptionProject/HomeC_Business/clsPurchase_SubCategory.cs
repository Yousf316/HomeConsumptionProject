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



        public clsPurchase_SubCategory()
        {
            this._PSCategoryID = -1;
            this.SubCategoryName = "";
            _mode = enMode.AddNew;
        }
        private clsPurchase_SubCategory(int PSCategoryID, string SubCategoryName)
        {
            this._PSCategoryID = PSCategoryID;
            this.SubCategoryName = SubCategoryName;
            _mode = enMode.Update;
        }
        public void SetValues(string SubCategoryName)
        {

            this.SubCategoryName = SubCategoryName;

        }


        private bool _AddNewPurchase_SubCategories()
        {
            int ID = -1;
            clsPurchase_SubCategoriesData.Insert_Purchase_SubCategories(ref ID, this.SubCategoryName);
            this._PSCategoryID = ID;
            return this._PSCategoryID != -1;
        }
        private bool _UpdatePurchase_SubCategories()
        {
            return clsPurchase_SubCategoriesData.Update_Purchase_SubCategories(this._PSCategoryID, this.SubCategoryName);
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



        public static clsPurchase_SubCategory FindPurchase_Category(int PSCategoryID)
        {
            string CategoryName = "";


            if (clsPurchase_SubCategoriesData.FindPurchase_SubCategories(PSCategoryID, ref CategoryName))
            {

                return new clsPurchase_SubCategory(PSCategoryID, CategoryName);
            }
            else
            {
                return null;
            }
        }
        public static clsPurchase_SubCategory FindPurchase_SubCategories(string CategoryName)
        {

            int PSCategoryID = -1;
            if (clsPurchase_SubCategoriesData.FindPurchase_SubCategories(ref PSCategoryID, CategoryName))
            {

                return new clsPurchase_SubCategory(PSCategoryID, CategoryName);
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
            clsPurchaseSubBaseCategories.DeleteSubBaseCategory(PSCategoryID);
                return clsPurchase_SubCategoriesData.DeletePurchase_SubCategories(PSCategoryID);
            
        }
    }

}
