using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab1
{
    class Clock : IClock
    {
        Minutes m2 =  new Minutes();
        Hour h2 = new Hour();
        
        int count;
        int tempMin;

        int _setMins;
        int _setHrs;

        public int SetMins
        {
            get
            {
                return _setMins;
            }
            set
            {
                _setMins = value;
            }
        }

        //public int CheckTime(int _setMins, int _setHrs)
        //{
        //    if (_setMins > 59)
        //    {

        //        h2.HourCount();
        //    }
        //    return _setHrs;
        //}

       
        
        public int TimeValue()
        {
            return tempMin;
        }

        public void StopClock()
        {
            throw new NotImplementedException();
        }
    }
}
