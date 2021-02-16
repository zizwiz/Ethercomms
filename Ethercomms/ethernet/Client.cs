using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using convert_all;
using Ethercomms;


namespace Ethernet
{
    public class Client
    {
        private Socket client;
        private Thread clientListener;
        private bool isEndClientListener;

        private Form1 form1;

        public Client(Form1 f)
        {
            form1 = f;
        }


        public void Send_Data(string data, string ipAddr, string port)
        {
            try
            {
                if ((client.Connected) && (client != null)) //is better for lost connections
                {
                    form1.rchtxtbx_data.AppendText("\rSent:\r" + data + "\r");
                    form1.rchtxtbx_data.ScrollToCaret();

                    //We try to check if the connection is half open or not
                    Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    sock.Connect(IPAddress.Parse(ipAddr), Int32.Parse(port));
                    
                    if (sock.Connected == true) // Port is in use and connection is successful
                    {
                        ///change the data to hex in here if not already in hex
                        if (!form1.chkbx_hex.Checked)
                        {
                            data = convert.ConvertStringToHex(data);
                        }

                        client.Send(convert.HexStringToByteArray(data));
                            
                        
                    }
                    else
                    {
                        form1.rchtxtbx_data.AppendText("Port is Closed");
                    }

                }
                else
                {
                    form1.rchtxtbx_data.AppendText("Server is not connected..\r");
                    Disconnect();
                    form1.btn_disconnect.Visible = false;
                    form1.btn_connect.Enabled = true;
                    form1.btn_connect.Visible = true;
                }
            }
            catch (Exception e)
            {
                form1.rchtxtbx_data.AppendText("Server is not connected...\r");
                Disconnect();
                form1.btn_disconnect.Visible = false;
                form1.btn_connect.Enabled = true;
                form1.btn_connect.Visible = true;
            }

        }

        
        public void Connect(string ipAddr, string port)
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(ipAddr), Convert.ToInt32(port));
            client.Connect(ipe);

            // client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, 1);

            clientListener = new Thread(OnDataReceived);
            isEndClientListener = false;
            clientListener.Start();
        }

        public void Disconnect()
        {
            try
            {
                isEndClientListener = true;
                if (clientListener != null) clientListener.Abort();
                if (client != null) client.Disconnect(true);
                client = null;
            }
            catch (Exception e)
            {
                //Do nothing just carry on
            }
        }

        private void OnDataReceived()
        {
            try
            {
                while (isEndClientListener == false)
                {
                    byte[] receiveData = new byte[client.ReceiveBufferSize];
                    int iRx = client.Receive(receiveData);

                    if (iRx != 0)
                    {
                        string szData = "";
                        for (int i = 0; i < iRx; i++)
                        {
                            szData += (receiveData[i].ToString("X").Length == 2
                                ? receiveData[i].ToString("X")
                                : "0" + receiveData[i].ToString("X"));
                        }

                        form1.Decypher(szData); //send data to form but watch this is a thread.

                    }
                }
            }
            catch (Exception e)
            {
                // It is normal to sometimes come in here when you get a blocking item interrupted
                // Usually it is something like the Client that will cause it.
            }
        }
    }
}
