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

         void AvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            PortList.Items.AddRange(ports);
        }

        //OpenPortButton
        private void button1_Click(object sender, EventArgs e)
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
                    OpenPortButton.Enabled = false;        // Disable Open Port Button
                    ClosePortButton.Enabled = true;         // Enable Close Port
                   //button4.Enabled = true;         // Enable Send Button 
                    ReadButton.Enabled = true;         // Enable Read Button
                                           
                }
            }
            catch (Exception ex)
            {
                InputData.Text = "Invalid.";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            using (SerialPort serialport = new SerialPort("COM6", 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One))
            {
                serialport.Open();
                string test = serialport.ReadExisting();
                textBox1.Text = test;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Notes :
            // This function gets called when the contents of the text box
            // Changes between "posts" to the "server"
            // In our case this method gets triggered when TextBox1 is changed
            try
              {
        
              }
            catch { Exception ex; }
           
        }

       
        //ClosePortButton
        private void button2_Click(object sender, EventArgs e)
        {
            serial_port.Close();
            button4.Enabled = false;
            ReadButton.Enabled = false;
            OpenPortButton.Enabled = true;
            ClosePortButton.Enabled = false;
        }

        //ReadButton
        private void button3_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
