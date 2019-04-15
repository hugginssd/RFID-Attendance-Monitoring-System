using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.DAL
{
    class ScanInOut
    {
        SerialPort serialPort = new SerialPort();
        public ScanInOut()
        {
        serialPort.BaudRate = 9600;
        serialPort.PortName = "COM5";
        serialPort.Open();
        serialPort.DataReceived += serialPort_DataReceived;
        }
       
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = serialPort.ReadLine();
            //this.BeginInvoke(new LineReceivedEvent(LineReceived), line);
        }

        private delegate void LineReceivedEvent(string line);

        private void LineReceived(string text ,string line)
        {
            text = line + "In";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen) serialPort.Close();
        }

        private void serialPort1_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            serialPort.Close();
        }
    }
}

