using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using Ethernet;
using convert_all;

namespace Ethercomms
{
    public partial class Form1
    {
        public Client client;

        private void btn_connect_Click(object sender, EventArgs e)//Connect
        {
            string ipAddr = txt_ipadd_1.Text + "." + txt_ipadd_2.Text + "." + txt_ipadd_3.Text + "." + txt_ipadd_4.Text;
            string port = txtbx_port.Text;

            if (IsValidIPAddress(ipAddr) == true)
            {

                try
                {
                    if (client == null)
                        client = new Client(this);

                    client.Connect(ipAddr, port);

                    btn_connect.Enabled = false;
                    btn_connect.Visible = false;
                    btn_disconnect.Enabled = true;
                    btn_disconnect.Visible = true;

                    txtbx_connected.BackColor = Color.Green;

                   

                }
                catch (SocketException se)
                {
                    MessageBox.Show("Server Connect Error.\r\n" + se.ToString());
                }

            }
            else
            {
                MessageBox.Show("Invalid IP address input.");
            }
        }

        private void btn_disconnect_Click(object sender, EventArgs e) //Disconnect
        {

            client.Disconnect();
            Disconnect_TidyUp();
        }

        private void Disconnect_TidyUp()
        {
        if (btn_connect.Enabled == false)
            {
                btn_connect.Enabled = true;
                btn_connect.Visible = true;
                btn_disconnect.Enabled = false;
                btn_disconnect.Visible = false;

               txtbx_connected.BackColor = Color.Red;
            }

        }

        private void txt_ipadd_1_KeyPress(object sender, EventArgs e)
        {
            Control ctl;

            this.SetStyle(ControlStyles.Selectable, true);
            this.UpdateStyles();

            if (txt_ipadd_1.Text.Length == 3)
            {
                ctl = (Control)sender;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_ipadd_2_KeyPress(object sender, EventArgs e)
        {
            Control ctl;

            this.SetStyle(ControlStyles.Selectable, true);
            this.UpdateStyles();

            if (txt_ipadd_2.Text.Length == 3)
            {
                ctl = (Control)sender;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }


        private void txt_ipadd_3_KeyPress(object sender, EventArgs e)
        {
            Control ctl;

            this.SetStyle(ControlStyles.Selectable, true);
            this.UpdateStyles();

            if (txt_ipadd_3.Text.Length == 3)
            {
                ctl = (Control)sender;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_ipadd_4_KeyPress(object sender, EventArgs e)
        {
            Control ctl;

            this.SetStyle(ControlStyles.Selectable, true);
            this.UpdateStyles();

            if (txt_ipadd_4.Text.Length == 3)
            {
                ctl = (Control)sender;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }


        private bool IsValidIPAddress(string ipaddr)//Validate the input IP address
        {
            try
            {
                IPAddress.Parse(ipaddr);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "IsValidIPAddress Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
