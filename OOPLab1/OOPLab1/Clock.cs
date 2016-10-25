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
        Minutes m2 =  new Minutes();
        Hour h2 = new Hour();
        
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

        //public void CheckTime(int _setMins, int _setHrs)
        //{
        //    int setMinute = m1.MinuteCount();
        //    if (setMinute <= 60)
        //        minuteLabel.Text = setMinute.ToString("00");
        //    if (setMinute == 0)
        //    {
        //        int setHour = setHours;
        //        h1.HoursValue = setHour;
        //        setHour = h1.HourCount();
        //        HourLabel.Text = setHour.ToString("00");

        //        //if (_setMins > 59)
        //        //{

        //        //    h2.HourCount();
        //        //}
        //        //return _setHrs;
        //    }



        public int TimeValue()
        {
            return tempMin;
        }

        public void StopClock()
        {
            throw new NotImplementedException();
        }
    }
}
