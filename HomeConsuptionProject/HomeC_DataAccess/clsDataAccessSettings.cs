using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace HomeC_DataAccess
{
    static public  class clsDataAccessSettings
    {
        static public string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
    }
}
