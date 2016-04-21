using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
// MAIN

namespace Virtual_OS.Main
{
    public partial class MotherUI : Form
    {
        public string PersonName { get; set; }
        public string LastName { get; set; }

        public MotherUI()
        {
            this.WindowState = FormWindowState.Maximized;

            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;

            XmlDocument dataReader = new XmlDocument();
            dataReader.Load("data/user/info.xml");

            dataReader.SelectSingleNode("//data");

            this.DoubleBuffered = true;

            this.AutoScaleMode = AutoScaleMode.None;

            string name = dataReader.SelectSingleNode("//name").InnerText;
            string surname = dataReader.SelectSingleNode("//last").InnerText;
            PersonName = name;
            LastName = surname;

            WelcomeLabel.Text = $"Welcome, Mr. {PersonName} {LastName}!";

            this.Load += MotherUI_Load;

            Hub.Size = new Size(0, 0);

            LoadApps();


            Main.MainAppClass mainApp = new MainAppClass("");

            mainApp.MdiParent = this;
            mainApp.Visible = true;

            mainApp.Close();
        }

        public void LoadApps()
        {
            XmlDocument appsReader = new XmlDocument();
            appsReader.Load("data/settings/apps.xml");
            appsReader.SelectNodes("//apps");

            for (int i = 0; i < appsReader.SelectNodes("//app").Count; i++)
            {
                string name = appsReader.SelectNodes("//name")[i].InnerText;
                string publisher = appsReader.SelectNodes("//publisher")[i].InnerText;


                ListViewItem appItem = new ListViewItem();
                appItem.Text = $"{name} - By {publisher}!";
                AppsGrid.Items.Add(appItem);
            }

        }

        private void MotherUI_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.Gainsboro;
                    break;
                }
            }
        }

        private void HubButton_Click(object sender, EventArgs e)
        {
            if (Hub.Size == new Size(483, 478))
                Hub.Size = new Size(0, 0);
            else
                Hub.Size = new Size(483, 478);
        }

        private void CloseApp(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Close Virtual_OS?", "Are you sure", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.Owner = this;
            s.MdiParent = this;
            s.Show();
        }

        private void MotherUI_Paint(object sender, PaintEventArgs e)
        {
            // base.OnPaint(e);
            bool glassEnabled = true;
            if (glassEnabled) // draw glass if enabled
            {
                Rectangle rc = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
                e.Graphics.ReleaseHdc();
                e.Graphics.DrawRectangle(new Pen(Color.Red), rc);
            }
        }

        /// <summary>
        /// Show the setup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetupBtn_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            new Login() { Visible = true }.StartRun();
        }

        private void VolumeBtn_Click(object sender, EventArgs e)
        {
            VolumePanel.Visible = !VolumePanel.Visible;
        }

        private void VolumeBar_ValueChanged(object sender, ScrollEventArgs e)
        {
            VolumeLabel.Text = $"{this.VolumeBar.Value.ToString()}%";

        }
        private void RunAppFromHTMLFile(string file, string name, string pub)
        {

            string fileData = "file://" + System.Environment.CurrentDirectory.Replace(@"\", "/") + "/applications/" + name + " - By " + pub + "/" + file;
            Main.MainAppClass mainApp = new MainAppClass(fileData);

            mainApp.MdiParent = this;


            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.Load(System.Environment.CurrentDirectory.Replace(@"\", "/") + "/applications/" + name + " - By " + pub + "/" + file);


            try
            {
                foreach (HtmlAgilityPack.HtmlAttribute item in htmlDoc.DocumentNode.SelectSingleNode("//body").Attributes)
                {
                    if (item.Name == "struct")
                    {

                    }
                }
                foreach (HtmlAgilityPack.HtmlNode noder in htmlDoc.DocumentNode.SelectNodes("//import"))
                {
                    string atri = noder.GetAttributeValue("data", "");
                    // Add the imports
                    if (atri == "System")
                    {
                        mainApp.WebUI.RegisterJsObject("System", new JSCoreSystem(PersonName + " " + LastName), false);
                    }
                    else if (atri == "System.IO")
                    {
                        mainApp.WebUI.RegisterJsObject("IO", new JSCoreSystemIO(), false);
                    }
                    else
                    {
                        string xdm = "file://" + System.Environment.CurrentDirectory.Replace(@"\", "/") + "/applications/" + name + " - By " + pub + "/" + atri;
                        string source = File.ReadAllText(System.Environment.CurrentDirectory + @"\applications\" + name + " - By " + pub + @"\" + atri);
                        foreach (string line in source.Split(';'))
                        {
                            if (line.StartsWith("this."))
                            {
                                string cont = line.Split('.')[1];
                                if (cont.StartsWith("visible"))
                                {
                                    bool isVisible = Convert.ToBoolean(cont.Replace(" ", "").Split('=')[1]);
                                    mainApp.Visible = isVisible;
                                }

                            }
                        }

                    }
                    this.WindowState = FormWindowState.Maximized;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }
        private CompilerResults CompileCode(string codeToCompile)
        {


            Dictionary<string, string> providerOptions = new Dictionary<string, string>
                {
                    {"CompilerVersion", "v3.5"}
                };
            CSharpCodeProvider provider = new CSharpCodeProvider(providerOptions);

            CompilerParameters compilerParams = new CompilerParameters
            {
                GenerateInMemory = true,
                GenerateExecutable = false
            };

            CompilerResults results = provider.CompileAssemblyFromSource(compilerParams, codeToCompile);

            if (results.Errors.Count != 0)
                throw new Exception("Mission failed!");
            return results;
        }
        public class JSCoreSystem
        {
            public string Username { get; }
            public string GetApplicationVersion()
            {
                return "0.2.1.5";
            }

            public JSCoreSystem(string _username)
            {
                Username = _username;
            }
        }
        public class JSCoreSystemIO
        {
            public string ReadAllText(string file)
            {
                string retVal = "";
                try { retVal = System.IO.File.ReadAllText(file); }
                catch (Exception e) { retVal = e.ToString(); }

                return retVal;
            }

            public bool WriteAllText(string filename, string content)
            {
                bool retVal = false;
                try
                {
                    System.IO.File.WriteAllText(filename, content);

                    retVal = true;
                }
                catch
                {
                    retVal = false;
                }
                return retVal;
            }

        }

        private void AppsGrid_DoubleClick(object sender, EventArgs e)
        {
            var cont = AppsGrid.SelectedItems;
            foreach (ListViewItem item in cont)
            {
                if (item.Selected == true)
                {
                    XmlDocument appsReader = new XmlDocument();
                    appsReader.Load("data/settings/apps.xml");
                    appsReader.SelectNodes("//apps");

                    for (int i = 0; i < appsReader.SelectNodes("//app").Count; i++)
                    {
                        string name = appsReader.SelectNodes("//name")[i].InnerText;
                        string publisher = appsReader.SelectNodes("//publisher")[i].InnerText;

                        if ((item.Text.Contains(name)) && (item.Text.Contains(publisher)))
                        {
                            string openCode = appsReader.SelectNodes("//open")[i].InnerText;
                            if (openCode == "settings.open()")
                            {
                                new Settings() { MdiParent = this }.Visible = true;
                            }
                            else if (openCode.StartsWith("run"))
                            {
                                string whatToRun = openCode.Split('(', ')')[1];
                                RunAppFromHTMLFile(whatToRun, name, publisher);
                            }
                        }
                    }
                }
            }
        }

        private void ShowDevToolsBtn_Click(object sender, EventArgs e)
        {
            Main.MainAppClass p = new MainAppClass("http://127.0.0.1:8080/");
            p.MdiParent = this;
            p.Show();
        }
    }

}