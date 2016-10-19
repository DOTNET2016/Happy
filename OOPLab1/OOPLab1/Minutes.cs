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

            t1 = new System.Windows.Forms.Timer();
            t1.Interval = 1000;
            //t1.Enabled = true;
            t1.Tick += T1_Tick;
        }

        public void T1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
