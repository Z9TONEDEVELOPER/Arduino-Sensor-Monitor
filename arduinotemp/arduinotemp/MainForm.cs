/*
 * Created by SharpDevelop.
 * User: Z9TOWNERDEVELOPER
 * Date: 02.05.2025
 * Time: 15:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace arduinotemp
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private SerialPort serialPort1;
		private bool isConnected = false;
		public MainForm()
		{
			
			InitializeComponent();
			serialPort1 = new SerialPort();
			serialPort1.PortName = "COM4"; // по умолчанию
            serialPort1.BaudRate = 9600;
            serialPort1.Parity = Parity.None;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = StopBits.One;
            serialPort1.ReadTimeout = 500;
            serialPort1.WriteTimeout = 500;
            serialPort1.DataReceived += serialPort1_DataReceived;

            LoadPorts();
		}
		private void LoadPorts()
        {
            comboBoxPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length > 0)
            {
                comboBoxPorts.Items.AddRange(ports);
                comboBoxPorts.SelectedIndex = 0;
            }
        }
		private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                try
                {
                    serialPort1.PortName = comboBoxPorts.SelectedItem.ToString();
                    serialPort1.Open();
                    buttonConnect.Text = "Отключиться";
                    isConnected = true;
                    AppendLog("Подключено к " + serialPort1.PortName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения: " + ex.Message);
                }
            }
            else
            {
                serialPort1.Close();
                buttonConnect.Text = "Подключиться";
                isConnected = false;
                AppendLog("Отключено");
            }
        }
		private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort1.ReadExisting();
            this.Invoke((MethodInvoker)delegate {
                ProcessData(data);
            });
        }
		private void ProcessData(string data)
        {
            string[] parts = data.Split(new char[] { '\t', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length >= 3)
            {
                textBoxTemp.Text = parts[0];
                textBoxHumid.Text = parts[1];
                textBoxLight.Text = parts[2];

                AppendLog(parts[0] + " | " + parts[1] + " | " + parts[2]);
            }
        }
		private void AppendLog(string text)
        {
            if (richTextBoxLog.InvokeRequired)
            {
                richTextBoxLog.Invoke(new Action<string>(AppendLog), new object[] { text });
                return;
            }

            richTextBoxLog.AppendText("[" + DateTime.Now.ToLongTimeString() + "] " + text + "\n");
    		richTextBoxLog.ScrollToCaret(); // Автопрокрутка
        }
		
	}
}
