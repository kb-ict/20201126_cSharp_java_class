using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerSocket
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            socket.Bind(ep);

            socket.Listen(10);

            Socket clientSocket = socket.Accept();
            if(clientSocket.Connected)
                Console.WriteLine("클라이언트가 서버에 접속하였습니다.");

            while (!Console.KeyAvailable)
            {
                byte[] buff = new byte[2048];
                int n = clientSocket.Receive(buff);
                string result = Encoding.UTF8.GetString(buff, 0, n);

                Console.WriteLine(result);
            }
        }
    }
}
