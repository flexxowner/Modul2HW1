using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_HW1
{
    class Result
    {
        bool Status;
        string errorMessage;
        string startMessage;
        string warningMessage;
        public Result(bool Status)
        {
            this.Status = Status;
        }
        public Result(string errorMessage = "I broke a logic", string startMessage = "Start method", string warningMessage = "Skipped logic in method")
        {
            this.errorMessage = errorMessage;
            this.startMessage = startMessage;
            this.warningMessage = warningMessage;
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
        
        public bool GetStatus
        {
            get { return Status; }
            set { Status = value; }
        }
    }
}
