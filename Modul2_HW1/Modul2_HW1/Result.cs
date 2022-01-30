using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_HW1
{
    class Result
    {
        bool status;
        string errorMessage = "I broke a logic";
        string startMessage = "Start method";
        string warningMessage = "Skipped logic in method";

        public Result()
        {

        }

        public bool StatusTrue
        {
            get { return status; }
            set { status = true; }
        }

        public bool StatusFalse
        {
            get { return status; }
            set { status = false; }
        }

        public string Error
        {
            get { return errorMessage; }
        }

        public string Warning
        {
            get { return warningMessage; }
        }

        public string Start
        {
            get { return startMessage; }
        }
    }
}
