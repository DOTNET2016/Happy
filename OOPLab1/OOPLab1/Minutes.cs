using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1
{
    class Minutes : IMinutes
    {
        System.Windows.Forms.Timer t1;

        private int _MinutesValue; //IGNORE

        public int MinutesValue { get; set; }
        



        public void Tick()
        {
            t1 = new System.Windows.Forms.Timer();
            t1.Interval = 1000;
            t1.Enabled = true;
            t1.Tick += T1_Tick;
            t1.Start();
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            t1.Start();
        }
    }
}
