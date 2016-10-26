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
        //new
        Regex nonNumericRegex = new Regex(@"\D");
        Timer t1 = new Timer();
        Clock c1 = new Clock();
        Alarm a1 = new Alarm();

        int setMinutes;
        int setHours;
        int _AlarmSetHours;
        int _AlarmSetMins;

        private bool _IsOn;

        public Form1()
        {
            InitializeComponent();
            t1.Interval = 1000;
            t1.Tick += T1_Tick;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            IsOn = !IsOn;
            if (IsOn)
            {
                c1.TimeValue();
                //simpleSound.PlayLooping();
            }
            if (!IsOn)
            {
                c1.TimeValue();
                ResetLabel();
                //simpleSound.Stop();
            }
        }

        public void UpdateLabel()
        {
            int setMinute = c1.CheckMin();
            int setHour = c1.CheckHour();
            ClockLabel.Text = setHour.ToString("00") + ":" + setMinute.ToString("00");

        }
        
        private void T1_Tick(object sender, EventArgs e)
        {
            UpdateLabel();
        }

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
                t1.Enabled = _IsOn ? true : false;
                SetHourTextBox.Enabled = _IsOn ? false : true;
                SetHourTextBox.BackColor = _IsOn ? Color.SkyBlue : Color.White;
                SetMinTextBox.Enabled = _IsOn ? false : true;
                SetMinTextBox.BackColor = _IsOn ? Color.SkyBlue : Color.White;
                SetTimeButton.Enabled = _IsOn ? false : true;
                SetTimeButton.BackColor = _IsOn ? Color.SkyBlue : Color.White;
                AlarmSetButton.Enabled = _IsOn ? false : true;
                AlarmSetButton.BackColor = _IsOn ? Color.SkyBlue : Color.White;
                AlarmSetHoursTextBox.Enabled = _IsOn ? false : true;
                AlarmSetHoursTextBox.BackColor = _IsOn ? Color.SkyBlue : Color.White;
                AlarmSetMinTextBox.Enabled = _IsOn ? false : true;
                AlarmSetMinTextBox.BackColor = _IsOn ? Color.SkyBlue : Color.White;
                AlarmSetButton2.Enabled = _IsOn ? false : true;
                AlarmSetButton2.BackColor = _IsOn ? Color.SkyBlue : Color.White;
                AlarmSetHoursTextBox2.Enabled = _IsOn ? false : true;
                AlarmSetHoursTextBox2.BackColor = _IsOn ? Color.SkyBlue : Color.White;
                AlarmSetMinTextBox2.Enabled = _IsOn ? false : true;
                AlarmSetMinTextBox2.BackColor = _IsOn ? Color.SkyBlue : Color.White;
            }
        }

        //get user input from from textbox and save to minutes
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

        //get user input from from textbox and save to hours
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

        //when stop button is presset the time will reset and clock will start at set time
        private void ResetLabel()
        {
            c1.SetMins = setMinutes;
            c1.SetHour = setHours;
            ClockLabel.Text = setHours.ToString("00") +":" + setMinutes.ToString("00");
        }

        private void SetTimeButton_Click(object sender, EventArgs e)
        {
            if (setHours >= 24)
            {
                MessageBox.Show("It's a 24 hour clock dummy! Enter 1 - 23");
            }
            else if (nonNumericRegex.IsMatch(SetHourTextBox.Text))
            {
                MessageBox.Show("Entered non-numeric, please enter numbers only");
            }
            else if (setMinutes >= 60)
            {
                MessageBox.Show("It's a clock dummy! Enter 1 - 59");
            }
            else if (nonNumericRegex.IsMatch(SetMinTextBox.Text))
            {
                MessageBox.Show("Entered non-numeric, please enter numbers only");
            }
            else
            {
                ClockLabel.Text = setHours.ToString("00") + ":" + setMinutes.ToString("00");
                c1.SetMins = setMinutes;
                c1.SetHour = setHours;
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
            if (_AlarmSetHours >= 24)
            {
                MessageBox.Show("It's a 24 hour clock dummy! Enter 1 - 23");
            }
            else if (nonNumericRegex.IsMatch(AlarmHoursTextBox.Text))
            {
                MessageBox.Show("Entered non-numeric, please enter numbers only");
            }

            if (_AlarmSetMins >= 60)
            {
                MessageBox.Show("It's a clock dummy! Enter 1 - 59");
            }
            else if (nonNumericRegex.IsMatch(AlarmSetMinTextBox.Text))
            {
                MessageBox.Show("Entered non-numeric, please enter numbers only");
            }
            else
            {
                a1.AlarmMins = _AlarmSetMins;
                a1.AlarmHours = _AlarmSetHours;
            }
        }

        private void AlarmChecker()
        {

        }

        private void Alarm1GroupBox_Enter(object sender, EventArgs e)
        {
            //for (int c = 0; c < 253 && Visible; c++)
            //{
            //    this.BackColor = Color.FromArgb(c, 255 - c, c);
            //    Application.DoEvents();
            //    System.Threading.Thread.Sleep(3);
            //}
            //for (int c = 254; c >= 0 && Visible; c--)
            //{
            //    this.BackColor = Color.FromArgb(c, 255 - c, c);
            //    Application.DoEvents();
            //    System.Threading.Thread.Sleep(3);
            //}
        }
    }
}