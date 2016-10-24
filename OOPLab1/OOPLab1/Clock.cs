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
        Timer timer;
        Minutes m1 =  new Minutes();
        
        int count;
        int tempMin;

        public void SetClock()
        {
            

        }

       
        
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
