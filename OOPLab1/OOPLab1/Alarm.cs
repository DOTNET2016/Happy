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

        public int tempMin;
        public int tempHrs;
  
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


        public bool AlarmCount(/*int setArlMin, int setArlHrs*/)
        {
            //_alarmHours = setArlHrs;//take set alarm from form1 
            //_alarmMins = setArlMin;

            if ((_alarmMins == tempMin) && (_alarmHours == tempHrs))//compare
            {
                return true;
            }
            else
                return false;          
        }

        //public static bool operator ==(Clock mainClock, Alarm alarmTime)
        //{
        //    if ((mainClock.SetMins == alarmTime.AlarmMins) && (mainClock.SetHour == alarmTime.AlarmHours))
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public static bool operator !=(Clock mainClock, Alarm alarmTime)
        //{
        //    if ((mainClock.SetMins == alarmTime.AlarmMins) && (mainClock.SetHour == alarmTime.AlarmHours))
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //public bool CheckTime()
        //{

        //    if ((c2.SetMins == _alarmMins) && (c2.SetHour == _alarmHours))
        //        return true;
        //    else
        //        return false;
        //        //If the Alarm time matches the clock time do something......



        //}

        public void SetAlarm()
        {
            
        }
    }
}
