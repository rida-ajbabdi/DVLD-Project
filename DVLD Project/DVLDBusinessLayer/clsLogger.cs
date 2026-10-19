using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDBusinessLayer
{
    public class clsLogger
    {
        public static string SourceName { get; } = "DVLD";

        public static void LogExeption(string Message, EventLogEntryType EventType)
        {
            
            try
            {
                if (!EventLog.SourceExists(SourceName))
                {
                    EventLog.CreateEventSource(SourceName, "Application");
                }
                EventLog.WriteEntry(SourceName, Message, EventType);
            }
            catch (Exception ex) {
               EventLog.WriteEntry(SourceName, $"Exeption in LogExeption Methode : \n {FormatErrorMessage(ex)}", EventLogEntryType.Error);
            }
        }
        public static void LogExeption(Exception ex, EventLogEntryType EventType)
        {
            LogExeption(FormatErrorMessage(ex), EventType);
        }
        private static string FormatErrorMessage(Exception ex)
        {

            // this is an example
            /*
                --- Exception Log ---
                Timestamp: 10/31/2024 2:45:32 PM
                Message: File not found.
                Inner Exception: File path was null.
                Stack Trace: at MyApp.Program.Main() in C:\Project\MyApp\Program.cs:line 24
                Source: MyApp
                -----------------------
             */

            string message =

                 $"--- Exception Log ---\n" +
                 $"Timestamp: {DateTime.Now}\n" +
                 $"Message: {ex.Message}\n" +
                 $"Inner Exception: {(ex.InnerException?.Message??"N/A")}\n" +
                 $"Stack Trace: {ex.StackTrace}\n" +
                 $"Source: {ex.Source}\n" +
                 $"-----------------------";

            return message;
        }
    }
}
