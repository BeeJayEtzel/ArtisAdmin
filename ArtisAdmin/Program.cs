using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtisAdmin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static ARTISLAB.ArtisLabInfoServiceSoapClient ARTISClient;
        public static String TOKEN = "2D-DC-61-11-52-B1-3D";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ARTISClient = new ARTISLAB.ArtisLabInfoServiceSoapClient("ArtisLabInfoServiceSoap");
            Application.Run(new MainWindow());
        }
    }
}
