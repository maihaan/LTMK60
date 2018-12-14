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
using System.IO;

namespace SocketSever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLangNghe_Click(object sender, EventArgs e)
        {
            // Khai bao cac thanh phan de ket noi
            IPHostEntry host = Dns.GetHostByAddress("127.0.0.1");
            IPAddress ip = host.AddressList[0];
            IPEndPoint ep = new IPEndPoint(ip, 12000);
            byte[] boDem = new byte[1024];

            // Lang nghe cac ket noi den
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Bind(ep);
                server.Listen(10);
                String data = "";
                while(true)
                {
                    // Neu co ket noi den thi nhan du lieu va phan hoi
                    Socket client = server.Accept();
                    while(true)
                    {
                        int byteNhan = client.Receive(boDem);
                        data += Encoding.UTF8.GetString(boDem).Trim();
                        if (data.ToLower().Contains("<eof>"))
                            break;
                    }

                    String duongDan = Application.StartupPath + "\\..\\..\\log.txt";
                    using (StreamWriter sw = new StreamWriter(duongDan, true, Encoding.UTF8))
                    {
                        sw.WriteLine(DateTime.Now + ":" + data.Trim());
                    }

                    client.Send(Encoding.UTF8.GetBytes("Da nhan"));

                    client.Shutdown(SocketShutdown.Both);
                    client.Close();
                }
            }
            catch { }
        }
    }
}
