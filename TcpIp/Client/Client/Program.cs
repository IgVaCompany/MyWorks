using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        static void Main(string[] args)
        {
            socket.Connect("192.168.110.125", 80);
            string message = Console.ReadLine();
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            socket.Send(buffer);
            Console.ReadLine();

        }
    }
}
