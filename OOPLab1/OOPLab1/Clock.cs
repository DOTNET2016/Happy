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

        int count;
        int tempMin;

        int _setMins;
        int _setHrs;

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

        public int CheckMin(/*int _setMins, int _setHrs*/)
        {
            int setMinute = m1.MinuteCount();
            if (setMinute == 0)
            {
                h1.HourCount();
                return setMinute;
            }
            return setMinute;
        }

        public int CheckHour(/*int _setMins, int _setHrs*/)
        {
            int hour = h1.HourValue();
            return hour;
        }

        public void TimeValue()
        {
            m1.MinutesValue = _setMins;
            h1.HoursValue = _setHrs;
        }

        public void StopClock()
        {
            throw new NotImplementedException();
        }

        public int ClockState()//thinking about using for the alarm....will propably delete but leave it for now
        {
            int stateOfClock = _setMins + _setHrs;

            return stateOfClock;
        }
    }
}
