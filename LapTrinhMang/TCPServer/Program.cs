using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TCPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khoi tao cac thanh phan de ket noi
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener server = new TcpListener(ip, 12000);

            // Lang nghe ket noi den
            server.Start();
            while(true)
            {
                TcpClient client = server.AcceptTcpClient();
                NetworkStream net = client.GetStream();

                byte[] boDem = new byte[1024];
                net.Read(boDem, 0, 1024);

                String duLieu = Encoding.UTF8.GetString(boDem);
                Console.WriteLine("Da nhan: " + duLieu.Trim());

                byte[] phanHoi = Encoding.UTF8.GetBytes("Đã nhận " + duLieu.Trim().Length + " bytes");
                net.Write(phanHoi, 0, phanHoi.Length);

                net.Dispose();
                client.Close();
            }
        }
    }
}
