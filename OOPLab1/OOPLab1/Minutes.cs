using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace OOPLab1
{
    class Minutes : IMinutes
    {
        System.Windows.Forms.Timer t1;
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
            t1.Interval = 1000;
            t1.Tick +=  new EventHandler (T1_Tick);
            t1.Enabled = true;
        }

        public void T1_Tick(object sender, EventArgs e)
        {
            if (_minutesValue > 0)
            {
                _minutesValue++;
            }
            else if (_minutesValue == 0)
            {
                t1.Enabled = false;
                _minutesValue++;
            }
        }



    }
}
