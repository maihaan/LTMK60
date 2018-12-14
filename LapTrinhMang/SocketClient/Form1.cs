using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace SocketClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGui_Click(object sender, EventArgs e)
        {
            // Kiem tra du lieu nhap vao neu co thi chuyen thanh mang byte
            if (tbNoiDung.Text.Length == 0)
                return;
            byte[] duLieu = Encoding.UTF8.GetBytes(tbNoiDung.Text + "<EOF>");

            // Ket noi den may chu va gui du lieu
            IPHostEntry host = Dns.GetHostByAddress("127.0.0.1");
            IPAddress ip = host.AddressList[0];
            IPEndPoint ep = new IPEndPoint(ip, 12000);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(ep);
                if(client.Connected)
                {
                    client.Send(duLieu);

                    // Nhan ket qua tu may chu phan hoi va hien thi thong tin
                    byte[] boDem = new byte[1024];
                    int demNhan = client.Receive(boDem);
                    String dlNhan = Encoding.UTF8.GetString(boDem);

                    tbTinNhan.Text += "Client: " + tbNoiDung.Text + "\r\n";
                    tbTinNhan.Text += "Sever: " + dlNhan + "\r\n";
                    tbNoiDung.Text = "";
                    tbNoiDung.Focus();

                    client.Shutdown(SocketShutdown.Both);
                    client.Close();
                }                
            }
            catch { }
            

        }

        private void tbNoiDung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btGui_Click(sender, e);
        }
    }
}
