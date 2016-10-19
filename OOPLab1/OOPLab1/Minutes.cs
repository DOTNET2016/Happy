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
        public int MinutesValue
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Tick()
        {
            t1 = new System.Windows.Forms.Timer();
            t1.Interval = 1000;
            t1.Tick += T1_Tick;
            t1.Start();
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
