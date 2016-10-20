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
        private int _minutesValue;

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
            //t1.Enabled = true;
            t1.Tick += T1_Tick;
        }

        public void T1_Tick(object sender, EventArgs e)
        {
            if (_minutesValue >= 0)
                t1.Enabled = false;
            else
                _minutesValue++;
                MinuteCount();    
        }
        private void MinuteCount()
        {

        }
    }
}
