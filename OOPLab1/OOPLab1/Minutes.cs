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
        private int _minutesValue;
        int tempMin = 1;
        int addHour;

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
                addHour++;
            } 
            MinutesValue = tempMin;
            return MinutesValue;
        }
    }
}
