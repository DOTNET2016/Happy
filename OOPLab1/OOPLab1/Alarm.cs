using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace OOPLab1
{
    class Alarm : IAlarm
    {
        private int _alarmMins;
        private int _alarmHours;
        private int _alarm2Mins;
        private int _alarm2Hours;

        public int tempMin1;
        public int tempHrs1;
        public int tempMin2;
        public int tempHrs2;
  
        public int AlarmMins
        {
            get
            {
                return _alarmMins;
            }

            set
            {
                _alarmMins = value;
            }
        }

        public int AlarmHours
        {
            get
            {
                return _alarmHours;
            }

            set
            {
                _alarmHours = value;
            }
        }
        public int Alarm2Mins
        {
            get
            {
                return _alarm2Mins;
            }

            set
            {
                _alarm2Mins = value;
            }
        }

        public int Alarm2Hours
        {
            get
            {
                return _alarm2Hours;
            }

            set
            {
                _alarm2Hours = value;
            }
        }

        public bool Alarm1Count()
        {
            if ((_alarmMins == tempMin1) && (_alarmHours == tempHrs1))//compare
            {
                return true;
            }
            
                return false;          
        }
        public bool Alarm2Count()
        {
            if ((_alarm2Mins == tempMin2) && (_alarm2Hours == tempHrs2))//compare
            {
                return true;
            }

            return false;
        }
    }
}
