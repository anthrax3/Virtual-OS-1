using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MetroFramework;
using System.Windows.Forms;

namespace Virtual_OS.FirstRun
{
    public partial class SetupDialog : MetroFramework.Controls.MetroUserControl
    {
        public static bool isDone { get; set; }
        public IWin32Window Owner { get; set; }

        public SetupDialog()
        {
            InitializeComponent();

            ShowPass.Text = "Show Password";
        }

        private void Done_Click(object sender, EventArgs e)
        {

            if (PasswordBox.Text == "" || UsernameBox.Text == "" || NameBox.Text == "" || SurnameBox.Text == "")
            {
                MetroMessageBox.Show(this, "One of the needed fields are empty.", "Empty Value!");
            }

            else
            {
                if (PasswordBox.Text.Length < 8)
                {
                    MetroMessageBox.Show(this, "The password is to short, It should be 8 characters or more.", "Short Password!");
                }
                else {
                    XmlDocument dataReader = new XmlDocument();
                    dataReader.Load("data/user/info.xml");

                    dataReader.SelectSingleNode("//data");

                    dataReader.SelectSingleNode("//name").InnerText = NameBox.Text;
                    dataReader.SelectSingleNode("//last").InnerText = SurnameBox.Text;

                    dataReader.SelectSingleNode("//username").InnerText = UsernameBox.Text;
                    dataReader.SelectSingleNode("//password").InnerText = PasswordBox.Text;

                    dataReader.Save("data/user/info.xml");

                    MetroMessageBox.Show(this, "Done, You are all set up!\r\nYou can change these later in settings!\r\n\r\nA Restart Will Be Reqiured!", "Done!");

                    Properties.Settings.Default.firstRun = false;
                    Properties.Settings.Default.Save();

                    System.Windows.Forms.Application.Exit();
                }

            }
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            PasswordBox.UseSystemPasswordChar = !ShowPass.Checked;
        }
    }
}
