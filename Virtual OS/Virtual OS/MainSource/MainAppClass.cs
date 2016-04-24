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
using System.Threading;

namespace Virtual_OS.MainSource
{
    public partial class MainAppClass : Form
    {
        public CefSharp.WinForms.ChromiumWebBrowser WebUI;

        public MainAppClass(string URL)
        {
            InitializeComponent();
            // Init CEFSHARP 

            if (!Cef.IsInitialized)
            {
                CefSettings s = new CefSettings();
                s.UserAgent = "VOS/1.0 (Windows NT 9.2; WOW64) AppleWebKit/537.36 Chrome/49.0.2623.28 Safari/537.36";
                s.RemoteDebuggingPort = 8080;
                Cef.Initialize(s, true, false);
            }
            

            WebUI = new CefSharp.WinForms.ChromiumWebBrowser(URL);


            WebUI.Dock = DockStyle.Fill;
            this.Controls.Add(WebUI);

            Cef.EnableHighDPISupport();

            WebUI.TitleChanged += WebUI_TitleChanged;

            WebUI.Dock = DockStyle.Fill;

        }
        
        private void WebUI_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Text = e.Title;
        }
    }
}
