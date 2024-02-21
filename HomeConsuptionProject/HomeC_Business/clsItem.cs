using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeC_DataAccess;

namespace HomeC_Business
{
    public class clsItem
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

        int _ItemID;

      public int ItemID { get => _ItemID; }
      public  string ItemName_AR { get; set; }
      public  string ItemName_EN { get; set; }
      public  string ImagePath { get; set; }
      public  int CategoryID { get; set; }
      public  clsCategory objCategory { get;  }
      public  float Price { get; set; }
        public clsItem()
        {
            this._ItemID = -1;
            this.ItemName_AR = "";
            this.ItemName_EN = "";
            this.CategoryID = -1;
            this.Price = -1;
            _mode = enMode.AddNew;
        }
        private clsItem(int ItemID, string ItemName_AR, string ItemName_EN, int CategoryID, float Price, string imagePath)
        {
            this._ItemID = ItemID;
            this.ItemName_AR = ItemName_AR;
            this.ItemName_EN = ItemName_EN;
            this.CategoryID = CategoryID;
            this.Price = Price;
            objCategory = clsCategory.FindCategory(CategoryID);
            _mode = enMode.Update;
            ImagePath = imagePath;
        }

        public void SetItemValues(string ItemName_AR, string ItemName_EN, int CategoryID, float Price,string ImagePath)
        {
            this.ItemName_AR = ItemName_AR;
            this.ItemName_EN = ItemName_EN;
            this.CategoryID = CategoryID;
            this.Price = Price;
            this.ImagePath = ImagePath;
          
        }



        private bool _AddNewItems()
        {
            int ID = -1;
            clsItemData.InsertItem(ref ID, this.ItemName_AR, this.ItemName_EN, this.CategoryID, this.Price,this.ImagePath);
            this._ItemID = ID;
            return this._ItemID != -1;
        }
        private bool _UpdateItems()
        {
            return clsItemData.UpdateItem(this._ItemID, this.ItemName_AR, this.ItemName_EN, this.CategoryID, this.Price,this.ImagePath);
        }
        public bool SaveItems()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewItems())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateItems();
            }
            return false;
        }





        public static clsItem FindItem(int ItemID)
        {
            string ItemName_AR = "";
            string ItemName_EN = "";
            string ImagePath = "";
            int CategoryID = -1;
            float Price = -1;

            if (clsItemData.FindItem(ItemID, ref ItemName_AR, ref ItemName_EN, ref CategoryID, ref Price,ref ImagePath))
            {

                return new clsItem(ItemID, ItemName_AR, ItemName_EN, CategoryID, Price, ImagePath);
            }
            else
            {
                return null;
            }
        }


        public static bool DeleteItem(int ItemID)
        { 
            return clsItemData.DeleteItem(ItemID);
        }
         public  bool DeleteItem()
        { 
            return clsItemData.DeleteItem(_ItemID);
        }



        public static DataTable GetAllItems(int PageNumber,int RowCountPerPage,ref int RowCount)
        {
            return clsItemData.GetAllItems(PageNumber,RowCountPerPage,ref RowCount);
        }




    }



}
