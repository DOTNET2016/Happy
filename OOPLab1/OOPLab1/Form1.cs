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
using System.Text.RegularExpressions;

namespace OOPLab1
{
    public partial class Form1 : Form
    {
        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.RISE_100);
        Regex nonNumericRegex = new Regex(@"\D");

        Timer t2 = new Timer();
        Minutes m1 = new Minutes();
        Hour h1 = new Hour();
        Clock c1 = new Clock();

        int setMinutes;
        int setHours;

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
            if (!IsOn)
            {
                m1.MinutesValue = setMinutes;
                h1.HoursValue = setHours;
                minuteLabel.Text = setMinutes.ToString("00");
                HourLabel.Text = setHours.ToString("00");
            }
        }

        public void UpdateLabel()
        {
            int setMinute = m1.MinuteCount();
            if (setMinute <= 60)
                minuteLabel.Text = setMinute.ToString("00");
            if (setMinute == 0)
            {
                    int setHour = setHours;
                    setHour = h1.HoursValue;
                    setHour = h1.HourCount();
                    HourLabel.Text = setHour.ToString("00");
            }           
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
            if (setHours >= 24)
            {
                MessageBox.Show("It's a 24 hour clock dummy! Enter 1 - 23");
            }
            else if (nonNumericRegex.IsMatch(SetHourTextBox.Text))
            {
                MessageBox.Show("Entered non-numeric, please enter numbers only");
            }
            else
            {
                HourLabel.Text = setHours.ToString("00");
                h1.HoursValue = setHours;
            }

            if (setMinutes >= 60)
            {
                MessageBox.Show("It's a clock dummy! Enter 1 - 59");
            }
            else if (nonNumericRegex.IsMatch(SetMinTextBox.Text))
            {
                MessageBox.Show("Entered non-numeric, please enter numbers only");
            }
            else
            {
                minuteLabel.Text = setMinutes.ToString("00"); 
                m1.MinutesValue = setMinutes;
            }
        }
    }
}