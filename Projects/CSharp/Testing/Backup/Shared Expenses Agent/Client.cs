using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections;

namespace Shared_Expenses_Agent
{
    class Client
    {
        private Socket socServerSocket;

        public Client()
        {
        }

        public String SendFile(String strFilePath)
        {
            String strReturn = "";
            // Connect to the server
            try
            {
                if (socServerSocket == null)
                {
                    socServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    socServerSocket.Connect(Settings.Instance().ServerHostName, 12345);
                }
            }
            catch (SocketException socEx)
            {
                return socEx.Message;
            }

            if ((socServerSocket != null) && (socServerSocket.Connected))
            {
                // Create the streams
                NetworkStream ns = new NetworkStream(socServerSocket);
                StreamReader nsReader = new StreamReader(ns);
                StreamWriter nsWriter = new StreamWriter(ns);

                // Send the data through
                // First send the file name
                SendMessage("filename=" + Dns.GetHostName() + ".txt");

                // Wait for the ack
                String strResponse;
                strResponse = nsReader.ReadLine();
                if (strResponse.Equals("ack"))
                {
                    // open the cached file
                    StreamReader fileReader = new StreamReader(strFilePath);

                    // Read the data line by line and send it across.
                    while (!fileReader.EndOfStream)
                    {
                        SendMessage(fileReader.ReadLine());

                        // wait for ack before sending the next line
                        strResponse = nsReader.ReadLine();
                        if (!strResponse.Equals("ack"))
                        {
                            strReturn = "Error transferring data to the server";
                            break;
                        }
                        SendEndOfMessage();
                        strResponse = nsReader.ReadLine();
                        if (!strResponse.Equals("ack"))
                        {
                            return "error";
                        }
                    }
                    fileReader.Close();
                }
                // Close the streams
                nsReader.Close();
                ns.Close();
                socServerSocket.Close();
                socServerSocket = null;
            }
            return strReturn;
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

        public void SendEndOfMessage()
        {
            SendMessage("eom");
        }

        // Gets the whole database as a big string
        public String ReceiveFile()
        {
            String strReturn = "";
            if (socServerSocket == null)
            {
                try
                {
                    socServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                    socServerSocket.Connect(Settings.Instance().ServerHostName, 12345);
                }
                catch (SocketException socEx)
                {
                    strReturn = socEx.Message;
                }
            }
            if ((socServerSocket != null) && (socServerSocket.Connected))
            {
                // Create the streams
                NetworkStream ns = new NetworkStream(socServerSocket);
                StreamReader nsReader = new StreamReader(ns);
                StreamWriter nsWriter = new StreamWriter(ns);

                // Send the command
                SendMessage("getdb");
                String strResponse = "";
                strResponse = nsReader.ReadLine();
                strReturn = new String(strResponse.ToCharArray());
                SendEndOfMessage();
                strResponse = nsReader.ReadLine();
                if (!strResponse.Equals("ack"))
                {
                    return "error";
                }
            }

            if (socServerSocket != null)
            {
                socServerSocket.Close();
                socServerSocket = null;
            }
            return strReturn;
        }
    }
}
