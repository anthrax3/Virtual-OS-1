﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_OS.MainSource
{
    public partial class Settings : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Settings()
        {
            InitializeComponent();

            TopBar.MouseMove += TopBar_MouseMove;
            TitleLabel.MouseMove += TopBar_MouseMove;
            

            this.Load += Settings_Load;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Transitions.Transition t = new Transitions.Transition(new Transitions.TransitionType_Acceleration(1000));
            t.add(CloseButton, "Left", 540);
            t.add(TitleLabel, "Top", 10);
            t.run();
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
