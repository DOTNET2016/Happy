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
        private int _alarmTime;

        private Timer alrmTimer;
  
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

        public void AlarmTick()
        {
            alrmTimer = new Timer();
            alrmTimer.Elapsed += AlrmT_Elapsed;
            alrmTimer.Interval = 1000;
            alrmTimer.Start();
        }

        private void AlrmT_Elapsed(object sender, ElapsedEventArgs e)
        {
            
        }

        public bool AlarmCount()
        {
            
            if (_alarmMins < 10)
            {
                return true;
            }
            else
                return false;

        }

        //public static bool operator == (Clock mainClock, Alarm alarmTime)
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
