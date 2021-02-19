using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientSocket
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);

            if(socket .Connected)
                Console.WriteLine("서버에 연결 되었습니다.");

            string message = string.Empty;

            while ((message = Console.ReadLine()) != "x") 
            {
                byte[] buff = Encoding.UTF8.GetBytes(message);
                socket.Send(buff);
            }
        }
    }
}
