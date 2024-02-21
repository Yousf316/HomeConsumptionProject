using HomeC_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_Business
{
    public class clsCategory
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

       public int CategoryID { get; set; }
       public string CategoryName { get; set; }
        public clsCategory()
        {
            this.CategoryID = -1;
            this.CategoryName = "";
            _mode = enMode.AddNew;
        }
        private clsCategory(int CategoryID, string CategoryName)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
            _mode = enMode.Update;
        }
        
        public  void SetCategoryInfo( string CategoryName)
        {
            this.CategoryName = CategoryName;
        }
        private bool _AddNewCategories()
        {
            int ID = -1;
            clsCategoryData.InsertCategory(ref ID, this.CategoryName);
            this.CategoryID = ID;
            return this.CategoryID != -1;
        }
        private bool _UpdateCategories()
        {
            return clsCategoryData.UpdateCategory(this.CategoryID, this.CategoryName);
        }
        public static clsCategory FindCategory(int CategoryID)
        {
            string CategoryName = "";

            if (clsCategoryData.FindCategory(CategoryID, ref CategoryName))
            {

                return new clsCategory(CategoryID, CategoryName);
            }
            else
            {
                return null;
            }
        }
        public static clsCategory FindCategory(string CategoryName)
        {
            int CategoryID =-1;

            if (clsCategoryData.FindCategoryByName(CategoryName, ref CategoryID))
            {

                return new clsCategory(CategoryID, CategoryName);
            }
            else
            {
                return null;
            }
        }



        public bool SaveCategories()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewCategories())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateCategories();
            }
            return false;
        }


        public static bool DeleteCategories(int CategoryID)
        {
            return clsCategoryData.DeleteCategory(CategoryID);
        }
        public  bool DeleteCategories()
        {
            return clsCategoryData.DeleteCategory(this.CategoryID);
        }

        public static DataTable GetAllCatgoriesInfo()
        {
            return clsCategoryData.GetAllCategories();
        }
         public static DataTable GetCategoryByNameInfo(string CategoryName)
        {
            return clsCategoryData.GetCategoryByName(CategoryName);
        }

    }

}
