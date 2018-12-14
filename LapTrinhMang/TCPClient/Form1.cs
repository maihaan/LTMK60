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

namespace TCPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGui_Click(object sender, EventArgs e)
        {
            // Khoi tao cac thanh phan de ket noi
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpClient client = new TcpClient();

            // Ket noi den may chu va gui du lieu
            client.Connect(ip, 12000);
            if(client.Connected)
            {
                NetworkStream net = client.GetStream();
                byte[] boDem = Encoding.UTF8.GetBytes(tbNoiDung.Text.Trim());
                net.Write(boDem, 0, boDem.Length);

                // Nhan phan hoi va hien thi thong tin
                boDem = new byte[1024];
                net.Read(boDem, 0, 1024);
                String duLieu = Encoding.UTF8.GetString(boDem);

                tbTinNhan.Text += "Client: " + tbNoiDung.Text + "\r\n";
                tbTinNhan.Text += "Server: " + duLieu + "\r\n";
                tbNoiDung.Text = "";
            }
        }
    }
}
