using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OCR
{
    static class Program
    {
        public static string str = "";
        public static string text = "";
        public static string key = "";
        public static string decrypttext = "";
        public static string decryptkey = "";
        public static string ende = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new word());
        }
    }
}
