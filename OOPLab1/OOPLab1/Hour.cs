using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1
{
    class Hour : IHours
    {
        System.Windows.Forms.Timer t2;
        private int _HoursValue;

        public int HoursValue
        {
            get
            {
                return _HoursValue;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Tick()
        {
            t2 = new System.Windows.Forms.Timer();
            t2.Interval = 1000;
            t2.Tick += T2_Tick;
            t2.Start();

            throw new NotImplementedException();
        }

        private void T2_Tick(object sender, EventArgs e)
        {

            throw new NotImplementedException();
        }
    }
}
