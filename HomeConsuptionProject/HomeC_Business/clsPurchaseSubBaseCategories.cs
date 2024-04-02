using HomeC_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_Business
{
    public class clsPurchaseSubBaseCategories
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

        int PSCategory { get; set; }

        public int? CreatedByUserID { get; set; }
        public int? UpdatedByUserID { get; set; }

        public clsPurchase_SubCategory SubCategory { get => clsPurchase_SubCategory.FindPurchase_Category(PSCategory); }

        public clsPurchase_Category objPCategory { get => clsPurchase_Category.FindPurchase_Category(PCategory); }

        int PCategory { get; set; }

        public clsPurchaseSubBaseCategories()
        {
            this.PSCategory = -1;
            this.PCategory = -1;
            _mode = enMode.AddNew;
        }

        private clsPurchaseSubBaseCategories(int PSCategory, int PCategory)
        {
            this.PSCategory = PSCategory;
            this.PCategory = PCategory;
            _mode = enMode.Update;
        }
         public void SetValues(int PSCategory, int PCategory)
        {
            this.PSCategory = PSCategory;
            this.PCategory = PCategory;
           
        }

        private bool _AddNewPurchaseSubBaseCategories()
        {
            return clsPurchaseSubBaseCategoriesData.Insert_PurchaseSubBaseCategories(this.PSCategory, this.PCategory,this.CreatedByUserID,this.UpdatedByUserID);
           
        }

        //private bool _UpdatePurchaseSubBaseCategories()
        //{
        //    return clsPurchaseSubBaseCategoriesData.Update_PurchaseSubBaseCategories(this.PSCategory, this.PCategory);
        //}

        public bool SavePurchaseSubBaseCategories()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewPurchaseSubBaseCategories())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    //return _UpdatePurchaseSubBaseCategories();
                    break;
            }
            return false;
        }

        public bool DeleteSubBaseCategory ()
        {
            return DeleteSubBaseCategory(PSCategory, PCategory);
        }
        public static bool  DeleteSubBaseCategory(int PSCategory,int PCategory)
        {
            if(clsPurchaseData.IsPurchseExsits(PCategory, PSCategory))
                return false;

         return clsPurchaseSubBaseCategoriesData.DeletePurchaseSubBaseCategories(PSCategory, PCategory);
        }
         public static bool  DeleteSubBaseCategory(int PSCategory)
        {
            if (clsPurchaseData.IsPurchseExsits(PSCategory))
                return false;

         return clsPurchaseSubBaseCategoriesData.DeletePurchaseSubBaseCategories( PSCategory);
        }

       static public clsPurchaseSubBaseCategories FindPurchaseSubBaseCategoriesData (int PSCategory,int PCategory)
        {
            int? CreatedByUserID = null;
            int? UpdatedByUserID = null;

            if (clsPurchaseSubBaseCategoriesData.FindPurchase_SubCategories(PSCategory, PCategory, ref  CreatedByUserID, ref  UpdatedByUserID))
                return new clsPurchaseSubBaseCategories(PSCategory, PCategory);
            else
                return null;
        }


        static public DataTable GetAllPurchase_SubBaseCategoriesByPCategory(int PCategory)
        {
           return clsPurchaseSubBaseCategoriesData.GetAllPurchase_SubBaseCategoriesByPCategory(PCategory);
        }
        static public DataTable GetAllPurchase_SubBaseCategoriesByPCategory(string CategoryName)
        {
           return clsPurchaseSubBaseCategoriesData.GetAllPurchase_SubBaseCategoriesByPCategory(CategoryName);
        }

    }

}
