using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialTest
{
    public partial class Form1 : Form
    {
      SerialPort serial_port = new SerialPort();
        // static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        //
        // Adds the event and the event handler for the method that will process the timer event to the timer.
        // myTimer.Tick += new EventHandler(Method goes in here);

        public Form1()
        {
            InitializeComponent();
            AvailablePorts();       //List Available Ports Under "Port" Drop Down Menu
        }

        //Function list all available COM ports to Drop-Down Menu for user to select
         void AvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            PortList.Items.AddRange(ports);
        }

        //Function: Disables all buttons except OpenPortButton, Preventing user from crashing program
        private void Form1_Load(object sender, EventArgs e)
        {
            ClosePortButton.Enabled = false;    //Disable Close Port Button
            ReadButton.Enabled = false;         //Disable Read Button
            StandbyButton.Enabled = false;      //Disable Standby Button
            CalibrateButton.Enabled = false;    //Disable Calibrate Button
        }
    
        //OpenPortButton
        //Function: Establishes Serial Communication once COM Port and Baud rate are selected
        private void OpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (PortList.Text == "" || BaudBox.Text == "")      // Check if Port and Baud Rate were set
                {
                    InputData.Text = "Select port and baud rate settings.";     // If settings were empty, display message in text window
                }
                else
                {
                    serial_port.PortName = PortList.Text;
                    serial_port.BaudRate = Convert.ToInt32(BaudBox.Text);
                    serial_port.Open();
                    OpenPortButton.Enabled = false;     //Disable Open Port Button
                    ClosePortButton.Enabled = true;     //Enable Close Port Button
                    ReadButton.Enabled = true;          //Enable Read Button
                    StandbyButton.Enabled = true;      //Enable Standby Button
                    CalibrateButton.Enabled = true;    //Enable Calibrate Button
                }
            }
            catch (Exception ex)
            {
                InputData.Text = "Invalid.";
            }
        }



        //ClosePortButton
        //Function: Closes serial communication, Disables all buttons except Open Port Button
        private void ClosePort_Click(object sender, EventArgs e)
        {
            serial_port.Close();
            OpenPortButton.Enabled = true;
            ReadButton.Enabled = false;
            ClosePortButton.Enabled = false;
            StandbyButton.Enabled = false;
            CalibrateButton.Enabled = false;
        }

        //ReadButton
        //Function: Reads Data being transmitted over serial communication
        private void ReadButton_Click(object sender, EventArgs e)
        {
            try
            {
                InputData.Text = serial_port.ReadExisting();
            }
            catch (TimeoutException)
            {
                InputData.Text = "Timeout Exception.";
            }
        }
    }
}
