using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_HW1
{
   public sealed class LoggerSingleton
    {
        private static readonly LoggerSingleton instance = new LoggerSingleton();
        StreamWriter file = new StreamWriter("C:\\Users\\romav\\source\\repos\\Modul2HW1\\log.txt");

        Starter starter = new Starter();

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
            file.Write($"{DateTime.Now}: {type}: {message}");
            file.Write("\n");
        }



    }
}
