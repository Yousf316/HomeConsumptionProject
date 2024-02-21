using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HomeConsuption.Global
{
   static public class clsEventLogs
    {

       private static string _SourceName = "DVLDApp";

       public enum enModeEventLogType { Informaiton=1,Warning,Error}


        static public void IsSourceNameExists()
        {
            if(!EventLog.SourceExists(_SourceName))
            {
                EventLog.CreateEventSource(_SourceName,"Application");
            }
        }

        static public void WriteLog(string Message, EventLogEntryType ModeEventLogType)
        {
            EventLog.WriteEntry(_SourceName, Message, ModeEventLogType);
        }











        
    }
}
