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
    public partial class Browser1 : Form
    {
        public Browser1()
        {
            InitializeComponent();
            Console.WriteLine("JamBrowser BootManager: Preparing form; 'Browser1.cs' bootup...");
            System.Threading.Thread.Sleep(3758);
            Console.WriteLine("JamBrowser BootManager: Form; 'Browser1.cs' bootup successful!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("JamBrowser Runtime: Preparing form; 'Settings1.cs' launch...");
            System.Threading.Thread.Sleep(0901);

            Settings1 f2 = new Settings1();
            f2.ShowDialog();
        }

        private void buttonsearch1_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
                web.Navigate(searchbar1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("JamBrowser Runtime: Preparing form; 'Confirm1.cs' launch...");
            System.Threading.Thread.Sleep(0009);
            Console.WriteLine("JamBrowser Runtime: Form; 'Confirm1.cs' launch successful!");

            Confirm1 f2 = new Confirm1();
            f2.ShowDialog();
        }

        private void Browser1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/");
            webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted;
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = webBrowser1.DocumentTitle;
        }

        private void searchbar1_TextChanged(object sender, EventArgs e)
        {

        }

        WebBrowser webTab = null;

        private void buttonnewpage1_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);
            webTab = new WebBrowser() {ScriptErrorsSuppressed = true};
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate("https://www.google.com/");
            searchbar1.Text = "https://www.google.com/";
            webTab.DocumentCompleted += WebTab_DocumentCompleted;

            Console.WriteLine("JamBrowser Runtime: Created new tab on 'https://www.google.com'...");
        }

        private void WebTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = webTab.DocumentTitle;
        }

        private void buttonback1_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoBack)
                    web.GoBack();
            }
        }

        private void buttonfoward1_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoForward)
                    web.GoForward();
            }
        }

        private void searchbar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
                    if (web != null)
                    {
                        web.Navigate(searchbar1.Text);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error: You must create a new tab before searching something!");
            }
        }

        private void buttonclosepage1_Click(object sender, EventArgs e)
        {
            try
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            catch
            {
                MessageBox.Show("Error: Can't close an already closed tab!");
            }

            Console.WriteLine("JamBrowser Runtime: Removed tab 'current'...");
        }
    }
}