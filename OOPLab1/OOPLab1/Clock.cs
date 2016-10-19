using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace OOPLab1
{
    class Clock : IClock
    {
        Timer t;
        int userInputHours = 0;

        public void GetHours(int userHours)
        {
            
        }

        public void GetMinutes()
        {
            throw new NotImplementedException();
        }

        public void SetClock()
        {
            throw new NotImplementedException();
        }

        public void StopClock()
        {
            throw new NotImplementedException();
        }
    }
}
