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

        public static int Memcpy(byte[] bufferDec, byte[] bufferScr, int offsetDst, int offsetSrc, int size)
        {
            Buffer.BlockCopy(bufferScr, offsetSrc, bufferDec, offsetDst, size);
            return size;
        }

        static void Main(string[] args)
        {

            socket.Bind(new IPEndPoint(IPAddress.Any, 11111));
            socket.Listen(2);
            Socket client = socket.Accept();
            Console.WriteLine("New Connection");

          //  socket.Connect("192.168.110.125", 11112);
            byte[] buffer = new byte[8];
            bool stop = false;
            do
            {
                //int count = client.Receive(buffer);

                //if (count != 4)
                //    continue;

                client.Receive(buffer);
                string messege = Encoding.ASCII.GetString(buffer);
                             
              //string messege =Encoding.BigEndianUnicode.GetString(buffer);                           
                Console.WriteLine(messege);
               // byte[] Timebuffer = Encoding.ASCII.GetBytes(DateTime.Now.ToString());

            } while (!stop);
            //client.Receive(buffer);
            //Console.WriteLine(Encoding.ASCII.GetString(buffer));
            //Console.ReadLine();
        }
    }
}