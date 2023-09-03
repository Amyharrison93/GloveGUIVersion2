using System.IO.Ports;
using System.Threading;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Configuration;

public class SerialHandler
{
    private bool connected = false;
    private bool Connected { get { return connected; } }

    private SerialPort port;
    public SerialHandler(string portName, int baudrate)
    {
       port = new SerialPort(portName,
             baudrate, Parity.None, 8, StopBits.One);
        port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
    }

    public void Listen()
    {
        if (!connected)
        {
            connected = true;
            port.Open();
            
        }
    }

    public void Close()
    {
        if (connected)
        {
            connected = false;
            port.Close();
            
        }
    }
    private void port_DataReceived(object sender,
     SerialDataReceivedEventArgs e)
    {
        DataRecieved?.Invoke(this, port.ReadExisting());
    }

    public EventHandler<string> DataRecieved;


}