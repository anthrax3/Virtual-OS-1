using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using MetroFramework;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Virtual_OS
{
    public partial class Login : Form
    {
        // Props
        public String Title
        {

            get
            {
                return TitleLabel.Text;

            }
            set
            {
                TitleLabel.Text = Title;
            }
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Login()
        {
            InitializeComponent();

            this.TopBar.MouseMove += TopBar_MouseMove;
            this.TitleLabel.MouseMove += TopBar_MouseMove;

            this.DoubleBuffered = true;

            //if (!Properties.Settings.Default.firstRun == true)
            //    SetUpLabel.Enabled = false;
        }

        private void Setup(object sender, EventArgs e)
        {

            if (MetroFramework.MetroMessageBox.Show(this, "Would you like to set Virtual_OS up?\r\nIf not, The defualt admin info can be located at the documentation...\r\n\r\nThank you for using Virtual_OS!", "First Run?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SetUpLabel.Enabled = false;
                FirstRun.SetupDialog sdp = new FirstRun.SetupDialog();
                sdp.Top = 33;
                this.Controls.Clear();
                this.Controls.Add(sdp);
                this.Controls.Add(TopBar);
            }

        }

        public void StartRun()
        {
            SetUpLabel.Enabled = false;
            FirstRun.SetupDialog sdp = new FirstRun.SetupDialog();
            sdp.Top = 33;
            this.Controls.Clear();
            this.Controls.Add(sdp);
            this.Controls.Add(TopBar);
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            this.PasswordBox.UseSystemPasswordChar = !ShowPass.Checked;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            // Create the XMLReader
            XmlDocument dataReader = new XmlDocument();
            dataReader.Load("data/user/info.xml");

            dataReader.SelectSingleNode("//data");
             // Check if data is correct
            if (UsernameBox.Text == dataReader.SelectSingleNode("//username").InnerText && dataReader.SelectSingleNode("//password").InnerText == PasswordBox.Text)
            {
                Virtual_OS.MainSource.MotherUI ms = new Virtual_OS.MainSource.MotherUI();
                ms.Show();
                this.Hide();

            }
            else
            {
                MetroMessageBox.Show(this, "Invailid Credentials!", "Check Username or Password!");
            }
        }

        private void ResetLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Properties.Settings.Default.firstRun = false;
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
