using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace UDPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao thanh phan de ket noi
            UdpClient server = new UdpClient(12000);

            // Lang nghe
            while(true)
            {
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, 12000);

                // Nhan du lieu va phan hoi
                byte[] boDem = server.Receive(ref ep);
                String duLieu = Encoding.UTF8.GetString(boDem);
                Console.WriteLine("Da nhan: " + duLieu.Trim());
            }
        }
    }
}
