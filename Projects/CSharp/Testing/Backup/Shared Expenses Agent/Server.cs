using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Shared_Expenses_Agent
{
    class Server
    {
        private Socket socListener;

        public Server()
        {
            new Thread(new ThreadStart(Start)).Start();
        }

        public void Start()
        {
            //String strReturn = "";

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
                socListener.Bind(new IPEndPoint(ipAddressList[0], 12345));

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
                    if (strMessage.Contains("filename="))
                    {
                        strFileName = strMessage.Substring(strMessage.IndexOf('=')+1);
                        nsWriter.WriteLine("ack");
                        nsWriter.Flush();
                        continue;
                    }
                    String strResponse = HandleMessage(strMessage, strFileName);
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

        private String HandleMessage(String strMessage, String strFileName)
        {
            if (strMessage.Equals("getdb"))
            {
                String strDBContents = "";
                StreamReader fileReader = new StreamReader(".\\Expenses.csv");
                strDBContents = fileReader.ReadToEnd();
                fileReader.Close();
                strDBContents = strDBContents.Replace(System.Environment.NewLine, "|");
                //strDBContents = strDBContents + System.Environment.NewLine;
                return strDBContents;
            }
            else
            {
                String strFilePath = Settings.Instance().ServerCacheDir;
                strFilePath = strFilePath + "\\" + strFileName;

                // Create the file if required.
                if (!File.Exists(strFilePath))
                {
                    try
                    {
                        File.Create(strFilePath).Close();
                    }
                    catch (Exception)
                    {
                        return "error";
                    }
                }

                // Write to the file
                StreamWriter fileWriter = new StreamWriter(strFilePath, true);
                fileWriter.WriteLine(strMessage);
                fileWriter.Flush();
                fileWriter.Close();

                return "ack";
            }
        }
   }
}
