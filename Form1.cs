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
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using System.Threading;

namespace GloveGUIVersion2
{
    public partial class Form1 : Form
    {
        public int offset;
        public int count;
        public int serialRead;
        public byte[] buffer;
        private delegate void SetTextDeleg(string text);
        static bool _continue;
        public Form1()
        {
            InitializeComponent();

            InitCharts(GloveDataChart1);
            InitCharts(GloveDataChart2);
            InitCharts(GloveDataChart3);
            InitCharts(GloveDataChart4);
            InitCharts(GloveDataChart5);
            InitCharts(GloveDataChart6);

            cbPorts.Items.Add("Ports not scanned");
            cbPorts.SelectedIndex = 0;

            initBaudRate(cbBaudRate);
        }
        private void initBaudRate(ComboBox box)
        {
            box.Items.Clear();
            box.Items.Add("9600");
            box.Items.Add("115200");
            box.SelectedIndex = 0;
            return;
        }
        private void InitCharts(Chart chart)
        {
            chart.Series.Clear();
            chart.Series.Add("X axis");
            chart.Series["X axis"].ChartType = SeriesChartType.Spline;
            chart.Series.Add("Y axis");
            chart.Series["Y axis"].ChartType = SeriesChartType.Spline;
            chart.Series.Add("Z axis");
            chart.Series["Z axis"].ChartType = SeriesChartType.Spline;
            return;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            CollectData(true);
        }
        private void CollectData(bool HasConnected)
        {
            Thread readThread = new Thread(Read);
            if (HasConnected)
            {
                if (cbPorts.Text != "" && cbBaudRate.Text != "" && cbPorts.Text != "Ports not scanned")
                {
                    serialPort1 = new SerialPort(cbPorts.Text,
                        Convert.ToInt32(cbBaudRate.Text),
                        Parity.None,
                        8,
                        StopBits.One);
                    serialPort1.Handshake = Handshake.None;
                    serialPort1.ReadTimeout = 500;
                    serialPort1.WriteTimeout = 500;
                }
                else
                {
                    MessageBox.Show("No selection has been made for port or baud rate");
                }
                try
                {
                    if (serialPort1.IsOpen == false)
                    {
                        serialPort1.Open();
                    }
                    _continue = true;
                    readThread.Start();
                    serialPort1.Close();
                }
                catch (Exception ex)
                {
                    String message = String.Format("Port {0} failed to open ERROR: {1}", cbPorts.Text, ex);
                    MessageBox.Show(message);
                }
            }
        }
        private void btnScanPort_Click(object sender, EventArgs e)
        {
            cbPorts.Items.Clear();
            List<String> portList = new List<String>();
            foreach (string s in SerialPort.GetPortNames())
            {
                portList.Add(s);
            }
            portList.Sort();
            cbPorts.Items.Add("Select COM port...");
            cbPorts.Items.AddRange(portList.ToArray());
            cbPorts.SelectedIndex = 0;
        }
    }
}
