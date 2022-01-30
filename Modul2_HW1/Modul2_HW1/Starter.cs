 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_HW1
{
    class Starter
    {
        Actions[] actionsArray = new Actions[3];
        Actions actions = new Actions();
        Random random = new Random();
        public void Run()
        {
            for (int i = 0; i <= 100; i++)
            {
                int mIndex = random.Next(actionsArray.Length);
                Console.WriteLine("\n");
                if (mIndex == 0)
                {
                    actions.Info();
                }
                else if(mIndex == 1)
                {
                    actions.Warning();
                }
                else if (mIndex == 2)
                {
                    actions.Error();
                }

        }

        }

    }
}
