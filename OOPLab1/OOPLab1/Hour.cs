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
        //property
        public int HoursValue
        {
            get
            {
                return _hoursValue;
            }
            set
            {
                if ((value >= 0) && (value <= 24))
                {
                    _hoursValue = value;
                }
            }                
          }
        //method that takes the clock value of hour and increments it by one. Then returns the new value of Hour.
        public int HourCount()
        {
            tempHour = _hoursValue;
            tempHour++;
            HoursValue = tempHour;

            if (tempHour == 24)
                _hoursValue = 0;

            return HoursValue;
        }
        //method that stores the new value of hour.
        public int HourValue()
        {
            int hourValue = HoursValue;
            return hourValue;
        }
    }
}
