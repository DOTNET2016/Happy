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

        public int CheckMin()
        {
            int setMinute = m1.MinuteCount();
            if (setMinute == 0)
            {
                h1.HourCount();
                return setMinute;
            }
            return setMinute;
        }

        public int CheckHour()
        {
            int hour = h1.HourValue();
            return hour;
        }

        public void TimeValue()
        {
            m1.MinutesValue = _setMins;
            h1.HoursValue = _setHrs;
        }
    }
}
