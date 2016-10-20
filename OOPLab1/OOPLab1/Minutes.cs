using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab1
{
    class Minutes : IMinutes
    {
        Timer t1;
        int _minutesValue;
        int _addHour;

        public int MinutesValue
        {
            get
            {
                return _minutesValue;
            }

            set
            {
                _minutesValue = value;
            }
         }

        public void TickMinutes()
        {
            t1 = new Timer();
            t1.Interval = 1000;
            t1.Enabled = true;
            t1.Tick += T1_Tick;
        }

        public void T1_Tick(object sender, EventArgs e)
        {

            if (_minutesValue < 59)
                _minutesValue++;
            else
                _addHour++; //send tick to hour
            t1.Enabled = true;
            //MinuteCount();    
        }
        public void MinuteCount()
        {
            TickMinutes();
        }
    }
}
