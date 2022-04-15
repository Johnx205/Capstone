
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
            this.CommandLabel = new System.Windows.Forms.Label();
            this.InputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DtrEnable = true;
            this.serialPort1.RtsEnable = true;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // PortList
            // 
            this.PortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortList.FormattingEnabled = true;
            this.PortList.Location = new System.Drawing.Point(16, 55);
            this.PortList.Name = "PortList";
            this.PortList.Size = new System.Drawing.Size(121, 28);
            this.PortList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(13, 32);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(46, 20);
            this.PortLabel.TabIndex = 2;
            this.PortLabel.Text = "Ports";
            // 
            // BaudLabel
            // 
            this.BaudLabel.AutoSize = true;
            this.BaudLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudLabel.Location = new System.Drawing.Point(171, 32);
            this.BaudLabel.Name = "BaudLabel";
            this.BaudLabel.Size = new System.Drawing.Size(86, 20);
            this.BaudLabel.TabIndex = 3;
            this.BaudLabel.Text = "Baud Rate";
            // 
            // BaudBox
            // 
            this.BaudBox.Location = new System.Drawing.Point(176, 57);
            this.BaudBox.Name = "BaudBox";
            this.BaudBox.Size = new System.Drawing.Size(100, 26);
            this.BaudBox.TabIndex = 4;
            // 
            // OpenPortButton
            // 
            this.OpenPortButton.Location = new System.Drawing.Point(300, 52);
            this.OpenPortButton.Name = "OpenPortButton";
            this.OpenPortButton.Size = new System.Drawing.Size(112, 35);
            this.OpenPortButton.TabIndex = 5;
            this.OpenPortButton.Text = "Open Port";
            this.OpenPortButton.UseVisualStyleBackColor = true;
            this.OpenPortButton.Click += new System.EventHandler(this.OpenPort_Click);
            // 
            // ClosePortButton
            // 
            this.ClosePortButton.Enabled = false;
            this.ClosePortButton.Location = new System.Drawing.Point(300, 94);
            this.ClosePortButton.Name = "ClosePortButton";
            this.ClosePortButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ClosePortButton.Size = new System.Drawing.Size(112, 35);
            this.ClosePortButton.TabIndex = 6;
            this.ClosePortButton.Text = "Close Port";
            this.ClosePortButton.UseVisualStyleBackColor = true;
            this.ClosePortButton.Click += new System.EventHandler(this.ClosePort_Click);
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Controls.Add(this.ReadButton);
            this.InputGroupBox.Controls.Add(this.InputData);
            this.InputGroupBox.Location = new System.Drawing.Point(671, 60);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(286, 299);
            this.InputGroupBox.TabIndex = 7;
            this.InputGroupBox.TabStop = false;
            this.InputGroupBox.Text = "Received Data";
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(21, 232);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(87, 37);
            this.ReadButton.TabIndex = 1;
            this.ReadButton.Text = "Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // InputData
            // 
            this.InputData.Location = new System.Drawing.Point(21, 42);
            this.InputData.Multiline = true;
            this.InputData.Name = "InputData";
            this.InputData.ReadOnly = true;
            this.InputData.Size = new System.Drawing.Size(245, 159);
            this.InputData.TabIndex = 0;
            // 
            // StandbyButton
            // 
            this.StandbyButton.Location = new System.Drawing.Point(448, 94);
            this.StandbyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StandbyButton.Name = "StandbyButton";
            this.StandbyButton.Size = new System.Drawing.Size(112, 35);
            this.StandbyButton.TabIndex = 9;
            this.StandbyButton.Text = "Standby";
            this.StandbyButton.UseVisualStyleBackColor = true;
            // 
            // CalibrateButton
            // 
            this.CalibrateButton.Location = new System.Drawing.Point(448, 52);
            this.CalibrateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CalibrateButton.Name = "CalibrateButton";
            this.CalibrateButton.Size = new System.Drawing.Size(112, 35);
            this.CalibrateButton.TabIndex = 10;
            this.CalibrateButton.Text = "Calibrate";
            this.CalibrateButton.UseVisualStyleBackColor = true;
            // 
            // LEDStatusLabel
            // 
            this.LEDStatusLabel.AutoSize = true;
            this.LEDStatusLabel.Location = new System.Drawing.Point(444, 197);
            this.LEDStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LEDStatusLabel.Name = "LEDStatusLabel";
            this.LEDStatusLabel.Size = new System.Drawing.Size(92, 20);
            this.LEDStatusLabel.TabIndex = 11;
            this.LEDStatusLabel.Text = "LED Status";
            // 
            // RedLEDLabel
            // 
            this.RedLEDLabel.AutoSize = true;
            this.RedLEDLabel.Location = new System.Drawing.Point(375, 241);
            this.RedLEDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RedLEDLabel.Name = "RedLEDLabel";
            this.RedLEDLabel.Size = new System.Drawing.Size(83, 20);
            this.RedLEDLabel.TabIndex = 12;
            this.RedLEDLabel.Text = "Red LED :";
            // 
            // GreenLEDLabel
            // 
            this.GreenLEDLabel.AutoSize = true;
            this.GreenLEDLabel.Location = new System.Drawing.Point(375, 284);
            this.GreenLEDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GreenLEDLabel.Name = "GreenLEDLabel";
            this.GreenLEDLabel.Size = new System.Drawing.Size(98, 20);
            this.GreenLEDLabel.TabIndex = 13;
            this.GreenLEDLabel.Text = "Green LED :";
            // 
            // BlueLEDLabel
            // 
            this.BlueLEDLabel.AutoSize = true;
            this.BlueLEDLabel.Location = new System.Drawing.Point(375, 324);
            this.BlueLEDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BlueLEDLabel.Name = "BlueLEDLabel";
            this.BlueLEDLabel.Size = new System.Drawing.Size(89, 20);
            this.BlueLEDLabel.TabIndex = 14;
            this.BlueLEDLabel.Text = "Blue LED : ";
            // 
            // RedStatus
            // 
            this.RedStatus.Location = new System.Drawing.Point(494, 278);
            this.RedStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RedStatus.Name = "RedStatus";
            this.RedStatus.Size = new System.Drawing.Size(106, 26);
            this.RedStatus.TabIndex = 15;
            // 
            // GreenStatus
            // 
            this.GreenStatus.Location = new System.Drawing.Point(494, 317);
            this.GreenStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GreenStatus.Name = "GreenStatus";
            this.GreenStatus.Size = new System.Drawing.Size(106, 26);
            this.GreenStatus.TabIndex = 16;
            // 
            // BlueStatus
            // 
            this.BlueStatus.Location = new System.Drawing.Point(494, 237);
            this.BlueStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BlueStatus.Name = "BlueStatus";
            this.BlueStatus.Size = new System.Drawing.Size(106, 26);
            this.BlueStatus.TabIndex = 17;
            // 
            // C1Box
            // 
            this.C1Box.Location = new System.Drawing.Point(70, 237);
            this.C1Box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C1Box.Name = "C1Box";
            this.C1Box.Size = new System.Drawing.Size(100, 26);
            this.C1Box.TabIndex = 18;
            // 
            // C2Box
            // 
            this.C2Box.Location = new System.Drawing.Point(180, 237);
            this.C2Box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C2Box.Name = "C2Box";
            this.C2Box.Size = new System.Drawing.Size(100, 26);
            this.C2Box.TabIndex = 19;
            // 
            // C3Box
            // 
            this.C3Box.Location = new System.Drawing.Point(68, 278);
            this.C3Box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C3Box.Name = "C3Box";
            this.C3Box.Size = new System.Drawing.Size(102, 26);
            this.C3Box.TabIndex = 20;
            // 
            // C4Box
            // 
            this.C4Box.Location = new System.Drawing.Point(180, 278);
            this.C4Box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C4Box.Name = "C4Box";
            this.C4Box.Size = new System.Drawing.Size(100, 26);
            this.C4Box.TabIndex = 21;
            // 
            // C5Box
            // 
            this.C5Box.Location = new System.Drawing.Point(68, 318);
            this.C5Box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C5Box.Name = "C5Box";
            this.C5Box.Size = new System.Drawing.Size(102, 26);
            this.C5Box.TabIndex = 22;
            // 
            // C6Box
            // 
            this.C6Box.Location = new System.Drawing.Point(180, 318);
            this.C6Box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C6Box.Name = "C6Box";
            this.C6Box.Size = new System.Drawing.Size(100, 26);
            this.C6Box.TabIndex = 23;
            // 
            // ArrayLabel
            // 
            this.ArrayLabel.AutoSize = true;
            this.ArrayLabel.Location = new System.Drawing.Point(122, 197);
            this.ArrayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArrayLabel.Name = "ArrayLabel";
            this.ArrayLabel.Size = new System.Drawing.Size(105, 20);
            this.ArrayLabel.TabIndex = 24;
            this.ArrayLabel.Text = "Sensor Array ";
            // 
            // C1Label
            // 
            this.C1Label.AutoSize = true;
            this.C1Label.Location = new System.Drawing.Point(11, 241);
            this.C1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.C1Label.Name = "C1Label";
            this.C1Label.Size = new System.Drawing.Size(48, 20);
            this.C1Label.TabIndex = 25;
            this.C1Label.Text = "Cell 1";
            // 
            // C2Label
            // 
            this.C2Label.AutoSize = true;
            this.C2Label.Location = new System.Drawing.Point(298, 241);
            this.C2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.C2Label.Name = "C2Label";
            this.C2Label.Size = new System.Drawing.Size(48, 20);
            this.C2Label.TabIndex = 26;
            this.C2Label.Text = "Cell 2";
            // 
            // C3Label
            // 
            this.C3Label.AutoSize = true;
            this.C3Label.Location = new System.Drawing.Point(10, 283);
            this.C3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.C3Label.Name = "C3Label";
            this.C3Label.Size = new System.Drawing.Size(48, 20);
            this.C3Label.TabIndex = 27;
            this.C3Label.Text = "Cell 3";
            // 
            // C4Label
            // 
            this.C4Label.AutoSize = true;
            this.C4Label.Location = new System.Drawing.Point(298, 283);
            this.C4Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.C4Label.Name = "C4Label";
            this.C4Label.Size = new System.Drawing.Size(48, 20);
            this.C4Label.TabIndex = 28;
            this.C4Label.Text = "Cell 4";
            // 
            // C5Label
            // 
            this.C5Label.AutoSize = true;
            this.C5Label.Location = new System.Drawing.Point(10, 323);
            this.C5Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.C5Label.Name = "C5Label";
            this.C5Label.Size = new System.Drawing.Size(48, 20);
            this.C5Label.TabIndex = 29;
            this.C5Label.Text = "Cell 5";
            // 
            // C6Label
            // 
            this.C6Label.AutoSize = true;
            this.C6Label.Location = new System.Drawing.Point(298, 323);
            this.C6Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.C6Label.Name = "C6Label";
            this.C6Label.Size = new System.Drawing.Size(48, 20);
            this.C6Label.TabIndex = 30;
            this.C6Label.Text = "Cell 6";
            // 
            // CommandLabel
            // 
            this.CommandLabel.AutoSize = true;
            this.CommandLabel.Location = new System.Drawing.Point(446, 27);
            this.CommandLabel.Name = "CommandLabel";
            this.CommandLabel.Size = new System.Drawing.Size(90, 20);
            this.CommandLabel.TabIndex = 31;
            this.CommandLabel.Text = "Commands";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1284, 449);
            this.Controls.Add(this.CommandLabel);
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
            this.Controls.Add(this.InputGroupBox);
            this.Controls.Add(this.ClosePortButton);
            this.Controls.Add(this.OpenPortButton);
            this.Controls.Add(this.BaudBox);
            this.Controls.Add(this.BaudLabel);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.InputGroupBox.ResumeLayout(false);
            this.InputGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label CommandLabel;
    }
}

