using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1
{
    interface IAlarm
    {
        int AlarmMins { get; set; }      
        int AlarmHours { get; set; }      
        int Alarm2Mins { get; set; }     
        int Alarm2Hours { get; set; }

        bool Alarm1Count();
        bool Alarm2Count();
    }
}
