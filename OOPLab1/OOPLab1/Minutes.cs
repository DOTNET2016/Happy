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
        public int _tempMin;

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

        public Minutes (Form1 form)
        {
            _form = form;
        }

        public Minutes()
        {
        }

        public void TickMinutes(Form1 o)
        {
            t1 = new Timer();
            t1.Interval = 1000;
            t1.Enabled = true;
            t1.Tick += T1_Tick;
            o.UpdateLabel();
        }

        public void T1_Tick(object sender, EventArgs e)
        {
            _minutesValue++;
            MinuteCount();          
        }
        public int MinuteCount()
        {
            _tempMin = _minutesValue;
            return _tempMin;
        }
    }
}
