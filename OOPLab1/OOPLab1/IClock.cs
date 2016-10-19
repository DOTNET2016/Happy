using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1
{
    interface IClock
    {
        void GetHours(int userHours);
        void GetMinutes();
        void SetClock();
        void StopClock();

    }
}
