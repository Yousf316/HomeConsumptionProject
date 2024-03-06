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
  public class clsPurchase_sub
{
  public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

public int PurchaseID  { get; set; }
public int P_subID { get; set; }
public int ItemID  { get; set; }
public string ItemName  { get; set; }
public string Description  { get; set; }
public float ItemPrice  { get; set; }
public float Quantity  { get; set; }
public int? Size  { get; set; }
public float TotalAmount  { get; set; }
public clsPurchase_sub()
{
this.PurchaseID = -1;
this.P_subID = -1;
this.ItemID = -1;
this.ItemName = "";
this.Description = "";
this.ItemPrice = -1;
this.Quantity = -1;
this.TotalAmount = -1;
this.Size = null;
_mode = enMode.AddNew;
 }
private clsPurchase_sub(int PurchaseID,int P_subID, int ItemID,string ItemName,string Description,float ItemPrice,float Quantity,float TotalAmount,int? Size)
{
this.PurchaseID = PurchaseID;
this.ItemID = ItemID;
this.ItemName = ItemName;
this.Description = Description;
this.ItemPrice = ItemPrice;
this.Quantity = Quantity;
this.TotalAmount = TotalAmount;
this.P_subID = P_subID;
this.Size = Size;
_mode = enMode.Update;
   }

        public void SetValues(int PurchaseID, int P_subID, int ItemID, string ItemName, string Description, float ItemPrice, float Quantity, float TotalAmount, int? Size)
        {
            this.PurchaseID = PurchaseID;
            this.ItemID = ItemID;
            this.ItemName = ItemName;
            this.Description = Description;
            this.ItemPrice = ItemPrice;
            this.Quantity = Quantity;
            this.TotalAmount = TotalAmount;
            this.P_subID = P_subID;
            this.Size = Size;
            
        }


        public static clsPurchase_sub FindPurchase_sub(int PurchaseID, int P_subID)
        {
           
            int ItemID = -1;
            string ItemName = "";
            string Description = "";
            float ItemPrice = -1;
            float Quantity = -1;
            int? Size = null;
            float TotalAmount = -1;

            if (clsPurchase_subData.FindPurchase_sub(PurchaseID,  P_subID, ref ItemID, ref ItemName, ref Description, ref ItemPrice, ref Quantity, ref TotalAmount ,ref Size))
            {

                return new clsPurchase_sub(PurchaseID, P_subID, ItemID, ItemName, Description, ItemPrice, Quantity, TotalAmount,Size);
            }
            else
            {
                return null;
            }
        }
      

        private bool _AddNewPurchases_sub()
{
  return clsPurchase_subData.InsertPurchase_sub( this.PurchaseID, this.P_subID,this.ItemID, this.ItemName, this.Description, this.ItemPrice, this.Quantity, this.TotalAmount,this.Size);
 
 
}
private bool _UpdatePurchases_sub()
{
return clsPurchase_subData.UpdatePurchase_sub(  this.PurchaseID,this.P_subID, this.ItemID, this.ItemName, this.Description, this.ItemPrice, this.Quantity, this.TotalAmount, this.Size);
 }
public bool SavePurchases_sub()
{

switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewPurchases_sub())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePurchases_sub();
}
         return false;
   }


  public static DataTable GetPurchases_subColumns()
  {
      return clsPurchase_subData.GetAllPurchases_subCoulmns();
  }

public static DataTable GetPurchases_sub(int PurchaseID)
  {
      return clsPurchase_subData.GetAllPurchases_subByPurchaseID(PurchaseID);
  }

public static bool DeletePurchase_sub(int PurchaseID)
  {
      return clsPurchase_subData.DeletePurchase_sub(PurchaseID);
  }



}



}
