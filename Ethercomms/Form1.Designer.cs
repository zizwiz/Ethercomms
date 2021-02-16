namespace Ethercomms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_send = new System.Windows.Forms.Button();
            this.txtbx_data_to_send = new System.Windows.Forms.TextBox();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbx_connected = new System.Windows.Forms.TextBox();
            this.txtbx_availability = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_port = new System.Windows.Forms.Label();
            this.txtbx_port = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ipadd_4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ipadd_3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ipadd_2 = new System.Windows.Forms.TextBox();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.txt_ipadd_1 = new System.Windows.Forms.TextBox();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.rchtxtbx_data = new System.Windows.Forms.RichTextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chkbx_hex = new System.Windows.Forms.CheckBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_data_flow = new System.Windows.Forms.TabPage();
            this.tab_vacant = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_data_flow.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_send.Location = new System.Drawing.Point(0, 0);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(99, 46);
            this.btn_send.TabIndex = 85;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txtbx_data_to_send
            // 
            this.txtbx_data_to_send.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx_data_to_send.Location = new System.Drawing.Point(6, 9);
            this.txtbx_data_to_send.Name = "txtbx_data_to_send";
            this.txtbx_data_to_send.Size = new System.Drawing.Size(705, 22);
            this.txtbx_data_to_send.TabIndex = 84;
            this.txtbx_data_to_send.Text = "414243444546474849";
            // 
            // btn_help
            // 
            this.btn_help.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_help.Location = new System.Drawing.Point(0, 0);
            this.btn_help.Margin = new System.Windows.Forms.Padding(4);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(101, 46);
            this.btn_help.TabIndex = 87;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.Location = new System.Drawing.Point(0, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(101, 46);
            this.btn_close.TabIndex = 86;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtbx_connected);
            this.groupBox1.Controls.Add(this.txtbx_availability);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_port);
            this.groupBox1.Controls.Add(this.txtbx_port);
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_ipadd_4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_ipadd_3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_ipadd_2);
            this.groupBox1.Controls.Add(this.lbl_IP);
            this.groupBox1.Controls.Add(this.txt_ipadd_1);
            this.groupBox1.Controls.Add(this.btn_disconnect);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(944, 98);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(771, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 75;
            this.label11.Text = "Connected";
            // 
            // txtbx_connected
            // 
            this.txtbx_connected.BackColor = System.Drawing.Color.Red;
            this.txtbx_connected.Location = new System.Drawing.Point(854, 31);
            this.txtbx_connected.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_connected.MaxLength = 3;
            this.txtbx_connected.Name = "txtbx_connected";
            this.txtbx_connected.Size = new System.Drawing.Size(33, 22);
            this.txtbx_connected.TabIndex = 74;
            // 
            // txtbx_availability
            // 
            this.txtbx_availability.BackColor = System.Drawing.Color.Red;
            this.txtbx_availability.Location = new System.Drawing.Point(722, 32);
            this.txtbx_availability.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_availability.MaxLength = 3;
            this.txtbx_availability.Name = "txtbx_availability";
            this.txtbx_availability.Size = new System.Drawing.Size(33, 22);
            this.txtbx_availability.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "Network Availability";
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(466, 37);
            this.lbl_port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(46, 17);
            this.lbl_port.TabIndex = 70;
            this.lbl_port.Text = "Port #";
            // 
            // txtbx_port
            // 
            this.txtbx_port.HideSelection = false;
            this.txtbx_port.Location = new System.Drawing.Point(520, 32);
            this.txtbx_port.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_port.MaxLength = 5;
            this.txtbx_port.Name = "txtbx_port";
            this.txtbx_port.Size = new System.Drawing.Size(49, 22);
            this.txtbx_port.TabIndex = 71;
            this.txtbx_port.Text = "13000";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(354, 31);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(100, 28);
            this.btn_connect.TabIndex = 68;
            this.btn_connect.Text = "&Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = ".";
            // 
            // txt_ipadd_4
            // 
            this.txt_ipadd_4.Location = new System.Drawing.Point(280, 32);
            this.txt_ipadd_4.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ipadd_4.MaxLength = 3;
            this.txt_ipadd_4.Name = "txt_ipadd_4";
            this.txt_ipadd_4.Size = new System.Drawing.Size(33, 22);
            this.txt_ipadd_4.TabIndex = 61;
            this.txt_ipadd_4.Text = "1";
            this.txt_ipadd_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ipadd_4_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = ".";
            // 
            // txt_ipadd_3
            // 
            this.txt_ipadd_3.Location = new System.Drawing.Point(224, 31);
            this.txt_ipadd_3.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ipadd_3.MaxLength = 3;
            this.txt_ipadd_3.Name = "txt_ipadd_3";
            this.txt_ipadd_3.Size = new System.Drawing.Size(33, 22);
            this.txt_ipadd_3.TabIndex = 60;
            this.txt_ipadd_3.Text = "0";
            this.txt_ipadd_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ipadd_3_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 63;
            this.label6.Text = ".";
            // 
            // txt_ipadd_2
            // 
            this.txt_ipadd_2.Location = new System.Drawing.Point(169, 30);
            this.txt_ipadd_2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ipadd_2.MaxLength = 3;
            this.txt_ipadd_2.Name = "txt_ipadd_2";
            this.txt_ipadd_2.Size = new System.Drawing.Size(33, 22);
            this.txt_ipadd_2.TabIndex = 59;
            this.txt_ipadd_2.Text = "0";
            this.txt_ipadd_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ipadd_2_KeyPress);
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Location = new System.Drawing.Point(16, 33);
            this.lbl_IP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(76, 17);
            this.lbl_IP.TabIndex = 62;
            this.lbl_IP.Text = "IP Address";
            // 
            // txt_ipadd_1
            // 
            this.txt_ipadd_1.Location = new System.Drawing.Point(112, 30);
            this.txt_ipadd_1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ipadd_1.MaxLength = 3;
            this.txt_ipadd_1.Name = "txt_ipadd_1";
            this.txt_ipadd_1.Size = new System.Drawing.Size(33, 22);
            this.txt_ipadd_1.TabIndex = 58;
            this.txt_ipadd_1.Text = "127";
            this.txt_ipadd_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ipadd_1_KeyPress);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Enabled = false;
            this.btn_disconnect.Location = new System.Drawing.Point(354, 30);
            this.btn_disconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(100, 28);
            this.btn_disconnect.TabIndex = 69;
            this.btn_disconnect.Text = "&Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // rchtxtbx_data
            // 
            this.rchtxtbx_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxtbx_data.Location = new System.Drawing.Point(3, 3);
            this.rchtxtbx_data.Name = "rchtxtbx_data";
            this.rchtxtbx_data.Size = new System.Drawing.Size(1037, 323);
            this.rchtxtbx_data.TabIndex = 88;
            this.rchtxtbx_data.Text = "";
            // 
            // btn_clear
            // 
            this.btn_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clear.Location = new System.Drawing.Point(0, 0);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(101, 46);
            this.btn_clear.TabIndex = 89;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1057, 520);
            this.tableLayoutPanel1.TabIndex = 90;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 358);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_help);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(953, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 46);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_close);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(953, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(101, 46);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_clear);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(953, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(101, 46);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_send);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(848, 107);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(99, 46);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel7, 2);
            this.panel7.Controls.Add(this.groupBox1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.tableLayoutPanel1.SetRowSpan(this.panel7, 2);
            this.panel7.Size = new System.Drawing.Size(944, 98);
            this.panel7.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.66666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 107);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(839, 46);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chkbx_hex);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(730, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(106, 40);
            this.panel5.TabIndex = 0;
            // 
            // chkbx_hex
            // 
            this.chkbx_hex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbx_hex.AutoSize = true;
            this.chkbx_hex.Checked = true;
            this.chkbx_hex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbx_hex.Location = new System.Drawing.Point(21, 11);
            this.chkbx_hex.Name = "chkbx_hex";
            this.chkbx_hex.Size = new System.Drawing.Size(54, 21);
            this.chkbx_hex.TabIndex = 85;
            this.chkbx_hex.Text = "Hex";
            this.chkbx_hex.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtbx_data_to_send);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(721, 40);
            this.panel8.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_data_flow);
            this.tabControl1.Controls.Add(this.tab_vacant);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 358);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_data_flow
            // 
            this.tab_data_flow.Controls.Add(this.rchtxtbx_data);
            this.tab_data_flow.Location = new System.Drawing.Point(4, 25);
            this.tab_data_flow.Name = "tab_data_flow";
            this.tab_data_flow.Padding = new System.Windows.Forms.Padding(3);
            this.tab_data_flow.Size = new System.Drawing.Size(1043, 329);
            this.tab_data_flow.TabIndex = 0;
            this.tab_data_flow.Text = "Data Flow";
            this.tab_data_flow.UseVisualStyleBackColor = true;
            // 
            // tab_vacant
            // 
            this.tab_vacant.Location = new System.Drawing.Point(4, 25);
            this.tab_vacant.Name = "tab_vacant";
            this.tab_vacant.Padding = new System.Windows.Forms.Padding(3);
            this.tab_vacant.Size = new System.Drawing.Size(1043, 329);
            this.tab_vacant.TabIndex = 1;
            this.tab_vacant.Text = "vacant";
            this.tab_vacant.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 520);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ethercomms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_data_flow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txtbx_data_to_send;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbx_connected;
        private System.Windows.Forms.TextBox txtbx_availability;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.TextBox txtbx_port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ipadd_4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ipadd_3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ipadd_2;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.TextBox txt_ipadd_1;
        public System.Windows.Forms.RichTextBox rchtxtbx_data;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Button btn_connect;
        public System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.CheckBox chkbx_hex;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_data_flow;
        private System.Windows.Forms.TabPage tab_vacant;
    }
}

