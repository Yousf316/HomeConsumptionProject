using System;

using System.Windows.Forms;
using HomeConsuption.Global;
using Microsoft.Win32;
using HomeC_Business;
namespace HomeConsuption
{
    internal static  class clsGlobal
    {
        public static clsUser CurrentUser;

        public static readonly float Taxprec =1.15f;

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {

            try
            {
                //this will get the current project directory folder.


                string filePath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";

                string ValueName = "UserName";

                if (Username == null)
                {
                    //  Registry.SetValue(filePath, ValueName, "", RegistryValueKind.String);

                    try
                    {   // Open the registry key in read/write mode with explicit registry view
                        using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                        {
                            using (RegistryKey key = baseKey.OpenSubKey(@"SOFTWARE\DVLD", true))
                            {
                                if (key != null)
                                {
                                    // Delete the specified value
                                    key.DeleteValue(ValueName);


                                }

                            }
                            return false;
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.WriteLine("UnauthorizedAccessException: Run the program with administrative privileges.");
                        clsEventLogs.WriteLog("UnauthorizedAccessException: Run the program with administrative privileges.",
                            System.Diagnostics.EventLogEntryType.Error);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                        clsEventLogs.WriteLog($"An error occurred: {ex.Message}",
                           System.Diagnostics.EventLogEntryType.Error);
                    }
                    return false;
                }
                string dataToSave = Username + "#//#"+Password ;

                // Create a StreamWriter to write to the file
                Registry.SetValue(filePath, ValueName, dataToSave, RegistryValueKind.String);

                return true;
            }
            catch (Exception ex)
            {
               MessageBox.Show ($"An error occurred: {ex.Message}");
                clsEventLogs.WriteLog($"An error occurred: {ex.Message}",
                         System.Diagnostics.EventLogEntryType.Error);
                return false;
            }

        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            //this will get the stored username and password and will return true if found and false if not found.
            try
            {
                string filePath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";


                string ValueName = "UserName";


                
                    // Create a StreamReader to read from the file
                  string FullValue =  Registry.GetValue(filePath, ValueName, null) as string??null;

                if (FullValue != null && FullValue!="")
                {
                    string[] arrValues = FullValue.Split(new string[] { "#//#" }, StringSplitOptions.None);

                    Username = arrValues[0];
                    Password = arrValues[1];
                    return true;
                }
                else
                    return false;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show ($"An error occurred: {ex.Message}");
                clsEventLogs.WriteLog($"An error occurred: {ex.Message}",
                         System.Diagnostics.EventLogEntryType.Error);
                return false;   
            }

        }


    }
}
