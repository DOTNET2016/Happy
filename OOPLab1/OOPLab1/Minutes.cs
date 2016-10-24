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
        private Form1 _form;
        Timer t1;
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

        public Minutes()
        {
        }

        public void TickMinutes()
        {
            t1 = new Timer();
            t1.Enabled = true;
            t1.Interval = 1000;
            t1.Tick += T1_Tick;
        }

        public void T1_Tick(object sender, EventArgs e)
        {
            tempMin = MinutesValue;
            tempMin++;
            if (tempMin > 59)
                _minutesValue = 0;
            //MinuteCount();          
        }
        public int MinuteCount()
        {
            MinutesValue = tempMin;
            //UPDATE LABEL HERE
            //if (_form == null)
            //{
            //    return -1;
            //}
            //else
            //    _form.UpdateLabel();//null reference exception here if Null not checked like above!!!
            return MinutesValue;
        }
    }
}
