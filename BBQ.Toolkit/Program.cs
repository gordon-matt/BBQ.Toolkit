using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BBQ.Toolkit.Common;

namespace BBQ.Toolkit
{
    internal class Program
    {
        public static IEnumerable<IPlugin> Plugins { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Views.HostForm());
        }
    }
}
