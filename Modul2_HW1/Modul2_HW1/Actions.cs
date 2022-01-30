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
        public bool Info()
        {
            LoggerSingleton.Instance.LogMessage("Info", result.Start);
            return result.StatusTrue; 
        }

        public bool Warning()
        {
            LoggerSingleton.Instance.LogMessage("Warning", result.Warning);
            return result.StatusTrue;
        }

        public bool Error()
        {
            LoggerSingleton.Instance.LogMessage("Error", $"Action failed by a reason: {result.Error}");
            return result.StatusFalse ;
        }
    }
}
