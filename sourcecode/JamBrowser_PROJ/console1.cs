using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Activities;
using System.AddIn;
using System.CodeDom;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;

namespace JamBrowser_PROJ
{
    class console1
    {
        //remove close and minimize button from console window
        //
        private const int MF_BYCOMMAND = 0x00000000;
        public const int SC_CLOSE = 0xF060;
        public const int SC_MINIMIZE = 0xF020;

        [DllImport("user32.dll")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        //

        [STAThread]

        static void Main(string[] args)
        {
            //also remove close and minimize button from console window
            //
            DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), SC_CLOSE, MF_BYCOMMAND);
            DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), SC_MINIMIZE, MF_BYCOMMAND);
            //

            string colorcode = "#FFFFFF00";
            int argb = Int32.Parse(colorcode.Replace("#", ""), NumberStyles.HexNumber);
            Color clr = Color.FromArgb(argb);

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("#####################################################");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("JamBrowser launched successfully on version 'latest!'");
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("#####################################################");
            Console.ResetColor();

            Application.Run(new Browser1());

            Environment.Exit(0);

            while (Console.ReadKey().Key != ConsoleKey.End) {}
        }

        internal static void Maximize()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch
            {
                //keep going
            }
            
        }
    }
}