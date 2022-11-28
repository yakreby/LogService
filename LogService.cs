using StokTakip.Reports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Services
{
    public class LogService
    {
        private string GetDate() { return DateTime.Now.ToString(); }
        
        //This method can be use for C:/Users/ComputerName path
        public string GetMachineName()
        {
            string machineName = Environment.MachineName;
            return machineName;
        }
        
        public string GetAppFolder() 
        {
            //string machineName = GetMachineName();
            string appFolderPath = Path.Combine($"C:\\Program Files\\AppName\\");
            return appFolderPath;
        }
        
        //Returning Specified App's path
        public string GetAppPath(string specifiedFile) 
        { 
            string appFolderPath = GetAppFolder();  
            return appFolderPath + @"\Logs\" + specifiedFile;
        }
        
        //Controlling specified File exists or not
        private bool Exists(string fileName)
        {
            string combinedFileName = Path.Combine(GetAppFolder() + $@"Logs\{fileName}");
            if (File.Exists(combinedFileName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void Logger(string LogPath, string Message)
        {
            using (StreamWriter sw = System.IO.File.AppendText(LogPath))
            {
                sw.WriteLine(Convert.ToString(Message));
            }
        }

        //Dynamically Controlling file existence and create if not exists
        public void ControlFile(string fileName, string name)
        {
            if (Exists(fileName))
            {}
            else
            {
                using (FileStream fs = System.IO.File.Create((GetAppFolder() + $@"Logs\{fileName}")))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes($"{name} dosyası {DateTime.Now.ToString()} tarihinde oluşturuldu\n");
                    fs.Write(info, 0, info.Length);
                }
                ApplicationLogger($"{name} dosyası {DateTime.Now.ToString()} tarihinde oluşturuldu");
            }
        }

        public void ApplicationLogger(string Message)
        {
            if (Exists("ApplicationLogs.txt"))
            {
                string messageToWrite = "--" + GetDate() + "  #######  " + Message;
                Logger(GetAppFolder() + @"Logs\ApplicationLogs.txt", messageToWrite);
            }
            else
            {
                using (FileStream fs = System.IO.File.Create((GetAppFolder() + @"Logs\ApplicationLogs.txt")))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes($"Uygulama Kayıtları dosyası {DateTime.Now.ToString()} tarihinde oluşturuldu\n");
                    fs.Write(info, 0, info.Length);
                }
                string messageToWrite = "--" + GetDate() + "  #######  " + Message;
                Logger(GetAppFolder() + @"Logs\ApplicationLogs.txt", messageToWrite);
            }
        }

        public void StockLogger(string Message)
        {
            if (Exists("StockLogs.txt"))
            {
                string messageToWrite = "--" + GetDate() + "  #######  " + Message;
                Logger(GetAppFolder() + @"Logs\StockLogs.txt", messageToWrite);
            }
            else
            {
                using (FileStream fs = System.IO.File.Create((GetAppFolder() + @"Logs\StockLogs.txt")))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes($"Stok Kayıtları dosyası {DateTime.Now.ToString()} tarihinde oluşturuldu\n");
                    fs.Write(info, 0, info.Length);
                }
                string messageToWrite = "--" + GetDate() + "  #######  " + Message;
                Logger(GetAppFolder() + @"Logs\StockLogs.txt", messageToWrite);
                ApplicationLogger($"Stok Kayıtları dosyası {DateTime.Now.ToString()} tarihinde oluşturuldu");
            }
        }
        public void CustomerLogger(string Message)
        {
            if (Exists("CustomerLogs.txt"))
            {
                string messageToWrite = "--" + GetDate() + "  #######  " + Message;
                Logger(GetAppFolder() + @"Logs\CustomerLogs.txt", messageToWrite);
            }
            else
            {
                using (FileStream fs = System.IO.File.Create((GetAppFolder() + @"Logs\CustomerLogs.txt")))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes($"Müşteri Kayıtları dosyası {DateTime.Now.ToString()} tarihinde oluşturuldu\n");
                    fs.Write(info, 0, info.Length);
                }
                string messageToWrite = "--" + GetDate() + "  #######  " + Message;
                Logger(GetAppFolder() + @"Logs\CustomerLogs.txt", messageToWrite);
                ApplicationLogger("Müşteri Kayıtları dosyası {DateTime.Now.ToString()} tarihinde oluşturuldu");
            }
        }
        public void SaleLogger(string Message)
        {
            if (Exists("SaleLogs.txt"))
            {
                string messageToWrite = "--" + GetDate() + "  #######  " + Message;
                Logger(GetAppFolder() + @"Logs\SaleLogs.txt", messageToWrite);
            }
            else
            {
                using (FileStream fs = System.IO.File.Create((GetAppFolder() + @"Logs\SaleLogs.txt")))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes($"Satış Kayıtları dosyası {DateTime.Now.ToString()} tarihinde oluşturuldu\n");
                    fs.Write(info, 0, info.Length);
                }
                string messageToWrite = "--" + GetDate() + "  #######  " + Message;
                Logger(GetAppFolder() + @"Logs\SaleLogs.txt", messageToWrite);
                ApplicationLogger("Satış Kayıtları dosyası {DateTime.Now.ToString()} tarihinde oluşturuldu");
            }
        }
    }
}
