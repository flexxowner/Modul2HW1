using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_HW1
{
    class Actions
    {
        Result result = new Result();
        public Result Info()
        {
            LoggerSingleton.Instance.LogMessage("Info", result.ErrorMessage = "Start method:");
            result.GetStatus = true;
            return result; 
        }

        public Result Warning()
        {
            LoggerSingleton.Instance.LogMessage("Warning", result.ErrorMessage = "Skipped logic in method:");
            result.GetStatus = true;
            return result;
        }

        public Result Error()
        {
            var result = new Result();
            result.GetStatus = false;
            return result ;
        }
    }
}
