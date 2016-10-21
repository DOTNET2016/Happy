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
        Timer t1;
        private int _minutesValue;
        //Clock c1 = new Clock(); 
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


        public void TickMinutes()
        {
            t1 = new Timer();
            t1.Interval = 1000;
            t1.Enabled = true;
            t1.Tick += T1_Tick;
        }

        public void T1_Tick(object sender, EventArgs e)
        {
            MinutesValue = tempMin;       
            tempMin++;
            //Call the update method from from1..........
            MinuteCount();
           
        }
        public int MinuteCount()
        {
            tempMin = MinutesValue;           
            return tempMin;

        }
    }
}
