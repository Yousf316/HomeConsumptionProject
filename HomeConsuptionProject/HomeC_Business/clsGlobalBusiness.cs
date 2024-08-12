using HomeC_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeC_Business
{
    public class clsGlobalBusiness
    {
        public static void SetConnectionString(string Name)
        {
            clsDataAccessSettings.SetConnectionString(Name);
        }
    }
}
