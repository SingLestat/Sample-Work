using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class Server 
    {
        private static bool Start;
        private static long numClients;
        private static TcpListener server;
        private static List<TcpClient> Clients;

        public static bool StartServer()
        {
            IPAddress ip = Dns.GetHostEntry("fe80::fc80:322:9e5f:fda9%11").AddressList[0];

            server = new TcpListener(ip, 333);
            Clients = new List<TcpClient>();

            try
            {
                server.Start();
                Console.WriteLine("Server Started..");
                Start = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();

                return false;
            }

            Task.Run(() => AcceptClients(ref server));
            return true;

        }

        private static void AcceptClients(ref TcpListener server)
        {
            while (Start)
            {
                if (numClients <= 10)
                {
                    TcpClient client = server.AcceptTcpClient();

                    Clients.Add(client);
                    numClients++;

                    Task.Run(() => ClientOperation(Clients[Clients.Count - 1]));
                }
            }
        }

        public static void StopServer()
        {
            Start = false;
            server.Stop();
            Console.WriteLine("Server has stopped running...");
        }

        public static void ClientOperation(TcpClient client)
        {
            while (true)
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[100];

                int bufferRead = stream.Read(buffer, 0, buffer.Length);

                string msg = Encoding.ASCII.GetString(buffer, 0, bufferRead);

                SendMessage(buffer, bufferRead, client);

                //int byteSize = Encoding.ASCII.GetByteCount("My momma told me not to talk to strangers");
                //byte[] sendMsg = new byte[byteSize];

                //sendMsg = Encoding.ASCII.GetBytes("My momma told me not to talk to strangers");

                //stream.Write(sendMsg, 0, sendMsg.Length);

                Console.WriteLine(msg);
            }
        }

        private static Object Lock = new object();

        public static void SendMessage(byte[] msg,int msgLength, TcpClient SentFrom)
        {
            lock(Lock)
            {
                for (int c = 0; c < Clients.Count; c++)
                {
                    if (SentFrom != Clients[c])
                    {
                        NetworkStream stream = Clients[c].GetStream();
                        stream.Write(msg, 0, msgLength);
                    }
                }
            }
        }
    }
}
