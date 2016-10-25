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
        Clock c2 = new Clock();
        private int _alarmMins;
        private int _alarmHours;

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

        public Alarm()
        {
            c2.SetMins = _alarmMins;
            c2.SetHour = _alarmHours;
        }

        public void CheckAlarm()
        {
            
        }

        public void CheckTime()
        {
            
            if ((c2.SetMins == _alarmMins) && (c2.SetHour == _alarmHours))
            {
                //If the Alarm time matches the clock time do something......
            }
            
        }

        public void SetAlarm()
        {
            
        }
    }
}
