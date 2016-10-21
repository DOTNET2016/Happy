using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab1
{
    public partial class Form1 : Form
    {
        public int minutes; // Minutes.
        public int hours;   // Hours.
        public bool paused; // State of the clock [PAUSED/WORKING].


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((minutes == 0) && (hours == 0))
            {
                timer1.Enabled = false;
                PauseBtn.Enabled = false;
                StartButton.Enabled = true;
                SetMinTextBox.Enabled = true;
                SetMinTextBox.Enabled = true;
                HourLabel.Text = "00";
                minuteLabel.Text = "00";
            }
            else
            {
                hours -= 1;
                minutes -= 1;

                HourLabel.Text = hours.ToString();
                minuteLabel.Text = minutes.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void SetMinTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void SetHourTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (paused != true)
            {

                if (hours >= 1 || (minutes >= 1))
                {
                    timer1.Enabled = true;
                    StartButton.Enabled = true;
                    PauseBtn.Enabled = true;
                    SetHoursLabel.Enabled = false;
                    SetMinLabel.Enabled = false;

                    try
                    {
                        int.TryParse(SetHourTextBox.Text, out hours);
                        int.TryParse(SetMinLabel.Text, out minutes);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    timer1.Enabled = true;
                    paused = false;
                }
            }
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            paused = true;
            StartButton.Enabled = true;
            PauseBtn.Enabled = false;
        }
    }
    }

