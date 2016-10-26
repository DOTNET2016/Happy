namespace OOPLab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SetHourTextBox = new System.Windows.Forms.TextBox();
            this.SetMinTextBox = new System.Windows.Forms.TextBox();
            this.SetHoursLabel = new System.Windows.Forms.Label();
            this.SetMinLabel = new System.Windows.Forms.Label();
            this.ClockGroupBox = new System.Windows.Forms.GroupBox();
            this.SetTimeButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ButtonGroupBoxSetStop = new System.Windows.Forms.GroupBox();
            this.AlarmSetHoursTextBox = new System.Windows.Forms.TextBox();
            this.AlarmSetMinTextBox = new System.Windows.Forms.TextBox();
            this.AlarmSetHoursLabel = new System.Windows.Forms.Label();
            this.AlarmSetMinLabel = new System.Windows.Forms.Label();
            this.Alarm1GroupBox = new System.Windows.Forms.GroupBox();
            this.AlarmSetButton = new System.Windows.Forms.Button();
            this.Alarm2GroupBox = new System.Windows.Forms.GroupBox();
            this.AlarmSetButton2 = new System.Windows.Forms.Button();
            this.AlarmSetMinLabel2 = new System.Windows.Forms.Label();
            this.AlarmSetHoursLabel2 = new System.Windows.Forms.Label();
            this.AlarmSetMinTextBox2 = new System.Windows.Forms.TextBox();
            this.AlarmSetHoursTextBox2 = new System.Windows.Forms.TextBox();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.ClockGroupBox.SuspendLayout();
            this.ButtonGroupBoxSetStop.SuspendLayout();
            this.Alarm1GroupBox.SuspendLayout();
            this.Alarm2GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetHourTextBox
            // 
            this.SetHourTextBox.Location = new System.Drawing.Point(156, 46);
            this.SetHourTextBox.Name = "SetHourTextBox";
            this.SetHourTextBox.Size = new System.Drawing.Size(100, 30);
            this.SetHourTextBox.TabIndex = 1;
            this.SetHourTextBox.TextChanged += new System.EventHandler(this.SetHourTextBox_TextChanged);
            // 
            // SetMinTextBox
            // 
            this.SetMinTextBox.Location = new System.Drawing.Point(156, 95);
            this.SetMinTextBox.Name = "SetMinTextBox";
            this.SetMinTextBox.Size = new System.Drawing.Size(100, 30);
            this.SetMinTextBox.TabIndex = 2;
            this.SetMinTextBox.TextChanged += new System.EventHandler(this.SetMinTextBox_TextChanged);
            // 
            // SetHoursLabel
            // 
            this.SetHoursLabel.AutoSize = true;
            this.SetHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetHoursLabel.ForeColor = System.Drawing.Color.White;
            this.SetHoursLabel.Location = new System.Drawing.Point(20, 46);
            this.SetHoursLabel.Name = "SetHoursLabel";
            this.SetHoursLabel.Size = new System.Drawing.Size(114, 24);
            this.SetHoursLabel.TabIndex = 3;
            this.SetHoursLabel.Text = "Set Hours :";
            // 
            // SetMinLabel
            // 
            this.SetMinLabel.AutoSize = true;
            this.SetMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetMinLabel.Location = new System.Drawing.Point(20, 95);
            this.SetMinLabel.Name = "SetMinLabel";
            this.SetMinLabel.Size = new System.Drawing.Size(131, 24);
            this.SetMinLabel.TabIndex = 4;
            this.SetMinLabel.Text = "Set Minutes :";
            // 
            // ClockGroupBox
            // 
            this.ClockGroupBox.Controls.Add(this.SetMinLabel);
            this.ClockGroupBox.Controls.Add(this.SetHoursLabel);
            this.ClockGroupBox.Controls.Add(this.SetMinTextBox);
            this.ClockGroupBox.Controls.Add(this.SetHourTextBox);
            this.ClockGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockGroupBox.ForeColor = System.Drawing.Color.White;
            this.ClockGroupBox.Location = new System.Drawing.Point(8, 63);
            this.ClockGroupBox.Name = "ClockGroupBox";
            this.ClockGroupBox.Size = new System.Drawing.Size(295, 153);
            this.ClockGroupBox.TabIndex = 5;
            this.ClockGroupBox.TabStop = false;
            this.ClockGroupBox.Text = "Clock";
            // 
            // SetTimeButton
            // 
            this.SetTimeButton.BackColor = System.Drawing.Color.White;
            this.SetTimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTimeButton.ForeColor = System.Drawing.Color.Black;
            this.SetTimeButton.Location = new System.Drawing.Point(73, 39);
            this.SetTimeButton.Name = "SetTimeButton";
            this.SetTimeButton.Size = new System.Drawing.Size(161, 39);
            this.SetTimeButton.TabIndex = 6;
            this.SetTimeButton.Text = "Set Time";
            this.SetTimeButton.UseVisualStyleBackColor = false;
            this.SetTimeButton.Click += new System.EventHandler(this.SetTimeButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.White;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.ForeColor = System.Drawing.Color.Black;
            this.StopButton.Location = new System.Drawing.Point(73, 95);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(161, 39);
            this.StopButton.TabIndex = 7;
            this.StopButton.Text = "Start";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ButtonGroupBoxSetStop
            // 
            this.ButtonGroupBoxSetStop.Controls.Add(this.StopButton);
            this.ButtonGroupBoxSetStop.Controls.Add(this.SetTimeButton);
            this.ButtonGroupBoxSetStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGroupBoxSetStop.ForeColor = System.Drawing.Color.White;
            this.ButtonGroupBoxSetStop.Location = new System.Drawing.Point(675, 63);
            this.ButtonGroupBoxSetStop.Name = "ButtonGroupBoxSetStop";
            this.ButtonGroupBoxSetStop.Size = new System.Drawing.Size(291, 153);
            this.ButtonGroupBoxSetStop.TabIndex = 8;
            this.ButtonGroupBoxSetStop.TabStop = false;
            this.ButtonGroupBoxSetStop.Text = "Set/Stop";
            // 
            // AlarmSetHoursTextBox
            // 
            this.AlarmSetHoursTextBox.Location = new System.Drawing.Point(152, 56);
            this.AlarmSetHoursTextBox.Name = "AlarmSetHoursTextBox";
            this.AlarmSetHoursTextBox.Size = new System.Drawing.Size(100, 28);
            this.AlarmSetHoursTextBox.TabIndex = 9;
            this.AlarmSetHoursTextBox.TextChanged += new System.EventHandler(this.AlarmSetHoursTextBox_TextChanged);
            // 
            // AlarmSetMinTextBox
            // 
            this.AlarmSetMinTextBox.Location = new System.Drawing.Point(152, 108);
            this.AlarmSetMinTextBox.Name = "AlarmSetMinTextBox";
            this.AlarmSetMinTextBox.Size = new System.Drawing.Size(100, 28);
            this.AlarmSetMinTextBox.TabIndex = 10;
            this.AlarmSetMinTextBox.TextChanged += new System.EventHandler(this.AlarmSetMinTextBox_TextChanged);
            // 
            // AlarmSetHoursLabel
            // 
            this.AlarmSetHoursLabel.AutoSize = true;
            this.AlarmSetHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmSetHoursLabel.ForeColor = System.Drawing.Color.White;
            this.AlarmSetHoursLabel.Location = new System.Drawing.Point(16, 59);
            this.AlarmSetHoursLabel.Name = "AlarmSetHoursLabel";
            this.AlarmSetHoursLabel.Size = new System.Drawing.Size(120, 24);
            this.AlarmSetHoursLabel.TabIndex = 11;
            this.AlarmSetHoursLabel.Text = "Set Hours : ";
            // 
            // AlarmSetMinLabel
            // 
            this.AlarmSetMinLabel.AutoSize = true;
            this.AlarmSetMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmSetMinLabel.ForeColor = System.Drawing.Color.White;
            this.AlarmSetMinLabel.Location = new System.Drawing.Point(15, 111);
            this.AlarmSetMinLabel.Name = "AlarmSetMinLabel";
            this.AlarmSetMinLabel.Size = new System.Drawing.Size(131, 24);
            this.AlarmSetMinLabel.TabIndex = 12;
            this.AlarmSetMinLabel.Text = "Set Minutes :";
            // 
            // Alarm1GroupBox
            // 
            this.Alarm1GroupBox.Controls.Add(this.AlarmSetButton);
            this.Alarm1GroupBox.Controls.Add(this.AlarmSetMinLabel);
            this.Alarm1GroupBox.Controls.Add(this.AlarmSetHoursLabel);
            this.Alarm1GroupBox.Controls.Add(this.AlarmSetMinTextBox);
            this.Alarm1GroupBox.Controls.Add(this.AlarmSetHoursTextBox);
            this.Alarm1GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alarm1GroupBox.ForeColor = System.Drawing.Color.White;
            this.Alarm1GroupBox.Location = new System.Drawing.Point(12, 390);
            this.Alarm1GroupBox.Name = "Alarm1GroupBox";
            this.Alarm1GroupBox.Size = new System.Drawing.Size(291, 227);
            this.Alarm1GroupBox.TabIndex = 13;
            this.Alarm1GroupBox.TabStop = false;
            this.Alarm1GroupBox.Text = "Alarm 1";
            this.Alarm1GroupBox.Enter += new System.EventHandler(this.Alarm1GroupBox_Enter);
            // 
            // AlarmSetButton
            // 
            this.AlarmSetButton.BackColor = System.Drawing.Color.White;
            this.AlarmSetButton.ForeColor = System.Drawing.Color.Black;
            this.AlarmSetButton.Location = new System.Drawing.Point(73, 161);
            this.AlarmSetButton.Name = "AlarmSetButton";
            this.AlarmSetButton.Size = new System.Drawing.Size(158, 44);
            this.AlarmSetButton.TabIndex = 13;
            this.AlarmSetButton.Text = "Set Alarm";
            this.AlarmSetButton.UseVisualStyleBackColor = false;
            this.AlarmSetButton.Click += new System.EventHandler(this.SetAlarmButton_Click);
            // 
            // Alarm2GroupBox
            // 
            this.Alarm2GroupBox.Controls.Add(this.AlarmSetButton2);
            this.Alarm2GroupBox.Controls.Add(this.AlarmSetMinLabel2);
            this.Alarm2GroupBox.Controls.Add(this.AlarmSetHoursLabel2);
            this.Alarm2GroupBox.Controls.Add(this.AlarmSetMinTextBox2);
            this.Alarm2GroupBox.Controls.Add(this.AlarmSetHoursTextBox2);
            this.Alarm2GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alarm2GroupBox.ForeColor = System.Drawing.Color.White;
            this.Alarm2GroupBox.Location = new System.Drawing.Point(675, 390);
            this.Alarm2GroupBox.Name = "Alarm2GroupBox";
            this.Alarm2GroupBox.Size = new System.Drawing.Size(291, 227);
            this.Alarm2GroupBox.TabIndex = 14;
            this.Alarm2GroupBox.TabStop = false;
            this.Alarm2GroupBox.Text = "Alarm 2";
            // 
            // AlarmSetButton2
            // 
            this.AlarmSetButton2.BackColor = System.Drawing.Color.White;
            this.AlarmSetButton2.ForeColor = System.Drawing.Color.Black;
            this.AlarmSetButton2.Location = new System.Drawing.Point(73, 161);
            this.AlarmSetButton2.Name = "AlarmSetButton2";
            this.AlarmSetButton2.Size = new System.Drawing.Size(158, 44);
            this.AlarmSetButton2.TabIndex = 13;
            this.AlarmSetButton2.Text = "Set Alarm";
            this.AlarmSetButton2.UseVisualStyleBackColor = false;
            // 
            // AlarmSetMinLabel2
            // 
            this.AlarmSetMinLabel2.AutoSize = true;
            this.AlarmSetMinLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmSetMinLabel2.ForeColor = System.Drawing.Color.White;
            this.AlarmSetMinLabel2.Location = new System.Drawing.Point(17, 111);
            this.AlarmSetMinLabel2.Name = "AlarmSetMinLabel2";
            this.AlarmSetMinLabel2.Size = new System.Drawing.Size(131, 24);
            this.AlarmSetMinLabel2.TabIndex = 12;
            this.AlarmSetMinLabel2.Text = "Set Minutes :";
            // 
            // AlarmSetHoursLabel2
            // 
            this.AlarmSetHoursLabel2.AutoSize = true;
            this.AlarmSetHoursLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmSetHoursLabel2.ForeColor = System.Drawing.Color.White;
            this.AlarmSetHoursLabel2.Location = new System.Drawing.Point(17, 59);
            this.AlarmSetHoursLabel2.Name = "AlarmSetHoursLabel2";
            this.AlarmSetHoursLabel2.Size = new System.Drawing.Size(120, 24);
            this.AlarmSetHoursLabel2.TabIndex = 11;
            this.AlarmSetHoursLabel2.Text = "Set Hours : ";
            // 
            // AlarmSetMinTextBox2
            // 
            this.AlarmSetMinTextBox2.Location = new System.Drawing.Point(152, 108);
            this.AlarmSetMinTextBox2.Name = "AlarmSetMinTextBox2";
            this.AlarmSetMinTextBox2.Size = new System.Drawing.Size(100, 28);
            this.AlarmSetMinTextBox2.TabIndex = 10;
            // 
            // AlarmSetHoursTextBox2
            // 
            this.AlarmSetHoursTextBox2.Location = new System.Drawing.Point(152, 56);
            this.AlarmSetHoursTextBox2.Name = "AlarmSetHoursTextBox2";
            this.AlarmSetHoursTextBox2.Size = new System.Drawing.Size(100, 28);
            this.AlarmSetHoursTextBox2.TabIndex = 9;
            // 
            // ClockLabel
            // 
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 94.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.ForeColor = System.Drawing.Color.White;
            this.ClockLabel.Location = new System.Drawing.Point(268, 219);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(476, 180);
            this.ClockLabel.TabIndex = 15;
            this.ClockLabel.Text = "00:00";
            this.ClockLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1026, 667);
            this.Controls.Add(this.ClockLabel);
            this.Controls.Add(this.Alarm2GroupBox);
            this.Controls.Add(this.Alarm1GroupBox);
            this.Controls.Add(this.ButtonGroupBoxSetStop);
            this.Controls.Add(this.ClockGroupBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClockGroupBox.ResumeLayout(false);
            this.ClockGroupBox.PerformLayout();
            this.ButtonGroupBoxSetStop.ResumeLayout(false);
            this.Alarm1GroupBox.ResumeLayout(false);
            this.Alarm1GroupBox.PerformLayout();
            this.Alarm2GroupBox.ResumeLayout(false);
            this.Alarm2GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SetHourTextBox;
        private System.Windows.Forms.TextBox SetMinTextBox;
        private System.Windows.Forms.Label SetHoursLabel;
        private System.Windows.Forms.Label SetMinLabel;
        private System.Windows.Forms.GroupBox ClockGroupBox;
        private System.Windows.Forms.Button SetTimeButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.GroupBox ButtonGroupBoxSetStop;
        private System.Windows.Forms.TextBox AlarmSetHoursTextBox;
        private System.Windows.Forms.TextBox AlarmSetMinTextBox;
        private System.Windows.Forms.Label AlarmSetHoursLabel;
        private System.Windows.Forms.Label AlarmSetMinLabel;
        private System.Windows.Forms.GroupBox Alarm1GroupBox;
        private System.Windows.Forms.Button AlarmSetButton;
        private System.Windows.Forms.GroupBox Alarm2GroupBox;
        private System.Windows.Forms.Button AlarmSetButton2;
        private System.Windows.Forms.Label AlarmSetMinLabel2;
        private System.Windows.Forms.Label AlarmSetHoursLabel2;
        private System.Windows.Forms.TextBox AlarmSetMinTextBox2;
        private System.Windows.Forms.TextBox AlarmSetHoursTextBox2;
        private System.Windows.Forms.Label ClockLabel;
    }
}

