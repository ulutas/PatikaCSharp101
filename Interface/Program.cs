using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            SmsLogger smsLogger = new SmsLogger();
            smsLogger.WriteLog();

            //You can also declare object like this.
            DataBaseLogger databaseLogger = new DataBaseLogger();
            databaseLogger.WriteLog();

            //We are using Logmanager instance.
            LogManager manager = new LogManager(new FileLogger());
            manager.WriteLog();
        }
    }
}
