using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1
{
    interface IClock
    {
        int SetMins { get; set; }
        int SetHour { get; set; }

        int CheckMin();
        int CheckHour();
        void TimeReset();

    }
}
