using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace UDPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGui_Click(object sender, EventArgs e)
        {
            UdpClient client = new UdpClient();
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            client.Connect(ip, 12000);
            client.Send(Encoding.UTF8.GetBytes(tbNoiDung.Text), tbNoiDung.Text.Length);            

            tbTinNhan.Text += "\r\nClient: " + tbNoiDung.Text + "\r\n";
            tbNoiDung.Text = "";
        }
    }
}
