using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab1
{
    class Hour : IHours
    {
        System.Windows.Forms.Timer t2;
        private int _hourValue;
        public int HoursValue
        {
            get
            {
                return _hourValue;
            }
            set
            {
                if ((value > 0) && (value < 24))
                {
                    _hourValue = value;
                }
            }                
          }

        public void Tick()
        {
            t2 = new System.Windows.Forms.Timer();
            t2.Interval = 1000;
            t2.Tick += T2_Tick;
            t2.Start();
        }

        private void T2_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
