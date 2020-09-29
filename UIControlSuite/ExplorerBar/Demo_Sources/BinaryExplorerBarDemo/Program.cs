using System;
using System.Windows.Forms;

namespace BinaryExplorerBarDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BinaryExplorerBarDemoForm());
        }
    }
}