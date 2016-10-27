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
using System.Threading;

namespace OOPLab1
{
    public partial class Form1 : Form
    {
        SoundPlayer alarmSound = new SoundPlayer(Properties.Resources.sound);
        //Import of a dll and adding the font to the memory for the program to use
        #region
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font myFont;
        Font myFontClock;
        #endregion
        public Form1()
        {
            //Splash Screen timer starts
            //Thread splash = new Thread(new ThreadStart(SplashScreen));
            //splash.Start();
            //Thread.Sleep(5000);
            InitializeComponent();
            //splash.Abort();
            //"small" implementation of our custom font
            #region
            byte[] fontData = Properties.Resources.MyFont1;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.MyFont1.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.MyFont1.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            myFont = new Font(fonts.Families[0], 12.0F);
            myFontClock = new Font(fonts.Families[0], 95.0F);
            #endregion
            t1.Interval = 1000;
            t1.Tick += T1_Tick;
        }

        public void SplashScreen()
        {
            Application.Run(new ProgressBarIntroScreen());
        }

        Regex nonNumericRegex = new Regex(@"\D");
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        Clock c1 = new Clock();
        Alarm a1 = new Alarm();

        int getMinutes;
        int getHours;
        int _alarmSetHours;
        int _alarmSetHours2;
        int _alarmSetMins;
        int _alarmSetMins2;
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
                ResetLabel();
                this.Alarm1GroupBox.BackColor = Color.Black;
            }
            if (!IsOn)
            {
                ResetAlarms();
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

        //when stop button is presset the time will reset and clock will start at set time
        private void ResetLabel()
        {
            c1.SetMins = getMinutes;
            c1.SetHour = getHours;
            ClockLabel.Text = getHours.ToString("00") + ":" + getMinutes.ToString("00");
            c1.TimeReset();
        }
        private void ResetAlarms()
        {
            this.Alarm1GroupBox.BackColor = Color.Black;
            AlarmSetButton.Enabled = _alarmButtonIsOn = true;
            AlarmSetButton2.Enabled = _alarmButton2IsOn = true;
            AlarmSetHoursTextBox.Text = "00";
            AlarmSetMinTextBox.Text = "00";
            a1.AlarmMins = _alarmSetMins;
            a1.AlarmHours = _alarmSetHours;
            a1.AlarmMins = _alarmSetMins2;
            a1.AlarmHours = _alarmSetHours2;
            a1.tempHrs = getHours;
            a1.tempMin = getMinutes;
        }

        //here is where the magic from the stop button is performed (it works so we dont question it)
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
                AlarmSetHoursTextBox.Enabled = _alarmButtonIsOn = true;
                AlarmSetMinTextBox.Enabled = _alarmButtonIsOn = true;
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
                AlarmSetHoursTextBox.BackColor = _IsOn ? Color.White : Color.Yellow;
                AlarmSetMinTextBox.Enabled = _alarmButtonIsOn = false;
                AlarmSetMinTextBox.BackColor = _IsOn ? Color.White : Color.Yellow;
                AlarmSetButton.Enabled = _alarmButtonIsOn = false;
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
                AlarmSetHoursTextBox2.BackColor = _IsOn ? Color.White : Color.Yellow;
                AlarmSetMinTextBox2.Enabled = _alarmButton2IsOn = false;
                AlarmSetMinTextBox2.BackColor = _IsOn ? Color.White : Color.Yellow;
                AlarmSetButton2.Enabled = _alarmButton2IsOn = false;
            }
        }

        //get user input from from textbox and save to minutes
        private void SetMinTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                getMinutes = int.Parse(SetMinTextBox.Text);
                getMinutes = Convert.ToInt32(SetMinTextBox.Text);
            }
            catch (Exception)
            {
                getMinutes = 0;
            }                
        }

        //get user input from from textbox and save to hours
        private void SetHourTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                getHours = Convert.ToInt32(SetHourTextBox.Text);
                getHours = int.Parse(SetHourTextBox.Text);
            }
            catch (Exception)
            {
                getHours = 0;
            }
        }

        //A button to set the time that was input to the min/hour textboxes
        private void SetTimeButton_Click(object sender, EventArgs e)
        {
            if (getHours >= 24)
            {
                MessageBox.Show("It's a 24 hour clock dummy! Enter 1 - 23");
            }
            else if (nonNumericRegex.IsMatch(SetHourTextBox.Text))
            {
                MessageBox.Show("Entered non-numeric, please enter numbers only");
            }
            else if (getMinutes >= 60)
            {
                MessageBox.Show("It's a clock dummy! Enter 1 - 59");
            }
            else if (nonNumericRegex.IsMatch(SetMinTextBox.Text))
            {
                MessageBox.Show("Entered non-numeric, please enter numbers only");
            }
            else
            {
                ClockLabel.Text = getHours.ToString("00") + ":" + getMinutes.ToString("00");
                c1.SetMins = getMinutes;
                c1.SetHour = getHours;
                a1.tempHrs = getHours;
                a1.tempMin = getMinutes;
            }
        }

        private void AlarmSetHoursTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _alarmSetHours = Convert.ToInt32(AlarmSetHoursTextBox.Text);
                _alarmSetHours = int.Parse(AlarmSetHoursTextBox.Text);
            }
            catch (Exception)
            {
                _alarmSetHours = 0;
            }
        }

        private void AlarmSetMinTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _alarmSetMins = int.Parse(AlarmSetMinTextBox.Text);
                _alarmSetMins = Convert.ToInt32(AlarmSetMinTextBox.Text);
            }
            catch (Exception)
            {
                _alarmSetMins = 0;
            }
        }

        private void AlarmSetHoursTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _alarmSetHours2 = Convert.ToInt32(AlarmSetHoursTextBox.Text);
                _alarmSetHours2 = int.Parse(AlarmSetHoursTextBox.Text);
            }
            catch (Exception)
            {
                _alarmSetHours2 = 0;
            }
        }

        private void AlarmSetMinTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _alarmSetMins2 = int.Parse(AlarmSetMinTextBox.Text);
                _alarmSetMins2 = Convert.ToInt32(AlarmSetMinTextBox.Text);
            }
            catch (Exception)
            {
                _alarmSetMins2 = 0;
            }
        }

        private void SetAlarmButton_Click(object sender, EventArgs e)
        {
            if (_alarmSetHours >= 24)
            {
                MessageBox.Show("It's a 24 hour clock dummy! Enter 1 - 23");
            }
            else if (nonNumericRegex.IsMatch(AlarmSetHoursTextBox.Text))
            {
                MessageBox.Show("Entered non-numeric, please enter numbers only");
            }
            else if (_alarmSetMins >= 60)
            {
                MessageBox.Show("It's a clock dummy! Enter 1 - 59");
            }
            else if (nonNumericRegex.IsMatch(AlarmSetMinTextBox.Text))
            {
                MessageBox.Show("Entered non-numeric, please enter numbers only");
            }
            else
            {
                a1.AlarmMins = _alarmSetMins;
                a1.AlarmHours = _alarmSetHours;
            }
            AlarmButtonIsOn = !AlarmButtonIsOn;
            if (AlarmButtonIsOn)
            {
                alarmSound.Play();
                //simpleSound.PlayLooping();
            }
            if (!AlarmButtonIsOn)
            {
                alarmSound.Stop();
                //simpleSound.Stop();
            }
            else
            {
                a1.AlarmMins = _alarmSetMins;
                a1.AlarmHours = _alarmSetHours;
            }
        }

        private void AlarmChecker()
        {
            a1.tempHrs = setHour;
            a1.tempMin = setMinute;

            while (a1.AlarmCount() == true)
            {
                Alarm1GroupBox.Enabled = true;
                for (int c = 0; c < 253 && Visible; c++)
                {
                    this.Alarm1GroupBox.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    timer1.Start();
                }
            }
        }

        private void AlarmSetButton2_Click(object sender, EventArgs e)
        {

            if (_alarmSetHours2 >= 24)
            {
                MessageBox.Show("It's a 24 hour clock dummy! Enter 1 - 23");
            }
            else if (nonNumericRegex.IsMatch(AlarmSetHoursTextBox.Text))
            {
                MessageBox.Show("Entered non-numeric, please enter numbers only");
            }
            else if (_alarmSetMins2 >= 60)
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
            else
            {
                a1.Alarm2Mins = _alarmSetMins2;
                a1.Alarm2Hours = _alarmSetHours2;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Alarm1GroupBox.BackColor = Color.Black;
            alarmSound.Stop();
        }

        private void SetMinTextBox_Click(object sender, EventArgs e)
        {
            SetMinTextBox.Text = "";
        }

        private void SetHourTextBox_Click(object sender, EventArgs e)
        {
            SetHourTextBox.Text = "";
        }

        private void AlarmSetHoursTextBox_Click(object sender, EventArgs e)
        {
            AlarmSetHoursTextBox.Text = "";
        }

        private void AlarmSetMinTextBox_Click(object sender, EventArgs e)
        {
            AlarmSetMinTextBox.Text = "";
        }

        private void AlarmSetHoursTextBox2_Click(object sender, EventArgs e)
        {
            AlarmSetHoursTextBox2.Text = "";
        }

        private void AlarmSetMinTextBox2_Click(object sender, EventArgs e)
        {
            AlarmSetMinTextBox2.Text = "";
        }
    }
}