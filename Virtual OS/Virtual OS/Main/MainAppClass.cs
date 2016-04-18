using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;

namespace Virtual_OS.Main
{
    public partial class MainAppClass : Form
    {
        public CefSharp.WinForms.ChromiumWebBrowser WebUI;

        public MainAppClass(string URL)
        {
            if (!Cef.IsInitialized)
            {
                CefSettings s = new CefSettings();
                s.RemoteDebuggingPort = 8080;
                Cef.Initialize(s, true, false);
            }
            InitializeComponent();

            WebUI = new CefSharp.WinForms.ChromiumWebBrowser(URL);

            WebUI.Dock = DockStyle.Fill;
            this.Controls.Add(WebUI);

            Cef.EnableHighDPISupport();



            WebUI.Dock = DockStyle.Fill;

        }

    }
}
