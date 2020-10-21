using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPortTestSender
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			string[] ports = SerialPort.GetPortNames();
			foreach(string portName in ports)
			{
				MessageBox.Show(portName);
			}

			if(ports.Length > 0)
			{
				string portName = txtPortName.Text;
				if (CheckPortName(ports, portName))
				{
					using (SerialPort openPort = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One))
					{
						openPort.Handshake = Handshake.None;
						openPort.Open();

						openPort.Write("ABC");

						openPort.Close();
					}
				}
			}
		}

		bool CheckPortName(string[] portNames, string value)
		{
			for(int i = 0; i < portNames.Length; i++)
			{
				if (portNames[i].Contains(value))
					return true;
			}

			return false;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}

