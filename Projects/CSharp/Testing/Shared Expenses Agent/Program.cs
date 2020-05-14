using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Snooper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Agent());
            if (args[0] == "client")
            {
                Client c = new Client();
                while (true)
                {
                }
            }
            else if (args[0] == "server")
            {
                Server s = new Server();
                while (true)
                {

                }
            }
        }
    }
}
