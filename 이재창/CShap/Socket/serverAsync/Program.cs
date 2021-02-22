using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace serverAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsyncSocketServer().Wait();
        }
 
        static async Task RunAsyncSocketServer()
        { 
            int MAX_SIZE = 1024;  // 가정
 
            // (1) 소켓 객체 생성 (TCP 소켓)
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
 
            // (2) 포트에 바인드
            IPEndPoint ep = new IPEndPoint(IPAddress.Loopback, 7000);
            sock.Bind(ep);
 
            // (3) 포트 Listening 시작
            sock.Listen(100);
 
            while (true)
            {
                // (4) 비동기 소켓 Accept
                Socket clientSock = await Task.Factory.FromAsync(sock.BeginAccept, sock.EndAccept, null);
                 
                // (5) 비동기 소켓 수신
                var buff = new byte[MAX_SIZE];
 
                int nCount = await Task.Factory.FromAsync(
                           clientSock.BeginReceive(buff, 0, buff.Length, SocketFlags.None, null, clientSock),
                           clientSock.EndReceive);

                if (nCount > 0)
                {
                    string msg = Encoding.UTF8.GetString(buff, 0, nCount);
                    Console.WriteLine(msg);
 
                    // (6) 비동기 소켓 송신
                    await Task.Factory.FromAsync(
                            clientSock.BeginSend(buff, 0, nCount, SocketFlags.None, null, clientSock),
                            clientSock.EndSend);
                }
 
                // (7) 소켓 닫기
                clientSock.Close();
            }
        }
    }
}