using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections;
using System.Threading;

namespace Snooper
{
    class Client
    {
        private Socket socServerSocket;

        public Client()
        {
            new Thread(new ThreadStart(Start)).Start();
        }

        public void Start()
        {
            ReceiveBroadcast();
        }

        private bool SendMessage(String strMessage)
        {
            if ((socServerSocket != null) && (socServerSocket.Connected))
            {
                // Create the streams
                NetworkStream ns = new NetworkStream(socServerSocket);
                StreamWriter nsWriter = new StreamWriter(ns);

                // Send the data through
                nsWriter.WriteLine(strMessage);
                nsWriter.Flush();

                nsWriter.Close();
                ns.Close();
                return true;
            }
            return false;
        }

        private bool ReceiveMessage()
        {
            String strMessage = "";
            if ((socServerSocket != null) && (socServerSocket.Connected))
            {
                // Create the streams
                NetworkStream ns = new NetworkStream(socServerSocket);
                StreamReader nsReader = new StreamReader(ns);

                while (socServerSocket.Connected)
                {
                    // Wait for orders
                    strMessage = nsReader.ReadLine();

                    // Process the order
                    String strResult = "I am here"; // A message handler shold come in here
                    SendMessage(strResult);
                }
                
                nsReader.Close();
                ns.Close();
                return true;
            }
            return false;
        }

        public void SendEndOfMessage()
        {
            SendMessage("eom");
        }

        public void ReceiveBroadcast()
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9050);
            sock.Bind(iep);
            EndPoint ep = (EndPoint)iep;
            Console.WriteLine("Ready to receive…");
            byte[] data = new byte[1024];
            int recv = sock.ReceiveFrom(data, ref ep);
            string stringData = Encoding.ASCII.GetString(data, 0, recv);
            Console.WriteLine("received: {0} from: {1}", stringData, ep.ToString());
            
            // Connect to the server
            ConnectToServer(ep.ToString().Substring(0,ep.ToString().LastIndexOf(':')));
            SendMessage("Connected to you Master");

            sock.Close();
        }

        private void ConnectToServer(String strServerName)
        {
            // Connect to the server
            try
            {
                if (socServerSocket == null)
                {
                    socServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    socServerSocket.Connect(strServerName, 12345);
                }
            }
            catch (SocketException socEx)
            {
                Console.WriteLine(socEx.Message);
            }
        }
    }
}
