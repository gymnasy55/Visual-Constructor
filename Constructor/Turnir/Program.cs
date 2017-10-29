using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace turnir
{
    static class DataCol
    {
        public static int Value { get; set; }
        public static int Value1 { get; set; }
    }
    static class DataRow
    {
        public static int Value { get; set; }
        public static int Value1 { get; set; }
    }
    static class DataName
    {
        public static string Value { get; set; }
        public static string Value1 { get; set; }
    }
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
            Application.Run(new MainMenu());
        }
    }
}
