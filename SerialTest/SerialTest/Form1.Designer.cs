
namespace SerialTest
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.PortList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.BaudLabel = new System.Windows.Forms.Label();
            this.BaudBox = new System.Windows.Forms.TextBox();
            this.OpenPortButton = new System.Windows.Forms.Button();
            this.ClosePortButton = new System.Windows.Forms.Button();
            this.InputGroupBox = new System.Windows.Forms.GroupBox();
            this.ReadButton = new System.Windows.Forms.Button();
            this.InputData = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.StandbyButton = new System.Windows.Forms.Button();
            this.CalibrateButton = new System.Windows.Forms.Button();
            this.LEDStatusLabel = new System.Windows.Forms.Label();
            this.RedLEDLabel = new System.Windows.Forms.Label();
            this.GreenLEDLabel = new System.Windows.Forms.Label();
            this.BlueLEDLabel = new System.Windows.Forms.Label();
            this.RedStatus = new System.Windows.Forms.TextBox();
            this.GreenStatus = new System.Windows.Forms.TextBox();
            this.BlueStatus = new System.Windows.Forms.TextBox();
            this.C1Box = new System.Windows.Forms.TextBox();
            this.C2Box = new System.Windows.Forms.TextBox();
            this.C3Box = new System.Windows.Forms.TextBox();
            this.C4Box = new System.Windows.Forms.TextBox();
            this.C5Box = new System.Windows.Forms.TextBox();
            this.C6Box = new System.Windows.Forms.TextBox();
            this.ArrayLabel = new System.Windows.Forms.Label();
            this.C1Label = new System.Windows.Forms.Label();
            this.C2Label = new System.Windows.Forms.Label();
            this.C3Label = new System.Windows.Forms.Label();
            this.C4Label = new System.Windows.Forms.Label();
            this.C5Label = new System.Windows.Forms.Label();
            this.C6Label = new System.Windows.Forms.Label();
            this.InputGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(799, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 78);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PortList
            // 
            this.PortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortList.FormattingEnabled = true;
            this.PortList.Location = new System.Drawing.Point(11, 36);
            this.PortList.Margin = new System.Windows.Forms.Padding(2);
            this.PortList.Name = "PortList";
            this.PortList.Size = new System.Drawing.Size(82, 21);
            this.PortList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(8, 21);
            this.PortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(31, 13);
            this.PortLabel.TabIndex = 2;
            this.PortLabel.Text = "Ports";
            // 
            // BaudLabel
            // 
            this.BaudLabel.AutoSize = true;
            this.BaudLabel.Location = new System.Drawing.Point(114, 21);
            this.BaudLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BaudLabel.Name = "BaudLabel";
            this.BaudLabel.Size = new System.Drawing.Size(58, 13);
            this.BaudLabel.TabIndex = 3;
            this.BaudLabel.Text = "Baud Rate";
            // 
            // BaudBox
            // 
            this.BaudBox.Location = new System.Drawing.Point(117, 37);
            this.BaudBox.Margin = new System.Windows.Forms.Padding(2);
            this.BaudBox.Name = "BaudBox";
            this.BaudBox.Size = new System.Drawing.Size(68, 20);
            this.BaudBox.TabIndex = 4;
            // 
            // OpenPortButton
            // 
            this.OpenPortButton.Location = new System.Drawing.Point(200, 34);
            this.OpenPortButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenPortButton.Name = "OpenPortButton";
            this.OpenPortButton.Size = new System.Drawing.Size(75, 23);
            this.OpenPortButton.TabIndex = 5;
            this.OpenPortButton.Text = "Open Port";
            this.OpenPortButton.UseVisualStyleBackColor = true;
            this.OpenPortButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClosePortButton
            // 
            this.ClosePortButton.Enabled = false;
            this.ClosePortButton.Location = new System.Drawing.Point(200, 61);
            this.ClosePortButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClosePortButton.Name = "ClosePortButton";
            this.ClosePortButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ClosePortButton.Size = new System.Drawing.Size(75, 23);
            this.ClosePortButton.TabIndex = 6;
            this.ClosePortButton.Text = "Close Port";
            this.ClosePortButton.UseVisualStyleBackColor = true;
            this.ClosePortButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Controls.Add(this.ReadButton);
            this.InputGroupBox.Controls.Add(this.InputData);
            this.InputGroupBox.Location = new System.Drawing.Point(479, 37);
            this.InputGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.InputGroupBox.Size = new System.Drawing.Size(155, 193);
            this.InputGroupBox.TabIndex = 7;
            this.InputGroupBox.TabStop = false;
            this.InputGroupBox.Text = "Data Read";
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(14, 151);
            this.ReadButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(58, 24);
            this.ReadButton.TabIndex = 1;
            this.ReadButton.Text = "Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // InputData
            // 
            this.InputData.Location = new System.Drawing.Point(14, 27);
            this.InputData.Margin = new System.Windows.Forms.Padding(2);
            this.InputData.Multiline = true;
            this.InputData.Name = "InputData";
            this.InputData.Size = new System.Drawing.Size(132, 105);
            this.InputData.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(640, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(155, 193);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 151);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 24);
            this.button4.TabIndex = 1;
            this.button4.Text = "Send";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(14, 27);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 105);
            this.textBox4.TabIndex = 0;
            // 
            // StandbyButton
            // 
            this.StandbyButton.Location = new System.Drawing.Point(382, 125);
            this.StandbyButton.Name = "StandbyButton";
            this.StandbyButton.Size = new System.Drawing.Size(75, 23);
            this.StandbyButton.TabIndex = 9;
            this.StandbyButton.Text = "Standby";
            this.StandbyButton.UseVisualStyleBackColor = true;
            // 
            // CalibrateButton
            // 
            this.CalibrateButton.Location = new System.Drawing.Point(301, 125);
            this.CalibrateButton.Name = "CalibrateButton";
            this.CalibrateButton.Size = new System.Drawing.Size(75, 23);
            this.CalibrateButton.TabIndex = 10;
            this.CalibrateButton.Text = "Calibrate";
            this.CalibrateButton.UseVisualStyleBackColor = true;
            // 
            // LEDStatusLabel
            // 
            this.LEDStatusLabel.AutoSize = true;
            this.LEDStatusLabel.Location = new System.Drawing.Point(346, 21);
            this.LEDStatusLabel.Name = "LEDStatusLabel";
            this.LEDStatusLabel.Size = new System.Drawing.Size(61, 13);
            this.LEDStatusLabel.TabIndex = 11;
            this.LEDStatusLabel.Text = "LED Status";
            this.LEDStatusLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // RedLEDLabel
            // 
            this.RedLEDLabel.AutoSize = true;
            this.RedLEDLabel.Location = new System.Drawing.Point(304, 44);
            this.RedLEDLabel.Name = "RedLEDLabel";
            this.RedLEDLabel.Size = new System.Drawing.Size(57, 13);
            this.RedLEDLabel.TabIndex = 12;
            this.RedLEDLabel.Text = "Red LED :";
            // 
            // GreenLEDLabel
            // 
            this.GreenLEDLabel.AutoSize = true;
            this.GreenLEDLabel.Location = new System.Drawing.Point(304, 71);
            this.GreenLEDLabel.Name = "GreenLEDLabel";
            this.GreenLEDLabel.Size = new System.Drawing.Size(66, 13);
            this.GreenLEDLabel.TabIndex = 13;
            this.GreenLEDLabel.Text = "Green LED :";
            // 
            // BlueLEDLabel
            // 
            this.BlueLEDLabel.AutoSize = true;
            this.BlueLEDLabel.Location = new System.Drawing.Point(304, 96);
            this.BlueLEDLabel.Name = "BlueLEDLabel";
            this.BlueLEDLabel.Size = new System.Drawing.Size(61, 13);
            this.BlueLEDLabel.TabIndex = 14;
            this.BlueLEDLabel.Text = "Blue LED : ";
            // 
            // RedStatus
            // 
            this.RedStatus.Location = new System.Drawing.Point(378, 67);
            this.RedStatus.Name = "RedStatus";
            this.RedStatus.Size = new System.Drawing.Size(72, 20);
            this.RedStatus.TabIndex = 15;
            // 
            // GreenStatus
            // 
            this.GreenStatus.Location = new System.Drawing.Point(378, 93);
            this.GreenStatus.Name = "GreenStatus";
            this.GreenStatus.Size = new System.Drawing.Size(72, 20);
            this.GreenStatus.TabIndex = 16;
            // 
            // BlueStatus
            // 
            this.BlueStatus.Location = new System.Drawing.Point(378, 41);
            this.BlueStatus.Name = "BlueStatus";
            this.BlueStatus.Size = new System.Drawing.Size(72, 20);
            this.BlueStatus.TabIndex = 17;
            // 
            // C1Box
            // 
            this.C1Box.Location = new System.Drawing.Point(45, 122);
            this.C1Box.Name = "C1Box";
            this.C1Box.Size = new System.Drawing.Size(68, 20);
            this.C1Box.TabIndex = 18;
            // 
            // C2Box
            // 
            this.C2Box.Location = new System.Drawing.Point(119, 122);
            this.C2Box.Name = "C2Box";
            this.C2Box.Size = new System.Drawing.Size(68, 20);
            this.C2Box.TabIndex = 19;
            // 
            // C3Box
            // 
            this.C3Box.Location = new System.Drawing.Point(44, 149);
            this.C3Box.Name = "C3Box";
            this.C3Box.Size = new System.Drawing.Size(69, 20);
            this.C3Box.TabIndex = 20;
            // 
            // C4Box
            // 
            this.C4Box.Location = new System.Drawing.Point(119, 149);
            this.C4Box.Name = "C4Box";
            this.C4Box.Size = new System.Drawing.Size(68, 20);
            this.C4Box.TabIndex = 21;
            // 
            // C5Box
            // 
            this.C5Box.Location = new System.Drawing.Point(44, 175);
            this.C5Box.Name = "C5Box";
            this.C5Box.Size = new System.Drawing.Size(69, 20);
            this.C5Box.TabIndex = 22;
            // 
            // C6Box
            // 
            this.C6Box.Location = new System.Drawing.Point(119, 175);
            this.C6Box.Name = "C6Box";
            this.C6Box.Size = new System.Drawing.Size(68, 20);
            this.C6Box.TabIndex = 23;
            // 
            // ArrayLabel
            // 
            this.ArrayLabel.AutoSize = true;
            this.ArrayLabel.Location = new System.Drawing.Point(80, 96);
            this.ArrayLabel.Name = "ArrayLabel";
            this.ArrayLabel.Size = new System.Drawing.Size(70, 13);
            this.ArrayLabel.TabIndex = 24;
            this.ArrayLabel.Text = "Sensor Array ";
            // 
            // C1Label
            // 
            this.C1Label.AutoSize = true;
            this.C1Label.Location = new System.Drawing.Point(6, 125);
            this.C1Label.Name = "C1Label";
            this.C1Label.Size = new System.Drawing.Size(33, 13);
            this.C1Label.TabIndex = 25;
            this.C1Label.Text = "Cell 1";
            // 
            // C2Label
            // 
            this.C2Label.AutoSize = true;
            this.C2Label.Location = new System.Drawing.Point(197, 125);
            this.C2Label.Name = "C2Label";
            this.C2Label.Size = new System.Drawing.Size(33, 13);
            this.C2Label.TabIndex = 26;
            this.C2Label.Text = "Cell 2";
            // 
            // C3Label
            // 
            this.C3Label.AutoSize = true;
            this.C3Label.Location = new System.Drawing.Point(5, 152);
            this.C3Label.Name = "C3Label";
            this.C3Label.Size = new System.Drawing.Size(33, 13);
            this.C3Label.TabIndex = 27;
            this.C3Label.Text = "Cell 3";
            // 
            // C4Label
            // 
            this.C4Label.AutoSize = true;
            this.C4Label.Location = new System.Drawing.Point(197, 152);
            this.C4Label.Name = "C4Label";
            this.C4Label.Size = new System.Drawing.Size(33, 13);
            this.C4Label.TabIndex = 28;
            this.C4Label.Text = "Cell 4";
            // 
            // C5Label
            // 
            this.C5Label.AutoSize = true;
            this.C5Label.Location = new System.Drawing.Point(5, 178);
            this.C5Label.Name = "C5Label";
            this.C5Label.Size = new System.Drawing.Size(33, 13);
            this.C5Label.TabIndex = 29;
            this.C5Label.Text = "Cell 5";
            // 
            // C6Label
            // 
            this.C6Label.AutoSize = true;
            this.C6Label.Location = new System.Drawing.Point(197, 178);
            this.C6Label.Name = "C6Label";
            this.C6Label.Size = new System.Drawing.Size(33, 13);
            this.C6Label.TabIndex = 30;
            this.C6Label.Text = "Cell 6";
            this.C6Label.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(856, 292);
            this.Controls.Add(this.C6Label);
            this.Controls.Add(this.C5Label);
            this.Controls.Add(this.C4Label);
            this.Controls.Add(this.C3Label);
            this.Controls.Add(this.C2Label);
            this.Controls.Add(this.C1Label);
            this.Controls.Add(this.ArrayLabel);
            this.Controls.Add(this.C6Box);
            this.Controls.Add(this.C5Box);
            this.Controls.Add(this.C4Box);
            this.Controls.Add(this.C3Box);
            this.Controls.Add(this.C2Box);
            this.Controls.Add(this.C1Box);
            this.Controls.Add(this.BlueStatus);
            this.Controls.Add(this.GreenStatus);
            this.Controls.Add(this.RedStatus);
            this.Controls.Add(this.BlueLEDLabel);
            this.Controls.Add(this.GreenLEDLabel);
            this.Controls.Add(this.RedLEDLabel);
            this.Controls.Add(this.LEDStatusLabel);
            this.Controls.Add(this.CalibrateButton);
            this.Controls.Add(this.StandbyButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.InputGroupBox);
            this.Controls.Add(this.ClosePortButton);
            this.Controls.Add(this.OpenPortButton);
            this.Controls.Add(this.BaudBox);
            this.Controls.Add(this.BaudLabel);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortList);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.InputGroupBox.ResumeLayout(false);
            this.InputGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox PortList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label BaudLabel;
        private System.Windows.Forms.TextBox BaudBox;
        private System.Windows.Forms.Button OpenPortButton;
        private System.Windows.Forms.Button ClosePortButton;
        private System.Windows.Forms.GroupBox InputGroupBox;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.TextBox InputData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button StandbyButton;
        private System.Windows.Forms.Button CalibrateButton;
        private System.Windows.Forms.Label LEDStatusLabel;
        private System.Windows.Forms.Label RedLEDLabel;
        private System.Windows.Forms.Label GreenLEDLabel;
        private System.Windows.Forms.Label BlueLEDLabel;
        private System.Windows.Forms.TextBox RedStatus;
        private System.Windows.Forms.TextBox GreenStatus;
        private System.Windows.Forms.TextBox BlueStatus;
        private System.Windows.Forms.TextBox C1Box;
        private System.Windows.Forms.TextBox C2Box;
        private System.Windows.Forms.TextBox C3Box;
        private System.Windows.Forms.TextBox C4Box;
        private System.Windows.Forms.TextBox C5Box;
        private System.Windows.Forms.TextBox C6Box;
        private System.Windows.Forms.Label ArrayLabel;
        private System.Windows.Forms.Label C1Label;
        private System.Windows.Forms.Label C2Label;
        private System.Windows.Forms.Label C3Label;
        private System.Windows.Forms.Label C4Label;
        private System.Windows.Forms.Label C5Label;
        private System.Windows.Forms.Label C6Label;
    }
}

