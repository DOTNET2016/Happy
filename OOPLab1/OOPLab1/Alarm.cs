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
        private int _alarmMins2;
        private int _alarmHours2;
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
        public int AlarmMins2
        {
            get
            {
                return _alarmMins2;
            }

            set
            {
                _alarmMins2 = value;
            }
        }

        public int AlarmHours2
        {
            get
            {
                return _alarmHours2;
            }

            set
            {
                _alarmHours2 = value;
            }
        }

        public bool Alarm1()
        {
            if (_alarmHours == c2.CheckHour() && _alarmMins == c2.CheckMin())
                return true;
            return false;
        }
        public bool Alarm2()
        {
            if (_alarmHours2 == c2.CheckHour() && _alarmMins2 == c2.CheckMin())
                return true;
            return false;
        }

        private void AlrmT_Elapsed(object sender, ElapsedEventArgs e)
        {
            
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
