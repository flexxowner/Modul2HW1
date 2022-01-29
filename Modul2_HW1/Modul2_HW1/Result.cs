using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_HW1
{
    class Result
    {
        bool status1 = true;
        bool status2 = false;
        string errorMessage = "I broke a logic";

        public Result()
        {
        }

        public bool GetStatusTrue()
        {
            return status1;
        }

        public bool GetStatusFalse()
        {
            return status2;
        }

        public string ErrorMessage()
        {
            return errorMessage;
        }
    }
}
