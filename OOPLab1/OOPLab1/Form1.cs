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

namespace OOPLab1
{
    public partial class Form1 : Form
    {
        Minutes m1 = new Minutes();
        private Clock c1 = new Clock();
        int setMinutes;
        int setHours;
        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.RISE_100);

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {            
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            UpdateLabel();
            IsOn = !IsOn;
            if (IsOn)
            {
                m1.TickMinutes();
                simpleSound.PlayLooping();
            }
            else if (!IsOn)
            {
                simpleSound.Stop();
                //MessageBox.Show("Enter some numbers in the text boxes");
            }
        }

        public void UpdateLabel()
        {
            int setMinute = m1.MinuteCount();
            minuteLabel.Text = Convert.ToString(setMinute);
        }

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
                //m1.MinuteCount();               
            }
        }

        private void SetTimeButton_Click(object sender, EventArgs e)
        {

        }
    }
}