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
            timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler (Timer_Tick);
            m1.MinutesValue = tempMin;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeValue();
            timer.Start();
                count = Convert.ToInt32(m1.MinutesValue);
                count++;
                          
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
