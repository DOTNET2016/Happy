using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab1
{
    public class Minutes : IMinutes
    {
        //instance of Hour Class
        Hour h2 = new Hour();
        //veriables
        private int _minutesValue;
        int tempMin;
        //property
        public int MinutesValue
        {
            get
            {
                return _minutesValue;
            }
            set
            {
                if ((value >= 0) && (value <= 60))
                {
                    _minutesValue = value;
                }
            }
        }
        //method that takes the clock value of minute and increments it by one. Then returns the new value of Minute.
        public int MinuteCount()
        {
            tempMin = _minutesValue;
            tempMin++;
  
            MinutesValue = tempMin;
            if (tempMin == 60)
            {
                _minutesValue = 0;
                h2.HourCount();
            }
            return MinutesValue;
        }
    }
}
