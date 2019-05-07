using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Management_System.BLL;
using Attendance_Management_System.DAL;

namespace Attendance_Management_System.UI
{
    public partial class UserAttendance : UserControl
    {
        public UserAttendance()
        {
            InitializeComponent();

            try
            {
                serialPort1.BaudRate = 9600;
                serialPort1.PortName = "COM1";
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Open();
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.ToString(), "Failed To Open Communication Port", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }
       //AttendanceDAL adal = new AttendanceDAL();
        //AttendanceBLL abll = new AttendanceBLL();
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = serialPort1.ReadLine();
            string spdata =  serialPort1.ReadExisting();
            Console.WriteLine(spdata);
            //scan in scan out
            //DataTable dt = new DataTable();
            //dt = adal.ScanIn(spdata.ToString());
            //dataGridView1.DataSource = dt;

        }

        private delegate void LineReceivedEvent(string line);

        private void LineReceived(string text, string line)
        {
            text = line + "In";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void serialPort1_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            serialPort1.Close();
        }
        

        private void BtnBulkActions_Click(object sender, EventArgs e)
        {
            BtnBulkActions.ForeColor = Color.White;
            BtnBulkActions.BackColor = Color.FromArgb(0, 122, 204);
            BtnCheckedIn.ForeColor = Color.Gray;
            BtnCheckedIn.BackColor = Color.White;
            BtnCheckedOut.ForeColor = Color.Gray;
            BtnCheckedOut.BackColor = Color.White;
            BtnUnConfirmed.ForeColor = Color.Gray;
            BtnUnConfirmed.BackColor = Color.White;
            BtnAbsent.ForeColor = Color.Gray;
            BtnAbsent.BackColor = Color.White;
        }

        private void BtnAbsent_Click(object sender, EventArgs e)
        {
            BtnAbsent.ForeColor = Color.White;
            BtnAbsent.BackColor = Color.FromArgb(0, 122, 204);
            BtnBulkActions.ForeColor = Color.Gray;
            BtnBulkActions.BackColor = Color.White;
            BtnCheckedOut.ForeColor = Color.Gray;
            BtnCheckedOut.BackColor = Color.White;
            BtnCheckedIn.ForeColor = Color.Gray;
            BtnCheckedIn.BackColor = Color.White;
            BtnUnConfirmed.ForeColor = Color.Gray;
            BtnUnConfirmed.BackColor = Color.White;
        }

        private void BtnCheckedOut_Click(object sender, EventArgs e)
        {
            BtnCheckedOut.ForeColor = Color.White;
            BtnCheckedOut.BackColor = Color.FromArgb(0, 122, 204);
            BtnAbsent.ForeColor = Color.Gray;
            BtnAbsent.BackColor = Color.White;
            BtnBulkActions.ForeColor = Color.Gray;
            BtnBulkActions.BackColor = Color.White;
            BtnCheckedIn.ForeColor = Color.Gray;
            BtnCheckedIn.BackColor = Color.White;
            BtnUnConfirmed.ForeColor = Color.Gray;
            BtnUnConfirmed.BackColor = Color.White;
        }

        private void BtnCheckedIn_Click(object sender, EventArgs e)
        {

            BtnCheckedIn.ForeColor = Color.White;
            BtnCheckedIn.BackColor = Color.FromArgb(0, 122, 204);
            BtnUnConfirmed.ForeColor = Color.Gray;
            BtnUnConfirmed.BackColor = Color.White;
            BtnCheckedOut.ForeColor = Color.Gray;
            BtnCheckedOut.BackColor = Color.White;
            BtnBulkActions.ForeColor = Color.Gray;
            BtnBulkActions.BackColor = Color.White;
            BtnAbsent.ForeColor = Color.Gray;
            BtnAbsent.BackColor = Color.White;
        }

        private void BtnUnConfirmed_Click(object sender, EventArgs e)
        {
            BtnUnConfirmed.ForeColor = Color.White;
            BtnUnConfirmed.BackColor = Color.FromArgb(0, 122, 204);
            BtnCheckedIn.ForeColor = Color.Gray;
            BtnCheckedIn.BackColor = Color.White;
            BtnCheckedOut.ForeColor = Color.Gray;
            BtnCheckedOut.BackColor = Color.White;
            BtnBulkActions.ForeColor = Color.Gray;
            BtnBulkActions.BackColor = Color.White;
            BtnAbsent.ForeColor = Color.Gray;
            BtnAbsent.BackColor = Color.White;
        }
    }
}

//using System;
//using System.IO.Ports;

//class PortDataReceived
//{
//    public static void Main()
//    {
//        SerialPort mySerialPort = new SerialPort("COM1");

//        mySerialPort.BaudRate = 9600;
//        mySerialPort.Parity = Parity.None;
//        mySerialPort.StopBits = StopBits.One;
//        mySerialPort.DataBits = 8;
//        mySerialPort.Handshake = Handshake.None;
//        mySerialPort.RtsEnable = true;

//        mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

//        mySerialPort.Open();

//        Console.WriteLine("Press any key to continue...");
//        Console.WriteLine();
//        Console.ReadKey();
//        mySerialPort.Close();
//    }

//    private static void DataReceivedHandler(
//        object sender,
//        SerialDataReceivedEventArgs e)
//    {
//        SerialPort sp = (SerialPort)sender;
//        string indata = sp.ReadExisting();
//        Console.WriteLine("Data Received:");
//        Console.Write(indata);
//    }
//}
