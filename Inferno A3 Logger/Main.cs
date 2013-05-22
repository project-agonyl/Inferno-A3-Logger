using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Inferno_A3_Logger
{
    public partial class Main : Form
    {
        int msPortNumber, zsPortNumber, bsPortNumber;
        TcpListener msListener, bsListener, zsListener;
        Thread msListenThread, bsListenThread, zsListenThread;
        StreamWriter msWriter, zsWriter, bsWriter;
        string msLogName, zsLogName, bsLogName;
        IPAddress logServerIP;

        public Main()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            logServerIP = IPAddress.Parse("127.0.0.1");
            msPortNumber = Convert.ToInt32(msport.Text);
            bsPortNumber = Convert.ToInt32(bsport.Text);
            zsPortNumber = Convert.ToInt32(zsport.Text);
            if (msPortNumber > 1 && msPortNumber < 65536)
            {
                if (bsPortNumber > 1 && bsPortNumber < 65536)
                {
                    if (zsPortNumber > 1 && zsPortNumber < 65536)
                    {
                        startButton.Enabled = false;
                        stopButton.Enabled = true;
                        msport.Enabled = false;
                        zsport.Enabled = false;
                        bsport.Enabled = false;
                        try
                        {
                            if (!Directory.Exists("Logs"))
                                Directory.CreateDirectory("Logs");
                            msLogName = generateFileName("MainServer") + ".log";
                            zsLogName = generateFileName("ZoneServer") + ".log";
                            bsLogName = generateFileName("BattleServer") + ".log";
                            msListenThread = new Thread(new ThreadStart(msLogger));
                            zsListenThread = new Thread(new ThreadStart(zsLogger));
                            bsListenThread = new Thread(new ThreadStart(bsLogger));
                            msListenThread.Start();
                            zsListenThread.Start();
                            bsListenThread.Start();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("ERROR : " + ex.Message, "Inferno A3 Logger error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            stopLoggers();
                        }
                    }
                    else
                        MessageBox.Show("ERROR : Please enter valid ZS port number!", "Inferno A3 Logger error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("ERROR : Please enter valid BS port number!", "Inferno A3 Logger error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("ERROR : Please enter valid MS port number!", "Inferno A3 Logger error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopLoggers();
        }

        private void msLogger()
        {
            msListener = new TcpListener(logServerIP, msPortNumber);
            msListener.Start();
            while (true)
            {
                try
                {
                    TcpClient msClient = msListener.AcceptTcpClient();
                    Thread msClientThread = new Thread(new ParameterizedThreadStart(msHandler));
                    msClientThread.Start(msClient);
                }
                catch
                {
                    msListener.Stop();
                }
            }
        }

        private void msHandler(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    //blocks until a client sends a message
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    //a socket error has occured
                    break;
                }

                if (bytesRead == 0)
                {
                    //the client has disconnected from the server
                    break;
                }

                //message has successfully been received
                ASCIIEncoding encoder = new ASCIIEncoding();
                msWriter = new StreamWriter(Directory.GetCurrentDirectory() + "/Logs/" + msLogName, true);
                msWriter.WriteLine(encoder.GetString(message, 0, bytesRead));
                msWriter.Close();
            }

            tcpClient.Close();
        }

        private void zsLogger()
        {
            zsListener = new TcpListener(logServerIP, zsPortNumber);
            zsListener.Start();
            while (true)
            {
                try
                {
                    TcpClient zsClient = zsListener.AcceptTcpClient();
                    Thread zsClientThread = new Thread(new ParameterizedThreadStart(zsHandler));
                    zsClientThread.Start(zsClient);
                }
                catch
                {
                    zsListener.Stop();
                }
            }
        }

        private void zsHandler(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    //blocks until a client sends a message
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    //a socket error has occured
                    break;
                }

                if (bytesRead == 0)
                {
                    //the client has disconnected from the server
                    break;
                }

                //message has successfully been received
                ASCIIEncoding encoder = new ASCIIEncoding();
                zsWriter = new StreamWriter(Directory.GetCurrentDirectory() + "/Logs/" + zsLogName, true);
                zsWriter.WriteLine(encoder.GetString(message, 0, bytesRead));
                zsWriter.Close();
            }

            tcpClient.Close();
        }

        private void bsLogger()
        {
            bsListener = new TcpListener(logServerIP, bsPortNumber);
            bsListener.Start();
            while (true)
            {
                try
                {
                    TcpClient bsClient = bsListener.AcceptTcpClient();
                    Thread bsClientThread = new Thread(new ParameterizedThreadStart(bsHandler));
                    bsClientThread.Start(bsClient);
                }
                catch
                {
                    bsListener.Stop();
                }
            }
        }

        private void bsHandler(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    //blocks until a client sends a message
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    //a socket error has occured
                    break;
                }

                if (bytesRead == 0)
                {
                    //the client has disconnected from the server
                    break;
                }

                //message has successfully been received
                ASCIIEncoding encoder = new ASCIIEncoding();
                bsWriter = new StreamWriter(Directory.GetCurrentDirectory() + "/Logs/" + bsLogName, true);
                bsWriter.WriteLine(encoder.GetString(message, 0, bytesRead));
                bsWriter.Close();
            }

            tcpClient.Close();
        }

        private void stopLoggers()
        {
            msListener.Stop();
            msListenThread.Abort();
            zsListener.Stop();
            zsListenThread.Abort();
            bsListener.Stop();
            bsListenThread.Abort();
            if (null != msWriter)
                msWriter.Close();
            if(null != zsWriter)
                zsWriter.Close();
            if(null != bsWriter)
                bsWriter.Close();
            startButton.Enabled = true;
            stopButton.Enabled = false;
            msport.Enabled = true;
            zsport.Enabled = true;
            bsport.Enabled = true;
        }

        private string generateFileName(string context)
        {
            return context + "_" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }
    }
}
