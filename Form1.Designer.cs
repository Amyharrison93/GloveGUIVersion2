namespace GloveGUIVersion2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.GloveDataChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GloveDataChart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GloveDataChart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GloveDataChart6 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GloveDataChart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GloveDataChart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.labPort = new System.Windows.Forms.Label();
            this.labBaud = new System.Windows.Forms.Label();
            this.tabMainPage = new System.Windows.Forms.TabControl();
            this.tabGraphView = new System.Windows.Forms.TabPage();
            this.tabRawDataView = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtRawData = new System.Windows.Forms.TextBox();
            this.labConnectStatus = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnScanPort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GloveDataChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GloveDataChart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GloveDataChart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GloveDataChart6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GloveDataChart5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GloveDataChart4)).BeginInit();
            this.tabMainPage.SuspendLayout();
            this.tabGraphView.SuspendLayout();
            this.tabRawDataView.SuspendLayout();
            this.SuspendLayout();
            // 
            // GloveDataChart1
            // 
            chartArea1.Name = "ChartArea1";
            this.GloveDataChart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GloveDataChart1.Legends.Add(legend1);
            this.GloveDataChart1.Location = new System.Drawing.Point(6, 6);
            this.GloveDataChart1.Name = "GloveDataChart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GloveDataChart1.Series.Add(series1);
            this.GloveDataChart1.Size = new System.Drawing.Size(300, 212);
            this.GloveDataChart1.TabIndex = 0;
            this.GloveDataChart1.Text = "GloveDataChart";
            // 
            // GloveDataChart2
            // 
            chartArea2.Name = "ChartArea1";
            this.GloveDataChart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GloveDataChart2.Legends.Add(legend2);
            this.GloveDataChart2.Location = new System.Drawing.Point(312, 6);
            this.GloveDataChart2.Name = "GloveDataChart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.GloveDataChart2.Series.Add(series2);
            this.GloveDataChart2.Size = new System.Drawing.Size(300, 212);
            this.GloveDataChart2.TabIndex = 1;
            this.GloveDataChart2.Text = "GloveDataChart";
            // 
            // GloveDataChart3
            // 
            chartArea3.Name = "ChartArea1";
            this.GloveDataChart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.GloveDataChart3.Legends.Add(legend3);
            this.GloveDataChart3.Location = new System.Drawing.Point(618, 6);
            this.GloveDataChart3.Name = "GloveDataChart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.GloveDataChart3.Series.Add(series3);
            this.GloveDataChart3.Size = new System.Drawing.Size(300, 212);
            this.GloveDataChart3.TabIndex = 2;
            this.GloveDataChart3.Text = "GloveDataChart";
            // 
            // GloveDataChart6
            // 
            chartArea4.Name = "ChartArea1";
            this.GloveDataChart6.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.GloveDataChart6.Legends.Add(legend4);
            this.GloveDataChart6.Location = new System.Drawing.Point(618, 252);
            this.GloveDataChart6.Name = "GloveDataChart6";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.GloveDataChart6.Series.Add(series4);
            this.GloveDataChart6.Size = new System.Drawing.Size(300, 212);
            this.GloveDataChart6.TabIndex = 5;
            this.GloveDataChart6.Text = "GloveDataChart";
            // 
            // GloveDataChart5
            // 
            chartArea5.Name = "ChartArea1";
            this.GloveDataChart5.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.GloveDataChart5.Legends.Add(legend5);
            this.GloveDataChart5.Location = new System.Drawing.Point(312, 252);
            this.GloveDataChart5.Name = "GloveDataChart5";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.GloveDataChart5.Series.Add(series5);
            this.GloveDataChart5.Size = new System.Drawing.Size(300, 212);
            this.GloveDataChart5.TabIndex = 4;
            this.GloveDataChart5.Text = "GloveDataChart";
            // 
            // GloveDataChart4
            // 
            chartArea6.Name = "ChartArea1";
            this.GloveDataChart4.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.GloveDataChart4.Legends.Add(legend6);
            this.GloveDataChart4.Location = new System.Drawing.Point(6, 252);
            this.GloveDataChart4.Name = "GloveDataChart4";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.GloveDataChart4.Series.Add(series6);
            this.GloveDataChart4.Size = new System.Drawing.Size(300, 212);
            this.GloveDataChart4.TabIndex = 3;
            this.GloveDataChart4.Text = "GloveDataChart";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(821, 527);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(103, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect Glove";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(694, 527);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cbBaudRate.TabIndex = 7;
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(567, 527);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(121, 21);
            this.cbPorts.TabIndex = 8;
            // 
            // labPort
            // 
            this.labPort.AutoSize = true;
            this.labPort.Location = new System.Drawing.Point(564, 511);
            this.labPort.Name = "labPort";
            this.labPort.Size = new System.Drawing.Size(26, 13);
            this.labPort.TabIndex = 9;
            this.labPort.Text = "Port";
            // 
            // labBaud
            // 
            this.labBaud.AutoSize = true;
            this.labBaud.Location = new System.Drawing.Point(691, 511);
            this.labBaud.Name = "labBaud";
            this.labBaud.Size = new System.Drawing.Size(58, 13);
            this.labBaud.TabIndex = 10;
            this.labBaud.Text = "Baud Rate";
            // 
            // tabMainPage
            // 
            this.tabMainPage.Controls.Add(this.tabGraphView);
            this.tabMainPage.Controls.Add(this.tabRawDataView);
            this.tabMainPage.Location = new System.Drawing.Point(12, 12);
            this.tabMainPage.Name = "tabMainPage";
            this.tabMainPage.SelectedIndex = 0;
            this.tabMainPage.Size = new System.Drawing.Size(933, 496);
            this.tabMainPage.TabIndex = 11;
            // 
            // tabGraphView
            // 
            this.tabGraphView.Controls.Add(this.GloveDataChart1);
            this.tabGraphView.Controls.Add(this.GloveDataChart2);
            this.tabGraphView.Controls.Add(this.GloveDataChart3);
            this.tabGraphView.Controls.Add(this.GloveDataChart4);
            this.tabGraphView.Controls.Add(this.GloveDataChart5);
            this.tabGraphView.Controls.Add(this.GloveDataChart6);
            this.tabGraphView.Location = new System.Drawing.Point(4, 22);
            this.tabGraphView.Name = "tabGraphView";
            this.tabGraphView.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraphView.Size = new System.Drawing.Size(925, 470);
            this.tabGraphView.TabIndex = 0;
            this.tabGraphView.Text = "Graph View";
            this.tabGraphView.UseVisualStyleBackColor = true;
            // 
            // tabRawDataView
            // 
            this.tabRawDataView.Controls.Add(this.textBox1);
            this.tabRawDataView.Controls.Add(this.txtRawData);
            this.tabRawDataView.Location = new System.Drawing.Point(4, 22);
            this.tabRawDataView.Name = "tabRawDataView";
            this.tabRawDataView.Padding = new System.Windows.Forms.Padding(3);
            this.tabRawDataView.Size = new System.Drawing.Size(925, 470);
            this.tabRawDataView.TabIndex = 1;
            this.tabRawDataView.Text = "Raw Data View";
            this.tabRawDataView.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(678, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(241, 458);
            this.textBox1.TabIndex = 1;
            // 
            // txtRawData
            // 
            this.txtRawData.Location = new System.Drawing.Point(6, 6);
            this.txtRawData.Multiline = true;
            this.txtRawData.Name = "txtRawData";
            this.txtRawData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRawData.Size = new System.Drawing.Size(666, 458);
            this.txtRawData.TabIndex = 0;
            // 
            // labConnectStatus
            // 
            this.labConnectStatus.AutoSize = true;
            this.labConnectStatus.Location = new System.Drawing.Point(818, 511);
            this.labConnectStatus.Name = "labConnectStatus";
            this.labConnectStatus.Size = new System.Drawing.Size(73, 13);
            this.labConnectStatus.TabIndex = 12;
            this.labConnectStatus.Text = "Disconnected";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save Data";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnScanPort
            // 
            this.btnScanPort.Location = new System.Drawing.Point(455, 525);
            this.btnScanPort.Name = "btnScanPort";
            this.btnScanPort.Size = new System.Drawing.Size(103, 23);
            this.btnScanPort.TabIndex = 14;
            this.btnScanPort.Text = "Scan Ports";
            this.btnScanPort.UseVisualStyleBackColor = true;
            this.btnScanPort.Click += new System.EventHandler(this.btnScanPort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 562);
            this.Controls.Add(this.btnScanPort);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labConnectStatus);
            this.Controls.Add(this.tabMainPage);
            this.Controls.Add(this.labBaud);
            this.Controls.Add(this.labPort);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GloveDataChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GloveDataChart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GloveDataChart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GloveDataChart6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GloveDataChart5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GloveDataChart4)).EndInit();
            this.tabMainPage.ResumeLayout(false);
            this.tabGraphView.ResumeLayout(false);
            this.tabRawDataView.ResumeLayout(false);
            this.tabRawDataView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataVisualization.Charting.Chart GloveDataChart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart GloveDataChart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart GloveDataChart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart GloveDataChart6;
        private System.Windows.Forms.DataVisualization.Charting.Chart GloveDataChart5;
        private System.Windows.Forms.DataVisualization.Charting.Chart GloveDataChart4;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Label labPort;
        private System.Windows.Forms.Label labBaud;
        private System.Windows.Forms.TabControl tabMainPage;
        private System.Windows.Forms.TabPage tabGraphView;
        private System.Windows.Forms.TabPage tabRawDataView;
        private System.Windows.Forms.TextBox txtRawData;
        private System.Windows.Forms.Label labConnectStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnScanPort;
    }
}

