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

        int startMinute;
        int count = 0;

        public void SetClock(int time)
        {
            startMinute = time;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler (Timer_Tick);
           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (startMinute == null)
            {
                timer.Start();
                count = Convert.ToInt32(startMinute);
                count++;
            }           
        }



        public void StopClock()
        {
            throw new NotImplementedException();
        }
    }
}
