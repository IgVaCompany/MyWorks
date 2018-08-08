using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        static void Main(string[] args)
        {
            socket.Bind(new IPEndPoint(IPAddress.Any, 11111));
            socket.Listen(2);
            Socket client = socket.Accept();
            Console.WriteLine("New Connection");
            byte[] buffer = new byte[256];
            bool stop = false;
            do
            {
                client.Receive(buffer);
                //string messege = Encoding.ASCII.GetString(buffer);
                //if (messege == "stop")
                //    stop = true;
                //Console.WriteLine(messege);
                //client.Receive(buffer);
                string messege =Encoding.BigEndianUnicode.GetString(buffer);                           
                if (messege == "stop")
                    stop = true;
                Console.WriteLine(messege);

            } while (!stop);
            //client.Receive(buffer);
            //Console.WriteLine(Encoding.ASCII.GetString(buffer));
            //Console.ReadLine();
        }
    }
}