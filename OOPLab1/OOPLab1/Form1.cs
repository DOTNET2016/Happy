﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace OOPLab1
{
    public partial class Form1 : Form
    {
        Timer t2 = new Timer();
        Minutes m1 = new Minutes();
        Hour h1 = new Hour();

        private Clock c1 = new Clock();
        int setMinutes;
        int setHours;
        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.RISE_100);

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
                LabelTimer();
                simpleSound.PlayLooping();
            }
            if (!IsOn)
            {
                LabelTimer();
                simpleSound.Stop();
                //MessageBox.Show("Enter some numbers in the text boxes");
            }
        }
        public void LabelTimer()
        {

            TimerOn = !TimerOn;
            UpdateLabel();
            //if (!TimerOn)
            //{
            //    t2.Enabled = true;
            //}
            //if (IsOn)
            //{
            //    t2.Stop();
            //    minuteLabel.Text = setMinutes.ToString("00");
            //}

        }
        public void UpdateLabel()
        {


            int setMinute = m1.MinuteCount();

            //setMinute = setMinutes;
            minuteLabel.Text = setMinute.ToString("00");
            //if (setMinute > 59)
            //{
            //    int setHour = h1.HourCount();
            //    HourLabel.Text = setHour.ToString("00");
            //}

        }
        
        private void T2_Tick(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private bool _IsOn;
        private bool _timerOn;
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
            }
        }
        public bool TimerOn
        {
            get
            {
                return _timerOn;
            }
            set
            {
                _timerOn = value;
                t2.Enabled = _timerOn ? true : false;
            }
        }

        private void SetMinTextBox_TextChanged(object sender, EventArgs e)
        {
            //c1.SetClock(setMinutes, setHours);
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
            else
            {
                HourLabel.Text = setHours.ToString("00");//SETS THE USERINPUT FROM MINUTE TEXTBOX TO THE MINUTE LABEL
            }

            if (setMinutes >= 60)//CONTROL SO THEY ENTER 1 - 59 FOR THE MINUTES
            {
                MessageBox.Show("It's a clock dummy! Enter 1 - 59");//PRINT IN MESSAGE BOX IF THEY ENTER WRONG
            }
            else
            {
                minuteLabel.Text = setMinutes.ToString("00");//SETS THE USERINPUT FROM MINUTE TEXTBOX TO THE MINUTE LABEL  
                //m1.MinutesValue = setMinutes;
                //m1.MinuteCount();               
            }
        }

        private void SetTimeButton_Click(object sender, EventArgs e)
        {

        }
    }
}