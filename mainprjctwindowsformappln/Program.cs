using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    static class Program
    {
        public static string str = "";
        public static string text = "";
        public static string key = "";
        public static string decrypttext = "";
        public static string decryptkey = "";
        public static string imagename = "";
        public static string imagetext = "";
        public static bool bold1 = false;
        public static bool italic1 = false;
        public static bool under1 = false;
        public static string ar1 = "";
        public static string ar2 = "";
        public static string tim1 = "";
        public static string font = "";
        public static string end = "";
       

     


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
