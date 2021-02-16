using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using convert_all;
using EtherListen.Properties;
using help_about;


namespace EtherListen
{
    public partial class Form1 : Form
    {
        private BackgroundWorker backgroundWorker;
        TcpListener server;
        private TcpClient client;
        private bool flag = true;
        private Settings settings = Settings.Default;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            flag = true;
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_Complete;
            backgroundWorker.RunWorkerAsync();
            btn_listen.Visible = false;
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                if (server != null) server.Stop();

                // Set the TcpListener.
                string ipAddr = txt_ipadd_1.Text + "." + txt_ipadd_2.Text + "." + txt_ipadd_3.Text + "." + txt_ipadd_4.Text;

                server = new TcpListener(IPAddress.Parse(ipAddr), Int32.Parse(txtbx_port.Text));

                // Start listening for client requests.
                server.Start();
                
                
                Invoke(new Action(() =>
                {
                    rchtxtbx_data.AppendText("Waiting for a connection... \r");
                    rchtxtbx_data.ScrollToCaret();
                }));

                // Perform a blocking call to accept requests.
                client = server.AcceptTcpClient();

                // Buffer for reading data
                Byte[] bytes = new Byte[client.ReceiveBufferSize];

                Invoke(new Action(() =>
                {
                    rchtxtbx_data.AppendText("Connected\r");
                    rchtxtbx_data.ScrollToCaret();
                }));


                // Get a stream object for reading and writing
                NetworkStream stream = client.GetStream();

                while ((flag) && (!backgroundWorker.CancellationPending))
                {
                    int i;

                    try
                    {
                       // Loop to receive all the data sent by the client.
                        // Note this will only get one packet of data.
                        while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            if (backgroundWorker.CancellationPending) e.Cancel = true;

                            //resize array to just data and send to processing
                            Array.Resize(ref bytes, i);
                           byte[] msg = decypher(bytes);

                            // Send back a response.
                            stream.Write(msg, 0, msg.Length);

                            //show response on UI
                            Invoke(new Action(() =>
                            {
                                rchtxtbx_data.AppendText("Text sent :" + Regex.Replace(convert.ByteArrayToHexString(msg), @"\s+", "") + "\r");
                                rchtxtbx_data.ScrollToCaret();
                            }));

                            //open the buffer up again to full size for next time round.
                            Array.Resize(ref bytes, client.ReceiveBufferSize);

                        }
                    }
                    catch (Exception exception)
                    {
                        //ignore any issues and close as we have an issue e.g client has shutdown.
                        Finalise();
                    }

                    client.Close();
                    client.Dispose();
                    if (backgroundWorker.CancellationPending) e.Cancel = true;
                }
            }
            catch (SocketException xException)
            {
                // An exception is caused by closing the client so it will come in here
                // This appears to be normal as Client is blocking. We just ignore this
                // and carry on.
                Invoke(new Action(() =>
                {
                    rchtxtbx_data.AppendText("Socket has been closed.\r");
                    rchtxtbx_data.ScrollToCaret();

                    btn_listen.Visible = true;
                }));
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();

                Invoke(new Action(() =>
                {
                    btn_listen.Visible = true;
                    rchtxtbx_data.AppendText("Server has been closed.\r");
                    rchtxtbx_data.ScrollToCaret();
                }));
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Finalise();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Finalise();
        }

        private void Finalise()
        {
            settings.txtbx_port = txtbx_port.Text;
            settings.txt_ipadd_1 = txt_ipadd_1.Text;
            settings.txt_ipadd_2 = txt_ipadd_2.Text;
            settings.txt_ipadd_3 = txt_ipadd_3.Text;
            settings.txt_ipadd_4 = txt_ipadd_4.Text;

            flag = false;
            if (server != null) server.Stop();
            if (client != null)
            {
                client.Close();
                client.Dispose();
            }

            if (backgroundWorker != null)
            {
                backgroundWorker.CancelAsync();
                backgroundWorker.Dispose();
            }

            Invoke(new Action(() =>
            {
                rchtxtbx_data.AppendText("All Shut Down\r");
                rchtxtbx_data.ScrollToCaret();
                btn_listen.Visible = true;
            }));


        }


        void backgroundWorker_Complete(object sender, RunWorkerCompletedEventArgs e)
        {
            flag = false;
            server.Stop();

            if (e.Cancelled)
            {
                Invoke(new Action(() =>
                {
                    rchtxtbx_data.AppendText("All Shut Down\r");
                    rchtxtbx_data.ScrollToCaret();
                }));
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rchtxtbx_data.Clear();
        }

        private void btn_close_app_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtbx_port.Text = settings.txtbx_port;
            txt_ipadd_1.Text = settings.txt_ipadd_1;
            txt_ipadd_2.Text = settings.txt_ipadd_2;
            txt_ipadd_3.Text = settings.txt_ipadd_3;
            txt_ipadd_4.Text = settings.txt_ipadd_4;
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            var f1 = new Help_Form();
            f1.ShowDialog();
            GC.Collect();
        }
    }
}

