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
        Hour h1 = new Hour();
        private int _minutesValue;
        int tempMin;

        public int MinutesValue
        {
            get
            {
                return _minutesValue;
            }
            set
            {
                if ((value > 0) && (value < 60))
                {
                    _minutesValue = value;
                }
            }
        }

        public int MinuteCount()
        {
            tempMin = _minutesValue;
            tempMin++;
            if (tempMin > 59)
            {
                _minutesValue = 0;
                h1.HourAdd();
            } 
            MinutesValue = tempMin;
            return MinutesValue;
        }
    }
}
