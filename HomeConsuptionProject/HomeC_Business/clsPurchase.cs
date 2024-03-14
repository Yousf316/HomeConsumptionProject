using HomeC_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_Business
{
    public class clsPurchase
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

        int _PurchaseID;

        public int PurchaseID { get => _PurchaseID; }

       public DateTime IssueDate { get; set; }
       public float TotalBeforTax { get; set; }
        
       public clsStore objStoreInfo { get; }
       public float TaxAmount { get; set; }
       public float TotalAfterTax { get; set; }
       public int StoreID { get; set; }
       public int Type { get; set; }
       public float? Discount { get; set; }

       public int PCategoryID { get; set; }

      
        public clsPurchase()
        {
            this._PurchaseID = -1;
            this.IssueDate = DateTime.MaxValue;
            this.TotalBeforTax = -1;
            this.TaxAmount = -1;
            this.TotalAfterTax = -1;
            this.StoreID = -1;
            this.Type = -1;
            this.PCategoryID = -1;
            this.Discount = null;
           
            _mode = enMode.AddNew;
        }

        private clsPurchase(int PurchaseID, DateTime IssueDate, float TotalBeforTax, float TaxAmount, float TotalAfterTax, int StoreID,int Type,float? Discount,int PCategoryID)
        {
            this._PurchaseID = PurchaseID;
            this.IssueDate = IssueDate;
            this.TotalBeforTax = TotalBeforTax;
            this.TaxAmount = TaxAmount;
            this.TotalAfterTax = TotalAfterTax;
            this.StoreID = StoreID;
            this.Discount = Discount;
            this.Type = Type;
            this.PCategoryID = PCategoryID;
            this.objStoreInfo = clsStore.Findstore(StoreID);

            _mode = enMode.Update;
        }
         public  bool SetValues( DateTime IssueDate, float TotalBeforTax, float TaxAmount, float TotalAfterTax, int StoreID,int Type, int PCategoryID, float? Discount =null )
        {
           
            this.IssueDate = IssueDate;
            this.TotalBeforTax = TotalBeforTax;
            this.TaxAmount = TaxAmount;
            this.TotalAfterTax = TotalAfterTax;
            this.StoreID = StoreID;
            this.Discount = Discount;
            this.Type=Type;
            this.PCategoryID = PCategoryID;

            return true;
        }

        private bool _AddNewPurchases()
        {
            int ID = -1;
            clsPurchaseData.InsertPurchase(ref ID, this.IssueDate, this.TotalBeforTax, this.TaxAmount,this.TotalAfterTax, this.StoreID,this.Type,this.Discount,this.PCategoryID);
            this._PurchaseID = ID;
            return this._PurchaseID != -1;
        }


        private bool _UpdatePurchases()
        {
            return clsPurchaseData.UpdatePurchase(this._PurchaseID, this.IssueDate, this.TotalBeforTax, this.TaxAmount, this.TotalAfterTax, this.StoreID,this.Type, this.Discount, this.PCategoryID);
        }
        public bool SavePurchases()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewPurchases())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePurchases();
            }
            return false;
        }

        public static clsPurchase FindPurchase(int PurchaseID)
        {
            DateTime IssueDate = DateTime.MaxValue;
            float TotalAmountBeforeTax = -1;
            float TaxAmount = -1;
           
            float TotalafterTax = -1;
            float? Discount =null;
            int StoreID = -1;
            int Type = -1;
            int PCategoryID = -1;

            if (clsPurchaseData.FindPurchase(PurchaseID, ref IssueDate, ref TotalAmountBeforeTax,ref TaxAmount,ref TotalafterTax, ref StoreID ,ref Type, ref Discount,ref PCategoryID))
            {

                return new clsPurchase(PurchaseID, IssueDate, TotalAmountBeforeTax, TaxAmount, TotalafterTax, StoreID,Type, Discount, PCategoryID);
            }
            else
            {
                return null;
            }
        }
 
        public static bool DeletePurchase(int PurchaseID)
        {
            return clsPurchaseData.DeletePurchase(PurchaseID);
        }
          public  bool DeletePurchase()
        {
            return clsPurchaseData.DeletePurchase(this._PurchaseID);
        }
        
         public static DataTable GetAllPurchases(int PageNumber, int RowCountPerPage, ref int RowCount)
        {

            return clsPurchaseData.GetAllPurchases(PageNumber,RowCountPerPage,ref RowCount);
        }

        public static DataTable GetAllPurchasesInfoWithPages(int PageNumber, int RowCountPerPage, ref int RowCount)
        {

            return clsPurchaseData.GetAllPurchasesInfoWithPages(PageNumber, RowCountPerPage, ref RowCount);
        }

        public static DataTable GetAllPurchasesInfoWithPagesByStoreName(int PageNumber, int RowCountPerPage, string StoreName,ref int RowCount)
        {

            return clsPurchaseData.GetAllPurchasesInfoWithPagesByStoreName(PageNumber, RowCountPerPage, StoreName, ref RowCount);
        }
          public static DataTable GetAllPurchasesInfoWithPagesByTypeName(int PageNumber, int RowCountPerPage, string TypeName, ref int RowCount)
        {

            return clsPurchaseData.GetAllPurchasesInfoWithPagesByTypeName(PageNumber, RowCountPerPage, TypeName, ref RowCount);
        }
            public static DataTable GetAllPurchasesInfoWithPagesByTotalAfterTax(int PageNumber, int RowCountPerPage, float TotalAfterTax, ref int RowCount)
        {

            return clsPurchaseData.SP_GetAllPurchaseInfoWithPagingByTotalAfterTax(PageNumber, RowCountPerPage, TotalAfterTax, ref RowCount);
        }


        public static DataTable GetAllPurchasesInfoWithPagesByDate(int PageNumber, int RowCountPerPage,DateTime DateForm,DateTime DateTo, ref int RowCount)
        {

            return clsPurchaseData.GetAllPurchasesInfoWithPagesByDate(PageNumber, RowCountPerPage,DateForm,DateTo, ref RowCount);
        }

        public static DataTable GetAllPurchasesInfoWithPagesByDateOfStoreName(int PageNumber, int RowCountPerPage, DateTime DateForm, DateTime DateTo,string StoreName, ref int RowCount)
        {

            return clsPurchaseData.GetAllPurchasesInfoWithPagesByDateOfStoreName(PageNumber, RowCountPerPage, DateForm, DateTo, StoreName, ref RowCount);
        }


          public static DataTable GetAllPurchaseInfoWithPagingByDateofTotalAfterTax(int PageNumber, int RowCountPerPage, DateTime DateForm, DateTime DateTo,float TotalAfterTax, ref int RowCount)
        {

            return clsPurchaseData.GetAllPurchaseInfoWithPagingByDateofTotalAfterTax(PageNumber, RowCountPerPage, DateForm, DateTo, TotalAfterTax, ref RowCount);
        }
          public static DataTable GetAllPurchaseInfoWithPagingByDateofType(int PageNumber, int RowCountPerPage, DateTime DateForm, DateTime DateTo,string TypeName, ref int RowCount)
        {

            return clsPurchaseData.GetAllPurchaseInfoWithPagingByDateofType(PageNumber, RowCountPerPage, DateForm, DateTo, TypeName, ref RowCount);
        }


        public static DataTable GetPurchaseColumns()
        {
            return clsPurchaseData.GetPurchaseColumns();
        }
        public static DataTable GetPurchaseInfo(string ColumnName,string Value)
        {
            return clsPurchaseData.GetPurchasesInfo(ColumnName,Value);
        }
          public static DataTable GetPurchaseInfo(int PurchaseID)
        {
            return clsPurchaseData.GetPurchasesInfo(PurchaseID);
        }

        public static float GetTotalAllPurchases()
        {
            return clsPurchaseData.GetTotalAllPurchases();
        }

        public static float GetTotalAllPurchases(string CategoryName,string DateFrom ,string DateTo)
        {
            return clsPurchaseData.GetTotalPurchasesByCategoryName(CategoryName,DateFrom,DateTo);
        }
          public static float GetTotalAllPurchases(string CategoryName)
        {
            return clsPurchaseData.GetTotalPurchasesByCategoryName(CategoryName);
        }

        public static float GetTotalAllPurchases(string DateFrom ,string DateTo)
        {
            return clsPurchaseData.GetTotalPurchasesByDate(DateFrom,DateTo);
        }






    }

}
