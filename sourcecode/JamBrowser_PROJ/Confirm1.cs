using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamBrowser_PROJ
{
    public partial class Confirm1 : Form
    {
        private const int CP_DISABLE_CLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CP_DISABLE_CLOSE_BUTTON;
                return cp;
            }
        }

        public Confirm1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("JamBrowser Runtime: Preparing 'Confirm1.cs' shutdown...");
            Console.WriteLine("JamBrowser Runtime: Done!...");

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(0001);
            this.WindowState = FormWindowState.Minimized;
            this.Close();

            console1.Maximize();

            Console.WriteLine("JamBrowser Bootup: Preparing 'JamBrowser' shutdown...");
            System.Threading.Thread.Sleep(0901);
            Console.WriteLine("JamBrowser Bootup: Saving data...");
            System.Threading.Thread.Sleep(0301);
            Console.WriteLine("JamBrowser Bootup: Done!...");
            System.Threading.Thread.Sleep(2111);

            this.Close();
            Browser1 obj = (Browser1)Application.OpenForms["Browser1"];
            obj.Close();
        }

        private void Confirm1_Load(object sender, EventArgs e)
        {

        }
    }
}