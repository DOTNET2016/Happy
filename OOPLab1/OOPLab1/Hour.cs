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
        private int _hoursValue;
        int tempHour;

        public int HoursValue
        {
            get
            {
                return _hoursValue;
            }
            set
            {
                if ((value > 0) && (value < 24))
                {
                    _hoursValue = value;
                }
            }                
          }

        public void Tick()
        {
            /*t2 = new System.Windows.Forms.Timer();
            t2.Interval = 1000;
            t2.Tick += T2_Tick;
            t2.Start();*/
        }

        public int HourCount()
        {
            tempHour = _hoursValue;
            tempHour++;
            if (tempHour > 23)
                _hoursValue = 0;
            HoursValue = tempHour;
            return HoursValue;
        }
    }
}
