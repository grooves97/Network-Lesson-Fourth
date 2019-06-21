using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket serverUDP = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            string ipAddress = "0.0.0.0";
            int port = 12345;

            byte[] buf = new byte[64 * 1024];

            //Локальная сетевая конечная точка(EdnPoint) для UDP сервера
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress),port);
            //Связывание адреса и порта с серверным UDP сокетом
            serverUDP.Bind(serverEndPoint);
            EndPoint remEndPoint = new IPEndPoint(0, 0);

            Console.WriteLine("UDP сервер запущен");
            while (true)
            {
                //ReceiveFrom() - метод приема данных по UDP протоколу
                int recSize = serverUDP.ReceiveFrom(buf, ref remEndPoint);
                Console.WriteLine("Полученные данные от клиента");
                Console.WriteLine($"Size = {recSize}");
                Console.WriteLine(Encoding.UTF8.GetString(buf,0,recSize));
            }
        }
    }
}
