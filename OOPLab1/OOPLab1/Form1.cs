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

        SoundPlayer alarm1Sound = new SoundPlayer(Properties.Resources.AlarmSound2);
        SoundPlayer alarm2Sound = new SoundPlayer(Properties.Resources.AlarmSound2);

        //Sorry but i wont be able to attend today, got a time for haircut at 13:45
        //that leaves me no time to get to the city, to only return back how again.
        //hope i didnt break to much code, all stuff except the things i wrote in prev commit
        //maybe we should only have sound on 1 alarm, that makes it just so much easier.

        //Import of a dll and adding the font to the memory for the program to use
        #region FontLoadingStuff
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
            #region FontLoadingStuff
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
            AlarmChecker2();
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
            //alarm 1
            this.Alarm1GroupBox.BackColor = Color.Black;
            AlarmSetButton.Enabled = _alarmButtonIsOn = true;
            AlarmSetHoursTextBox.Text = "00";
            AlarmSetMinTextBox.Text = "00";
            a1.AlarmMins = _alarmSetMins;
            a1.AlarmHours = _alarmSetHours;
            AlarmSetButton.Text = "Set Alarm";
            //alarm 2
            this.Alarm2GroupBox.BackColor = Color.Black;
            AlarmSetButton2.Enabled = _alarmButton2IsOn = true;
            AlarmSetHoursTextBox2.Text = "00";
            AlarmSetMinTextBox2.Text = "00";
            AlarmSetButton2.Text = "Set Alarm";
            a1.AlarmMins = _alarmSetMins2;
            a1.AlarmHours = _alarmSetHours2;
            //set the temp min/hrs for alarm class
            a1.tempHrs1 = getHours;
            a1.tempMin1 = getMinutes;
            a1.tempHrs2 = getHours;
            a1.tempMin2 = getMinutes;
            timer1.Stop();
            alarm1Sound.Stop();
            timer2.Stop();
            alarm2Sound.Stop();
        }

        #region ButtonBoolChecks
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
            }
        }
        #endregion

        #region SetTimeButtonStuff
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
                //set the alarm class temp min/hrs to the clock min/hrs
                a1.tempHrs1 = getHours;
                a1.tempMin1 = getMinutes;
                a1.tempHrs2 = getHours;
                a1.tempMin2 = getMinutes;
            }
        }

        private void SetMinTextBox_Click(object sender, EventArgs e)
        {
            SetMinTextBox.Text = "";
        }

        private void SetHourTextBox_Click(object sender, EventArgs e)
        {
            SetHourTextBox.Text = "";
        }
        #endregion

        #region Alarm1Stuff
        //get user input for alarm 1 - Hours.
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
        //get user input for alarm 1 - Minutes
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

        //set the alarm 1 and control the user input
        private void SetAlarmButton_Click(object sender, EventArgs e)
        {
            if (_alarmSetHours >= 24)
            {
                MessageBox.Show("It's a 24 hour clock dummy! Enter 1 - 23");
                //AlarmButtonIsOn = AlarmButtonIsOn;
            }
            else if (nonNumericRegex.IsMatch(AlarmSetHoursTextBox.Text))
            {
                MessageBox.Show("Entered non-numeric, please enter numbers only");
                AlarmButtonIsOn = AlarmButtonIsOn;
            }
            else if (_alarmSetMins >= 60)
            {
                MessageBox.Show("It's a clock dummy! Enter 1 - 59");
                AlarmButtonIsOn = AlarmButtonIsOn;
            }
            else if (nonNumericRegex.IsMatch(AlarmSetMinTextBox.Text))
            {
                MessageBox.Show("Entered non-numeric, please enter numbers only");
                AlarmButtonIsOn = AlarmButtonIsOn;
            }
            else
            {
                AlarmSetHoursTextBox.Enabled = _alarmButtonIsOn = false;
                AlarmSetHoursTextBox.BackColor = _IsOn ? Color.White : Color.Yellow;
                AlarmSetMinTextBox.Enabled = _alarmButtonIsOn = false;
                AlarmSetMinTextBox.BackColor = _IsOn ? Color.White : Color.Yellow;
                AlarmSetButton.Enabled = _alarmButtonIsOn = false;
                AlarmButtonIsOn = !AlarmButtonIsOn;
                a1.AlarmMins = _alarmSetMins;
                a1.AlarmHours = _alarmSetHours;
            }
        }

        private void AlarmSetHoursTextBox_Click(object sender, EventArgs e)
        {
            AlarmSetHoursTextBox.Text = "";
        }

        private void AlarmSetMinTextBox_Click(object sender, EventArgs e)
        {
            AlarmSetMinTextBox.Text = "";
        }
        #endregion

        #region Alarm2Stuff
        //get user input for alarm 2 - Hours
        private void AlarmSetHoursTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _alarmSetHours2 = Convert.ToInt32(AlarmSetHoursTextBox2.Text);
                _alarmSetHours2 = int.Parse(AlarmSetHoursTextBox2.Text);
            }
            catch (Exception)
            {
                _alarmSetHours2 = 0;
            }
        }
        //get user input for alarm 2 - Minutes
        private void AlarmSetMinTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _alarmSetMins2 = int.Parse(AlarmSetMinTextBox2.Text);
                _alarmSetMins2 = Convert.ToInt32(AlarmSetMinTextBox2.Text);
            }
            catch (Exception)
            {
                _alarmSetMins2 = 0;
            }
        }
        //set the alarm 2 and control the user input
        private void AlarmSetButton2_Click(object sender, EventArgs e)
        {
            if (_alarmSetHours2 >= 24)
            {
                MessageBox.Show("It's a 24 hour clock dummy! Enter 1 - 23");
                AlarmButton2IsOn = AlarmButton2IsOn;
            }
            else if (nonNumericRegex.IsMatch(AlarmSetHoursTextBox2.Text))
            {
                MessageBox.Show("Entered non-numeric, please enter numbers only");
                AlarmButton2IsOn = AlarmButton2IsOn;
            }
            else if (_alarmSetMins2 >= 60)
            {
                MessageBox.Show("It's a clock dummy! Enter 1 - 59");
                AlarmButton2IsOn = AlarmButton2IsOn;
            }
            else if (nonNumericRegex.IsMatch(AlarmSetMinTextBox2.Text))
            {
                MessageBox.Show("Entered non-numeric, please enter numbers only");
                AlarmButton2IsOn = AlarmButton2IsOn;
            }
            else
            {
                AlarmSetHoursTextBox2.Enabled = _alarmButton2IsOn = false;
                AlarmSetHoursTextBox2.BackColor = _IsOn ? Color.White : Color.Yellow;
                AlarmSetMinTextBox2.Enabled = _alarmButton2IsOn = false;
                AlarmSetMinTextBox2.BackColor = _IsOn ? Color.White : Color.Yellow;
                AlarmSetButton2.Enabled = _alarmButton2IsOn = false;
                AlarmButton2IsOn = !AlarmButton2IsOn;
                a1.Alarm2Mins = _alarmSetMins2;
                a1.Alarm2Hours = _alarmSetHours2;
            }
        }

        private void AlarmSetHoursTextBox2_Click(object sender, EventArgs e)
        {
            AlarmSetHoursTextBox2.Text = "";
        }

        private void AlarmSetMinTextBox2_Click(object sender, EventArgs e)
        {
            AlarmSetMinTextBox2.Text = "";
        }
        #endregion

        #region AlarmCheckLogic
        //check the state of the alarm 1 with the method in alarm class - if active set off the alarm
        public void AlarmChecker()
        {
            a1.tempHrs1 = setHour;
            a1.tempMin1 = setMinute;

            if (a1.Alarm1Count() == true)
            {
                alarm2Sound.Stop();
                alarm1Sound.PlayLooping();
                Alarm1GroupBox.Enabled = true;
                this.Alarm1GroupBox.BackColor = Color.Lime;
                Application.DoEvents();
                timer1.Start();
            }
        }
        //check the state of the alarm 2 with the method in alarm class - if active set off the alarm
        private void AlarmChecker2()
        {
            a1.tempHrs2 = setHour;
            a1.tempMin2 = setMinute;

            if (a1.Alarm2Count() == true)
            {
                alarm1Sound.Stop();
                alarm2Sound.PlayLooping();
                Alarm2GroupBox.Enabled = true;
                this.Alarm2GroupBox.BackColor = Color.Red;
                Application.DoEvents();
                timer2.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Alarm1GroupBox.BackColor = Color.Black;
            timer1.Stop();
            alarm1Sound.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Alarm2GroupBox.BackColor = Color.Black;
            timer2.Stop();
            alarm2Sound.Stop();
        }
        #endregion
    }
}