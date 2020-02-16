using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace WatermarkStamper
{
    static class Program
    {
        private static readonly string Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LogManager.LoadConfiguration(@"nlog.config");
            Logger.Info(@"Starting app version {0}", Version);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}