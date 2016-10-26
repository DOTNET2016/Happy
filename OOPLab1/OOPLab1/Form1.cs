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
using System.Drawing.Text;

namespace OOPLab1
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font myFont;
        Font myFontClock;

        public Form1()
        {
            InitializeComponent();

            byte[] fontData = Properties.Resources.MyFont1;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.MyFont1.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.MyFont1.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            myFont = new Font(fonts.Families[0], 12.0F);
            myFontClock = new Font(fonts.Families[0], 95.0F);

            t1.Interval = 1000;
            t1.Tick += T1_Tick;
        }

        Regex nonNumericRegex = new Regex(@"\D");
        Timer t1 = new Timer();
        Clock c1 = new Clock();
        Alarm a1 = new Alarm();

        int setMinutes;
        int setHours;
        int _AlarmSetHours;
        int _AlarmSetMins;
        int setHour;
        int setMinute;

        private bool _IsOn;
        private bool _alarmButtonIsOn;
        private bool _alarmButton2IsOn;

        private void Form1_Load(object sender, EventArgs e)
        {
            ClockLabel.Font = myFontClock;
            ClockGroupBox.Font = myFont;
            SetHoursLabel.Font = myFont;
            SetMinLabel.Font = myFont;
            ButtonGroupBoxSetStop.Font = myFont;
            SetTimeButton.Font = myFont;
            StopButton.Font = myFont;
            Alarm1GroupBox.Font = myFont;
            Alarm2GroupBox.Font = myFont;
            AlarmSetButton.Font = myFont;
            AlarmSetHoursLabel.Font = myFont;
            AlarmSetMinLabel.Font = myFont;
            AlarmSetButton2.Font = myFont;
            AlarmSetHoursLabel2.Font = myFont;
            AlarmSetMinLabel2.Font = myFont;

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
            setMinute = c1.CheckMin();
            setHour = c1.CheckHour();
            ClockLabel.Text = setHour.ToString("00") + ":" + setMinute.ToString("00");
            AlarmChecker();

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
                AlarmSetButton.Text = _IsOn ? "Set Alarm" : "Set Alarm";
                AlarmSetHoursTextBox.Enabled = _alarmButtonIsOn = true;
                AlarmSetMinTextBox.Enabled = _alarmButtonIsOn = true;
                AlarmSetButton2.Text = _IsOn ? "Set Alarm" : "Set Alarm";
                AlarmSetHoursTextBox.Enabled = _alarmButtonIsOn = true;
                AlarmSetMinTextBox.Enabled = _alarmButtonIsOn = true;
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
        public bool AlarmButtonIsOn
        {
            get
            {
                return _alarmButtonIsOn;
            }
            set
            {
                _alarmButtonIsOn = value;
                AlarmSetButton.Text = _alarmButtonIsOn ? "Alarm set" : "Set Alarm";
                AlarmSetHoursTextBox.Enabled = _alarmButtonIsOn = false;
                AlarmSetMinTextBox.Enabled = _alarmButtonIsOn = false;
                //AlarmSetButton.Enabled = _alarmButtonIsOn ? true : false;
            }
        }

        public bool AlarmButton2IsOn
        {
            get
            {
                return _alarmButton2IsOn;
            }
            set
            {
                _alarmButton2IsOn = value;
                AlarmSetButton2.Text = _alarmButton2IsOn ? "Alarm set" : "Set Alarm";
                AlarmSetHoursTextBox2.Enabled = _alarmButton2IsOn = false;
                AlarmSetMinTextBox2.Enabled = _alarmButton2IsOn = false;
                //AlarmSetButton2.Enabled = _alarmButton2IsOn ? true : false;
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
            //Alarm1GroupBox.Enabled = false;
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

        private void AlarmSetHoursTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _AlarmSetHours = Convert.ToInt32(AlarmSetHoursTextBox.Text);
                _AlarmSetHours = int.Parse(AlarmSetHoursTextBox.Text);
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
            else if (nonNumericRegex.IsMatch(AlarmSetHoursTextBox.Text))
            {
                MessageBox.Show("Entered non-numeric, please enter numbers only");
            }
            else if (_AlarmSetMins >= 60)
            {
                MessageBox.Show("It's a clock dummy! Enter 1 - 59");
            }
            else if (nonNumericRegex.IsMatch(AlarmSetMinTextBox.Text))
            {
                MessageBox.Show("Entered non-numeric, please enter numbers only");
            }

            AlarmButtonIsOn = !AlarmButtonIsOn;
            if (AlarmButtonIsOn)
            {
                //simpleSound.PlayLooping();
            }
            if (!AlarmButtonIsOn)
            {
                //simpleSound.Stop();
            }
            //else
            //{
            //    a1.AlarmMins = _AlarmSetMins;
            //    a1.AlarmHours = _AlarmSetHours;
            //}
        }

        private void AlarmChecker()
        {        
            if (_AlarmSetHours == setHour && _AlarmSetMins == setMinute)
            {
                for (setMinute = c1.SetMins;  setMinute < 11; setMinute++)
                {
                    Alarm1GroupBox.Enabled = true;
                    for (int c = 0; c < 253 && Visible; c++)
                    {
                        this.Alarm1GroupBox.BackColor = Color.FromArgb(c, 255 - c, c);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(1);
                    }
                    this.Alarm1GroupBox.BackColor = Color.Black;
                }
            }
        }

        private void Alarm1GroupBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void AlarmSetButton2_Click(object sender, EventArgs e)
        {

            if (_AlarmSetHours >= 24)
            {
                MessageBox.Show("It's a 24 hour clock dummy! Enter 1 - 23");
            }
            else if (nonNumericRegex.IsMatch(AlarmSetHoursTextBox.Text))
            {
                MessageBox.Show("Entered non-numeric, please enter numbers only");
            }
            else if (_AlarmSetMins >= 60)
            {
                MessageBox.Show("It's a clock dummy! Enter 1 - 59");
            }
            else if (nonNumericRegex.IsMatch(AlarmSetMinTextBox.Text))
            {
                MessageBox.Show("Entered non-numeric, please enter numbers only");
            }

            AlarmButton2IsOn = !AlarmButton2IsOn;
            if (AlarmButton2IsOn)
            {
                //simpleSound.PlayLooping();
            }
            if (!AlarmButton2IsOn)
            {
                //simpleSound.Stop();
            }
            //else
            //{
            //    a1.AlarmMins = _AlarmSetMins;
            //    a1.AlarmHours = _AlarmSetHours;
            //}
        }
    }
}