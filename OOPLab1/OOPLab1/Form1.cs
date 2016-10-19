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
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //SetHourTextBox.Text = 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void ChangeLabel()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StopButton_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopButton.Text = "Stop";
            timer1.Start();
        }

        private void SetMinTextBox_TextChanged(object sender, EventArgs e)
        {
            int setMinutes;
            setMinutes = Convert.ToInt32(SetMinTextBox.Text);
            setMinutes = int.Parse(SetMinTextBox.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
