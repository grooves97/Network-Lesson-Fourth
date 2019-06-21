using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace UDPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сокет для UDP обмена
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            EndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);

            string str = "Hello world";
            socket.SendTo(Encoding.UTF8.GetBytes(str), serverEndPoint);
            str = "Bye world";
            socket.SendTo(Encoding.UTF8.GetBytes(str), serverEndPoint);
            str = "Madi lox";
            socket.SendTo(Encoding.UTF8.GetBytes(str), serverEndPoint);
            str = "CJ";
            socket.SendTo(Encoding.UTF8.GetBytes(str), serverEndPoint);
            str = "Travis Scott";
            socket.SendTo(Encoding.UTF8.GetBytes(str), serverEndPoint);
        }
    }
}
