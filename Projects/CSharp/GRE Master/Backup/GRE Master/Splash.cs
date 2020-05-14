using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace GRE_Master
{
    public partial class Splash : Form
    {
        private Boolean bInitialized;
        private Serializer serializer;
        private int iProgressLevel;
        static Splash splash;

        private Splash()
        {
            InitializeComponent();
            iProgressLevel = 0;
            
        }

        private Splash(Serializer ser)
            : this()
        {
            serializer = ser;
        }
            
        private void Spash_Load(object sender, EventArgs e)
        {
            bInitialized = false;
        }
        
        public Boolean IsInitialized()
        {
            return bInitialized;
        }

        private void Spash_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bInitialized)
            {
                e.Cancel = true;
            }
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            if (serializer != null)
            {
                int iPercent = serializer.GetPercentSerialized();
                iProgressLevel = iPercent;
                if (iPercent == 100)
                {
                    bInitialized = true;
                    this.Close();
                }
            }
            pbLoading.Value = iProgressLevel;
            this.Refresh();
        }

        public static void ShowSplashScreen(Serializer ser)
        {
            if (splash != null)
                return;

            Thread splashThread = new Thread(new ParameterizedThreadStart(Splash.ShowForm));
            splashThread.IsBackground = true;
            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start(ser);
        }

        private static void ShowForm(Object ser)
        {
            splash = new Splash((Serializer)ser);
            Application.Run(splash);
        }

        private void tmrfancy_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 100)
            {
                this.Opacity = this.Opacity + 1;
                this.Refresh();
            }
        }
    }
}
