using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OOPLab1
{
    public partial class Form1 : Form
    {
        Timer t2 = new Timer();
        Clock c1 = new Clock();
        Alarm a1 = new Alarm();

        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.RISE_100);
        int setMinutes;
        int setHours;
        int _AlarmSetHours;
        int _AlarmSetMins;
        Regex nonNumericRegex = new Regex(@"\D");

        private bool _IsOn;

        public bool IsOn
        {
            get
            {
                return _IsOn;
            }
            set
            {
                _IsOn = value;
                StopButton.Text = _IsOn ? "Stop" : "Start";
                t2.Enabled = _IsOn ? true : false;
                SetHourTextBox.Enabled = _IsOn ? false : true;
                SetMinTextBox.Enabled = _IsOn ? false : true;
                SetTimeButton.Enabled = _IsOn ? false : true;
                SetAlarmButton.Enabled = _IsOn ? false : true;
            }
        }

        public Form1()
        {
            InitializeComponent();
            t2.Interval = 1000;
            t2.Tick += T2_Tick;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {            
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            IsOn = !IsOn;
            if (IsOn)
            {
                //simpleSound.PlayLooping();
            }
            if (!IsOn)
            {
                c1.SetMins = setMinutes;
                c1.SetHour = setHours;
                minuteLabel.Text = setMinutes.ToString("00");
                HourLabel.Text = setHours.ToString("00");
                //simpleSound.Stop();
            }
        }

        public void UpdateLabel()
        {
            int setMinute = c1.CheckTime();
            if (setMinute <= 60)
            minuteLabel.Text = setMinute.ToString("00");
            //if (setMinute == 0)
            //{
            //        int setHour = setHours;
            //        setHour = h1.HoursValue;
            //        setHour = h1.HourCount();
            //        HourLabel.Text = setHour.ToString("00");
            //}           
        }
        
        private void T2_Tick(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void SetMinTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                setMinutes = int.Parse(SetMinTextBox.Text);
                setMinutes = Convert.ToInt32(SetMinTextBox.Text);
            }
            catch (Exception)
            {
                setMinutes = 0;
            }                
        }

        private void SetHourTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                setHours = Convert.ToInt32(SetHourTextBox.Text);
                setHours = int.Parse(SetHourTextBox.Text);
            }
            catch (Exception)
            {
                setHours = 0;
            }
        }

        private void SetTimeButton_MouseClick(object sender, MouseEventArgs e)
        {
            //c1.SetClock(int.parse(label2.Text))
            //c1.SetClock(int.Parse(minuteLabel.Text));

            if (setHours >= 24)//CONTROL SO THEY ENTER 1 - 23 FOR THE MINUTES
            {
                MessageBox.Show("It's a 24 hour clock dummy! Enter 1 - 23");//PRINT IN MESSAGE BOX IF THEY ENTER WRONG
            }
            else if (nonNumericRegex.IsMatch(SetHourTextBox.Text))
            {
                //Contains non numeric characters.
                MessageBox.Show("Entered non-numeric, please enter numbers only");
            }
            else
            {
                HourLabel.Text = setHours.ToString("00");//SETS THE USERINPUT FROM HOUR TEXTBOX TO THE MINUTE LABEL
                c1.SetHour = setHours;
            }

            if (setMinutes >= 60)//CONTROL SO THEY ENTER 1 - 59 FOR THE MINUTES
            {
                MessageBox.Show("It's a clock dummy! Enter 1 - 59");//PRINT IN MESSAGE BOX IF THEY ENTER WRONG
            }
            else if (nonNumericRegex.IsMatch(SetMinTextBox.Text))
            {
                //Contains non numeric characters.
                MessageBox.Show("Entered non-numeric, please enter numbers only");
            }
            else
            {
                minuteLabel.Text = setMinutes.ToString("00");//SETS THE USERINPUT FROM ALARM MINUTE TEXTBOX TO THE MINUTE LABEL  
                c1.SetMins = setMinutes;
            }
        }

        private void AlarmHoursTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _AlarmSetHours = Convert.ToInt32(AlarmHoursTextBox.Text);
                _AlarmSetHours = int.Parse(AlarmHoursTextBox.Text);
            }
            catch (Exception)
            {
                setHours = 0;
            }
        }

        private void AlarmSetMinTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _AlarmSetMins = int.Parse(AlarmSetMinTextBox.Text);
                _AlarmSetMins = Convert.ToInt32(AlarmSetMinTextBox.Text);
            }
            catch (Exception)
            {
                setMinutes = 0;
            }
        }

        private void SetAlarmButton_Click(object sender, EventArgs e)
        {
            //c1.SetClock(int.Parse(minuteLabel.Text));

            if (_AlarmSetHours >= 24)//CONTROL SO THEY ENTER 1 - 23 FOR THE MINUTES
            {
                MessageBox.Show("It's a 24 hour clock dummy! Enter 1 - 23");//PRINT IN MESSAGE BOX IF THEY ENTER WRONG
            }
            else if (nonNumericRegex.IsMatch(AlarmHoursTextBox.Text))
            {
                //Contains non numeric characters.
                MessageBox.Show("Entered non-numeric, please enter numbers only");
            }

            if (_AlarmSetMins >= 60)//CONTROL SO THEY ENTER 1 - 59 FOR THE MINUTES
            {
                MessageBox.Show("It's a clock dummy! Enter 1 - 59");//PRINT IN MESSAGE BOX IF THEY ENTER WRONG
            }
            else if (nonNumericRegex.IsMatch(AlarmSetMinTextBox.Text))
            {
                //Contains non numeric characters.
                MessageBox.Show("Entered non-numeric, please enter numbers only");
            }
        }
    }
}