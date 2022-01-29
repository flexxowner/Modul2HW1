using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_HW1
{
    class Actions:Result
    {
        public bool Info()
        {
            LoggerSingleton.Instance.LogMessage("Info", "Start method");
            return GetStatusTrue();
        }

        public bool Warning()
        {
            LoggerSingleton.Instance.LogMessage("Warning", "Skipped logic in method");
            return GetStatusTrue();
        }

        public bool Error()
        {
            return GetStatusFalse();
        }
    }
}
