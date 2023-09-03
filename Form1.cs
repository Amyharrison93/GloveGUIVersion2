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
        private SerialHandler listener;
        private int tick = 0;

        private string dataBuffer;


        private static readonly int MAXIMUM_TICKS = 100;

        public Form1()
        {
            InitializeComponent();

            InitAllCharts();

            cbPorts.Items.Add("Ports not scanned");
            cbPorts.SelectedIndex = 0;

            initBaudRate(cbBaudRate);
            btnScanPort_Click(null, null);
        }
        private void initBaudRate(ComboBox box)
        {
            box.Items.Clear();
            box.Items.Add("9600");
            box.Items.Add("115200");
            box.SelectedIndex = 1;
            return;
        }

        private void InitAllCharts()
        {
            InitCharts(GloveDataChart1);
            InitCharts(GloveDataChart2);
            InitCharts(GloveDataChart3);
            InitCharts(GloveDataChart4);
            InitCharts(GloveDataChart5);
            InitCharts(GloveDataChart6);
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
            string portName = cbPorts.Text;
            int baudRate = int.Parse(cbBaudRate.Text);
            listener = new SerialHandler(portName, baudRate);
            listener.DataRecieved += onSerialDataGet;
            listener.Listen();
        }

        private void onSerialDataGet(object sender, string data)
        {
            dataBuffer += data;
            string[] lines = dataBuffer.Split('\n');

            if (lines.Length < 3)
            {
                return;
            }
            string[] points = lines[1].Split(',');

            this.BeginInvoke(new InvokeDelegate(() =>
            {

                if (tick % 2 == 0)
                {
                    setChartData(GloveDataChart1, float.Parse(points[0]), float.Parse(points[1]), float.Parse(points[2]));
                    setChartData(GloveDataChart2, float.Parse(points[4]), float.Parse(points[5]), float.Parse(points[6]));
                    setChartData(GloveDataChart3, float.Parse(points[8]), float.Parse(points[9]), float.Parse(points[10]));
                }
                else
                {
                    setChartData(GloveDataChart4, float.Parse(points[12]), float.Parse(points[13]), float.Parse(points[14]));
                    setChartData(GloveDataChart5, float.Parse(points[16]), float.Parse(points[17]), float.Parse(points[18]));
                    setChartData(GloveDataChart6, float.Parse(points[20]), float.Parse(points[21]), float.Parse(points[22]));
                }

            }));
            tick++;
            dataBuffer = "";

        }

        private delegate void InvokeDelegate();
        private void setChartData(Chart chart, float x, float y, float z)
        {
            chart.Series["X axis"].Points.AddXY(tick, x);
            chart.Series["Y axis"].Points.AddXY(tick, y);
            chart.Series["Z axis"].Points.AddXY(tick, z);
            if (tick > MAXIMUM_TICKS) {
                chart.Series["X axis"].Points.RemoveAt(0);
                chart.Series["Y axis"].Points.RemoveAt(0);
                chart.Series["Z axis"].Points.RemoveAt(0);
                chart.ChartAreas[0].RecalculateAxesScale();

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
            cbPorts.SelectedIndex = portList.Count;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            listener.Close();
            listener.DataRecieved -= onSerialDataGet;
        }
    }
}
