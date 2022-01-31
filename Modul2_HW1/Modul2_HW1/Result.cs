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

        public Result()
        {
        }

        public Result(string errorMessage, bool Status)
        {
            this.errorMessage = errorMessage;
            this.Status = Status;
        }

        public string ErrorMessage
        {
            get { return errorMessage; }
            set { errorMessage = value; }   
        }
        
        public bool GetStatus
        {
            get { return Status; }
            set { Status = value; }
        }
    }
}
