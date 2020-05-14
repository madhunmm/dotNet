using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Snooper
{
    class Server
    {
        private Socket socListener;

        private Socket clientSocket;

        public Server()
        {
            new Thread(new ThreadStart(Start)).Start();
        }

        public void Start()
        {
            // Create the listener socket
            try
            {
                socListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            }
            catch (Exception)//(SocketException socEx)
            {
                return; //socEx.Message;
            }

            IPAddress[] ipAddressList = Dns.GetHostAddresses(Dns.GetHostName());
            if (socListener != null)
            {
                // Bind the socket to the default port of 12345
                //socListener.Bind(new IPEndPoint(ipAddressList[0], 12345));
                socListener.Bind(new IPEndPoint(IPAddress.Parse("172.20.4.216"), 12345));

                // Broadcast my presence
                SendBroadcast();

                // start listening
                socListener.Listen(10);

                // start accepting connections asynchronously
                socListener.BeginAccept(new AsyncCallback(OnClientConnect), null);
            }
        }

        public void Stop()
        {
        }

        private void OnClientConnect(IAsyncResult asyncResult)
        {
            if(socListener != null)
            {
                // Get the client socket
                Socket socClient = socListener.EndAccept(asyncResult);

                // Create streams to and from it
                NetworkStream ns = new NetworkStream(socClient);
                StreamReader nsReader = new StreamReader(ns);
                StreamWriter nsWriter = new StreamWriter(ns);

                // Handle messages
                // for each message from the client, send an ack.
                String strMessage;
                String strFileName = "";
                while (socClient.Connected)
                {
                    try
                    {
                        strMessage = nsReader.ReadLine();
                        if (strMessage == null)
                        {
                            strMessage = "";
                            continue;
                        }
                    }
                    catch (Exception)
                    {
                        break;
                    }
                    if (strMessage.Equals("eom"))
                    {
                        nsWriter.WriteLine("ack");
                        nsWriter.Flush();
                        break;
                    }
                    
                    String strResponse = HandleClient(strMessage, socClient);
                    nsWriter.WriteLine(strResponse);
                    nsWriter.Flush();
                }

                // Close the streams
                ns.Close();
                nsReader.Close();
                nsWriter.Close();

                // Close the client socket
                socClient.Close();
                socListener.BeginAccept(new AsyncCallback(OnClientConnect), null);
            }
        }

        private String HandleClient(String strMessage, Socket socClient)
        {
            // Create streams to and from it
            NetworkStream ns = new NetworkStream(socClient);
            StreamReader nsReader = new StreamReader(ns);
            StreamWriter nsWriter = new StreamWriter(ns);

            Console.WriteLine(strMessage);
            while (true)
            {
                String strCommand = Console.ReadLine();
                if (strCommand == "exit")
                    break;
                nsWriter.WriteLine(strCommand);
                nsWriter.Flush();
            }
            return "ack";
        }

        public void SendBroadcast()
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint iep1 = new IPEndPoint(IPAddress.Broadcast, 9050);
            string hostname = Dns.GetHostName();
            byte[] data = Encoding.ASCII.GetBytes(hostname);
            sock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
            sock.SendTo(data, iep1);
            sock.Close();
        }
   }
}
