using HomeC_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_Business
{
    public class clsCategoriesOfPurchases
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

        public int PCategoryID { get; set; }
        public int PurchaseID { get; set; }


        public clsCategoriesOfPurchases()
        {
            this.PCategoryID = -1;
            this.PurchaseID = -1;
            _mode = enMode.AddNew;
        }


        private clsCategoriesOfPurchases(int PCategoryID, int PurchaseID)
        {
            this.PCategoryID = PCategoryID;
            this.PurchaseID = PurchaseID;
            _mode = enMode.Update;
        }

        private bool _AddNewCategoriesOfPurchases()
        {

            clsCategoriesOfPurchasesData.Insert_CategoriesOfPurchases( PCategoryID, this.PurchaseID);
          
            return this.PCategoryID != -1;
        }

        private bool _UpdateCategoriesOfPurchases()
        {
            return clsCategoriesOfPurchasesData.Update_CategoriesOfPurchases(this.PCategoryID, this.PurchaseID);
        }

        public bool SaveCategoriesOfPurchases()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewCategoriesOfPurchases())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateCategoriesOfPurchases();
            }
            return false;
        }


        public static clsCategoriesOfPurchases FindCategoriesOfPurchases(int PCategoryID)
        {
            int PurchaseID = -1;

            if (clsCategoriesOfPurchasesData.FindCategoriesOfPurchases(PCategoryID, ref PurchaseID))
            {

                return new clsCategoriesOfPurchases(PCategoryID, PurchaseID);

            }
            else
            {
                return null;
            }

        }


        public static bool DeleteCategoriesOfPurchases(int PurchaseID)
        {
            return clsCategoriesOfPurchasesData.DeleteDBCategoriesOfPurchases(PurchaseID);
        }


    }



}
