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

        public int HourCount()
        {
            tempHour = _hoursValue;

            if (tempHour > 23)
                _hoursValue = 0;
            tempHour++;
            HoursValue = tempHour;
            HourReturn();
            return HoursValue;
        }

        public int HourReturn()
        {
            var HourReturn = HoursValue;
            return HourReturn;
        }
        public void HourAdd()
        {
            HourCount();
        }
    }
}
