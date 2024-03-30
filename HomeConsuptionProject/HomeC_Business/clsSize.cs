using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeC_DataAccess;

namespace HomeC_Business
{
    public class clsSize
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _mode = enMode.AddNew;

       public int SizeID { get; set; }
       public string SizeName { get; set; }
        public int? CreatedByUserID { get; set; }
        public int? UpdatedByUserID { get; set; }

        public clsSize()
        {
            this.SizeID = -1;
            this.SizeName = "";
            _mode = enMode.AddNew;
        }
        private clsSize(int SizeID, string SizeName, int? CreatedByUserID, int? UpdatedByUserID)
        {
            this.SizeID = SizeID;
            this.SizeName = SizeName;
            this.CreatedByUserID = CreatedByUserID;
            this.UpdatedByUserID = UpdatedByUserID;
            _mode = enMode.Update;
        }

        public void SetParameters(string SizeName,int UserID)
        {
            this.SizeName = SizeName;
            if(_mode == enMode.AddNew)
                this.CreatedByUserID = UserID;
            else
                this.UpdatedByUserID = UserID;
        }

        private bool _AddNewSizes()
        {
            int ID = -1;
            clsSizesData.InsertSize(ref ID, this.SizeName,this.CreatedByUserID,this.UpdatedByUserID);
            this.SizeID = ID;
            return this.SizeID != -1;
        }
        private bool _UpdateSizes()
        {
            return clsSizesData.UpdateSize(this.SizeID, this.SizeName, this.CreatedByUserID, this.UpdatedByUserID);
        }
        public bool SaveSizes()
        {

            switch (_mode)
            {
                case enMode.AddNew:
                    if (_AddNewSizes())
                    {

                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateSizes();
            }
            return false;
        }



        public static clsSize FindSize(int SizeID)
        {
            string SizeName = "";
            int? CreatedByUserID = null;
            int? UpdatedByUserID = null;

            if (clsSizesData.FindSize(SizeID, ref SizeName,ref CreatedByUserID,ref UpdatedByUserID))
            {

                return new clsSize(SizeID, SizeName,CreatedByUserID,UpdatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllSizes()
        {
            return clsSizesData.GetAllSizes();
        }

        public static DataTable GetAllSizesInfoWithPages(int PageNumber, int RowCountPerPage, ref int RowCount)
        {
            return clsSizesData.GetAllSizesInfoWithPages(PageNumber, RowCountPerPage, ref RowCount);
        }

    }

}
