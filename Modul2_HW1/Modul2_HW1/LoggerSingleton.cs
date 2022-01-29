using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_HW1
{
   public sealed class LoggerSingleton
    {
        private static readonly LoggerSingleton instance = new LoggerSingleton();

        static LoggerSingleton()
        {
        }

        private LoggerSingleton()
        {
        }

 

        public static LoggerSingleton Instance
        {
            get
            {
                return instance;
            }
        }

        public void LogMessage(string type,string message)
        {
            Console.WriteLine($"{DateTime.Now}: {type}: {message}");
        }
       

    }
}
