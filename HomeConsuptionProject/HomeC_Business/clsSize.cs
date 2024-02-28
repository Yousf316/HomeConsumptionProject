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
        public clsSize()
        {
            this.SizeID = -1;
            this.SizeName = "";
            _mode = enMode.AddNew;
        }
        private clsSize(int SizeID, string SizeName)
        {
            this.SizeID = SizeID;
            this.SizeName = SizeName;
            _mode = enMode.Update;
        }

        public void SetParameters(string SizeName)
        {
            this.SizeName = SizeName;
        }

        private bool _AddNewSizes()
        {
            int ID = -1;
            clsSizesData.InsertSize(ref ID, this.SizeName);
            this.SizeID = ID;
            return this.SizeID != -1;
        }
        private bool _UpdateSizes()
        {
            return clsSizesData.UpdateSize(this.SizeID, this.SizeName);
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

            if (clsSizesData.FindSize(SizeID, ref SizeName))
            {

                return new clsSize(SizeID, SizeName);
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
