using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab1
{
    class Clock : IClock
    {
        Minutes m1 = new Minutes();
        Hour h1 = new Hour();

        int _setMins;
        int _setHrs;
        int _currentClockTime;

        public int SetMins
        {
            get
            {
                return _setMins;
            }
            set
            {
                _setMins = value;
            }
        }
        public int SetHour
        {
            get
            {
                return _setHrs;
            }
            set
            {
                _setHrs = value;
            }
        }

        public int CurrentClockTime
        {
            get
            {
                return _currentClockTime;
            }

            set
            {
                _currentClockTime = value;
            }
        }

        public int CheckMin()
        {
            int checkedMinute = m1.MinuteCount();
            if (checkedMinute == 0)
            {
                h1.HourCount();
                return checkedMinute;
            }
            return checkedMinute;
        }

        public int CheckHour()
        {
            int checkedHour = h1.HourValue();
            return checkedHour;
        }

        public void TimeReset()
        {
            m1.MinutesValue = SetMins;
            h1.HoursValue = SetHour;
        }

        //public int ClockTime()
        //{
        //    CurrentClockTime = _setHrs + _setMins;
        //    return CurrentClockTime;
        //}
    }
}
