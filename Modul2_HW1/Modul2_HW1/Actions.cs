using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_HW1
{
    class Actions
    {
        public Result Info()
        {
            var result1 = new Result();
            LoggerSingleton.Instance.LogMessage("Info", result1.Start);
            result1.GetStatus = true;
            return result1; 
        }

        public Result Warning()
        {
            var result2 = new Result();
            LoggerSingleton.Instance.LogMessage("Warning", result2.Warning);
            result2.GetStatus = true;
            return result2;
        }

        public Result Error()
        {
            var result3 = new Result();
            LoggerSingleton.Instance.LogMessage("Error", $"Action failed by a reason: {result3.Error}");
            result3.GetStatus = false;
            return result3 ;
        }
    }
}
