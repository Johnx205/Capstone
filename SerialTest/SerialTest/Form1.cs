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
        string DataIn;
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
                    ClosePortButton.Enabled = true;     //Enable Close Port Button
                    ReadButton.Enabled = true;          //Enable Read Button
                    StandbyButton.Enabled = true;      //Enable Standby Button
                    CalibrateButton.Enabled = true;    //Enable Calibrate Button
                    OpenPortButton.Enabled = false;     //Disable Open Port Button
                    serial_port.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
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

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            DataIn = serial_port.ReadLine();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            InputData.Text = DataIn;
            var parsedData = Parse_LED_Status(DataIn);
            if (true)
            {
                Update_UI(parsedData.r, parsedData.g, parsedData.b, parsedData.d); 
            }

        }

        private (double r, double g, double b, int d, bool has_error) Parse_LED_Status(string DataIn)
        {
            var splitString = DataIn.Split(' ');
            // I have assumed that this will always split into 4 values
            // Just because you print 4 does not mean 4 are received.
            // Transmission errors can cause received data not to match transmitted data

            // do a check for 4 received values

            // You may need a string.Trim to remove any extra whitespace

            // below assumes all values will be able to be parsed.
            // again, transmission errors could cause this to fail.
            // use double.TryParse (same for int.TryParse
            var r_success = double.TryParse(splitString[0], out double r);
            var g_success = double.TryParse(splitString[1], out double g);
            var b_success = double.TryParse(splitString[2], out double b);
            var determination_success = int.TryParse(splitString[3], out int determination);
            bool has_error = r_success || g_success || b_success || determination_success;

            // pass the parsed values to whoever needs them.
            return (r, g, b, determination, has_error);

        }

        private void BlueStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private enum ColorDetermination
        {
            None = 0,
            Red = 1,
            Green = 2,
            Blue = 3
        }

        public void Update_UI(double r, double g, double b, int determination)
        {
            BlueStatus.Text = "off";
            RedStatus.Text = "off";
            GreenStatus.Text = "off";

            switch ((ColorDetermination)determination)
            {
                case ColorDetermination.None:
                    break;
                case ColorDetermination.Red:
                    RedStatus.Text = "ON";
                    break;
                case ColorDetermination.Green:
                    GreenStatus.Text = "ON";
                    break;
                case ColorDetermination.Blue:
                    BlueStatus.Text = "ON";
                    break;
                default:
                    break;
            }
        }

        private void RedStatus_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
