using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Threading;

namespace Sockets
{
    class Program
    {
        //static Socket client;
        static void Main(string[] args)
        {
            if (args[0] == "server")
            {
                // Server
                //System.Net.IPAddress localaddress = System.Net.IPAddress.Loopback;
                //TcpListener listener = new TcpListener(localaddress, 12345);
                //listener.Start();

                //client = listener.BeginAcceptSocket(ProcessClient,null);

                //if (client.Connected)
                //{
                //    NetworkStream ns = new NetworkStream(client);
                //    StreamReader reader = new StreamReader(ns);
                //    StreamWriter writer = new StreamWriter(ns);

                //    Console.WriteLine(reader.ReadLine());
                //    writer.WriteLine("Got your message");
                //    writer.Flush();

                //    reader.Close();
                //    writer.Close();
                //    ns.Close();
                //}
                //client.Close();

                // event based server
                // Get the local address
                IPAddress[] ipAddressList = null;
                String hostname = Dns.GetHostName();
                //IPHostEntry ipentry = Dns.GetHostByName(hostname);
                ipAddressList = Dns.GetHostAddresses(hostname);

                Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                listener.Bind(new IPEndPoint(ipAddressList[0],12345));
                listener.Listen(10);

                listener.BeginAccept(new AsyncCallback(OnClientConnect), listener);

                while (true)
                {
                    Thread.Sleep(1);
                }
            }
            else if (args[0] == "client")
            {
                //TcpClient serversocket = new TcpClient("localhost", 12345);

                //if (serversocket.Connected)
                //{
                //    NetworkStream ns = serversocket.GetStream();

                //    StreamReader reader = new StreamReader(ns);
                //    StreamWriter writer = new StreamWriter(ns);

                //    writer.WriteLine("Hi there..I am a client");
                //    writer.Flush();
                //    Console.WriteLine(reader.ReadLine());

                //    reader.Close();
                //    writer.Close();
                //    ns.Close();
                //}
                //serversocket.Close();

                Socket serversocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                serversocket.Connect("localhost", 12345);
                //TcpClient serversocket = new TcpClient("eventhorizon", 12345);
                if (serversocket.Connected)
                {
                    NetworkStream ns = new NetworkStream(serversocket);

                    StreamReader reader = new StreamReader(ns);
                    StreamWriter writer = new StreamWriter(ns);

                    writer.WriteLine(Console.ReadLine());
                    writer.Flush();
                    Console.WriteLine(reader.ReadLine());

                    reader.Close();
                    writer.Close();
                    ns.Close();
                }
                serversocket.Close();
            }
            return;
        }

        static void OnClientConnect(IAsyncResult asyn)
        {
            Socket listener = (Socket)asyn.AsyncState;
            Socket clientSocket = listener.EndAccept(asyn);
            NetworkStream ns = new NetworkStream(clientSocket);
            StreamReader reader = new StreamReader(ns);
            StreamWriter writer = new StreamWriter(ns);

            Console.WriteLine(reader.ReadLine());
            writer.WriteLine("I have your message");
            writer.Flush();

            reader.Close();
            writer.Close();
            ns.Close();
            clientSocket.Close();

            listener.BeginAccept(new AsyncCallback(OnClientConnect), listener);
        }
    }
}
