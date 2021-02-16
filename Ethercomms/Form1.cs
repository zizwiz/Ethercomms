using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using help_about;

namespace Ethercomms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            if (client != null) client.Disconnect();
            client = null;
            Close();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                string ipAddr = txt_ipadd_1.Text + "." + txt_ipadd_2.Text + "." + txt_ipadd_3.Text + "." + txt_ipadd_4.Text;
                string port = txtbx_port.Text;

                client.Send_Data(txtbx_data_to_send.Text.Trim(' '), ipAddr, port);
            }
            catch (Exception exception)
            {
                Invoke(new Action(() =>
                {
                    rchtxtbx_data.AppendText("You need to open a connection\r");
                    rchtxtbx_data.ScrollToCaret();

                }));
            }

        }

       


        private void Form1_Load(object sender, EventArgs e)
        {
            txtbx_connected.BackColor = Color.Red;

            if (NetworkInterface.GetIsNetworkAvailable())
            {
                Invoke(new Action(() =>
                {
                    txtbx_availability.BackColor = Color.Green;
                    btn_connect.Visible = true;
                    btn_connect.Enabled = true;
                    btn_disconnect.Enabled = false;
                    groupBox1.Visible = true;

                }));
            }
            else
            {
                Invoke(new Action(() =>
                {
                    txtbx_availability.BackColor = Color.Red;
                    groupBox1.Visible = false;
                }));
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rchtxtbx_data.Clear();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            var f1 = new Help_Form();
            f1.ShowDialog();
            GC.Collect();
        }
    }
}
