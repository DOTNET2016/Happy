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
        int setMinutes;
        int setHours;

        Minutes m1 = new Minutes();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
           
            StartButton.Text = "Stop";
        }

        private void SetMinTextBox_TextChanged(object sender, EventArgs e)
        {
           
                setMinutes = int.Parse(SetMinTextBox.Text);
                setMinutes = Convert.ToInt32(SetMinTextBox.Text);
          
        }

        private void SetHourTextBox_TextChanged(object sender, EventArgs e)
        {
            
            setHours = Convert.ToInt32(SetHourTextBox.Text);
            setHours = int.Parse(SetHourTextBox.Text);

        }

        private void SetTimeButton_MouseClick(object sender, MouseEventArgs e)
        {
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
                                   
            }

        }
    }
}
