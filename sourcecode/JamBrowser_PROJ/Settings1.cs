using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;

namespace JamBrowser_PROJ
{
    public partial class Settings1 : Form
    {
        List<string> _items = new List<string>();

        bool informload = true;

        public Settings1()
        {
            InitializeComponent();
            this.Size = new Size(461, 339);
            Interface1.Location = new Point(138, 12);
            Interface1.Visible = true;
            Print1.Visible = false;

            _items.Add("Interface");
            _items.Add("Web Browser");

            listBox1.DataSource = _items;

            string internalClock = ConfigurationManager.AppSettings["internalClock"].ToString().Trim().ToUpper();
            if (internalClock == "TRUE")
            {
                checkBox1.Checked = true;
            }

            string networkClock = ConfigurationManager.AppSettings["networkClock"].ToString().Trim().ToUpper();
            if (networkClock == "TRUE")
            {
                checkBox2.Checked = true;
            }

            string smartCal = ConfigurationManager.AppSettings["smartCal"].ToString().Trim().ToUpper();
            if (smartCal == "TRUE")
            {
                checkBox3.Checked = true;
            }     

            string col3 = ConfigurationManager.AppSettings["col3"].ToString().Trim().ToUpper();
            if (col3 == "TRUE")
            {
                radioButton3.Checked = true;
            }       

            string col2 = ConfigurationManager.AppSettings["col2"].ToString().Trim().ToUpper();
            if (col2 == "TRUE")
            {
                radioButton2.Checked = true;
            }       

            string col1 = ConfigurationManager.AppSettings["col1"].ToString().Trim().ToUpper();
            if (col1 == "TRUE")
            {
                radioButton1.Checked = true;
            }

            string ddg = ConfigurationManager.AppSettings["ddg"].ToString().Trim().ToUpper();
            if (ddg == "TRUE")
            {
                radioButton6.Checked = true;
            }      

            string bing = ConfigurationManager.AppSettings["bing"].ToString().Trim().ToUpper();
            if (bing == "TRUE")
            {
                radioButton7.Checked = true;
            }

            string google = ConfigurationManager.AppSettings["google"].ToString().Trim().ToUpper();
            if (google == "TRUE")
            {
                radioButton7.Checked = true;
            }

            string yahoo = ConfigurationManager.AppSettings["yahoo"].ToString().Trim().ToUpper();
            if (yahoo == "TRUE")
            {
                radioButton5.Checked = true;
            }

            informload = false;

            Console.WriteLine("JamBrowser Runtime: Form; 'Settings1.cs' launch successful!");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "Interface")
            {
                Interface1.Location = new Point(138, 12);
                Interface1.Visible = true;
                Print1.Visible = false;
            }

            if (listBox1.SelectedItem.ToString() == "Web Browser")
            {
                Print1.Location = new Point(138, 12);
                Interface1.Visible = false;
                Print1.Visible = true;
            }
        }

        private void Settings1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (informload == false)
            {
                string checkValue = "";
                if (radioButton3.Checked)
                    checkValue = "true";
                else
                    checkValue = "false";
                UpdateSetting("col3", checkValue);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (informload == false)
            {
                string checkValue = "";
                if (radioButton2.Checked)
                    checkValue = "true";
                else
                    checkValue = "false";
                UpdateSetting("col2", checkValue);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (informload == false)
            {
                string checkValue = "";
                if (radioButton1.Checked)
                    checkValue = "true";
                else
                    checkValue = "false";
                UpdateSetting("col1", checkValue);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (informload == false)
            {
                string checkValue = "";
                if (checkBox1.Checked)
                    checkValue = "true";
                else
                    checkValue = "false";
                UpdateSetting("internalClock", checkValue);
            }

            Console.WriteLine("JamBrowser Runtime: Setting saved!");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (informload == false)
            {
                string checkValue = "";
                if (checkBox2.Checked)
                    checkValue = "true";
                else
                    checkValue = "false";
                UpdateSetting("networkClock", checkValue);

                Console.WriteLine("JamBrowser Runtime: Setting saved!");
            }
        }

        private static void UpdateSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.
                OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (informload == false)
            {
                string checkValue = "";
                if (checkBox3.Checked)
                    checkValue = "true";
                else
                    checkValue = "false";
                UpdateSetting("smartCal", checkValue);
            }

            Console.WriteLine("JamBrowser Runtime: Setting saved!");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (informload == false)
            {
                string checkValue = "";
                if (checkBox4.Checked)
                    checkValue = "true";
                else
                    checkValue = "false";
                UpdateSetting("safemd", checkValue);
            }

        }

        private void Print1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (informload == false)
            {
                string checkValue = "";
                if (checkBox5.Checked)
                    checkValue = "true";
                else
                    checkValue = "false";
                UpdateSetting("cldmd", checkValue);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (informload == false)
            {
                string checkValue = "";
                if (radioButton4.Checked)
                    checkValue = "true";
                else
                    checkValue = "false";
                UpdateSetting("google", checkValue);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (informload == false)
            {
                string checkValue = "";
                if (radioButton5.Checked)
                    checkValue = "true";
                else
                    checkValue = "false";
                UpdateSetting("yahoo", checkValue);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (informload == false)
            {
                string checkValue = "";
                if (radioButton6.Checked)
                    checkValue = "true";
                else
                    checkValue = "false";
                UpdateSetting("ddg", checkValue);
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (informload == false)
            {
                string checkValue = "";
                if (radioButton7.Checked)
                    checkValue = "true";
                else
                    checkValue = "false";
                UpdateSetting("bing", checkValue);
            }
        }
    }
}