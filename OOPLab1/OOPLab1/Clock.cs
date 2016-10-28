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
        //intances of Minute Class and Hour Class.
        Minutes m1 = new Minutes();
        Hour h1 = new Hour();
        //variables 
        int _setMins;
        int _setHrs;
        //properties
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
        //method that checks the value of the minute from the minute class and also controls when the HourCount method should be called.
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
        //method that checks the valkue of hour and stores it in a new veriable before returning that variable
        public int CheckHour()
        {
            int checkedHour = h1.HourValue();
            return checkedHour;
        }
        //set the values of hrs and min to our properties so they can be used in form1.
        public void TimeReset()
        {
            m1.MinutesValue = SetMins;
            h1.HoursValue = SetHour;
        }
    }
}
