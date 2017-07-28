using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BBQ.Toolkit.Common;

namespace BBQ.Toolkit
{
    static class Program
    {
        public static IEnumerable<IPlugin> Plugins { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Views.HostForm());
        }
    }
}
