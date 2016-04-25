using CefSharp;
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

namespace Virtual_OS.MainSource
{
    public partial class MotherUI : Form
    {
        public string PersonName { get; set; }
        public string LastName { get; set; }

        private bool hubVisible = false;
        private bool volVisible = false;

        public MotherUI()
        {
            this.WindowState = FormWindowState.Maximized;

            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;

            XmlDocument dataReader = new XmlDocument();
            dataReader.Load("data/user/info.xml");

            dataReader.SelectSingleNode("//data");
            // More dpi fixes
            this.DoubleBuffered = true;

            this.AutoScaleMode = AutoScaleMode.None;

            string name = dataReader.SelectSingleNode("//name").InnerText;
            string surname = dataReader.SelectSingleNode("//last").InnerText;
            PersonName = name;
            LastName = surname;
			  // Set the welcome label
            WelcomeLabel.Text = $"Welcome, Mr. {PersonName} {LastName}!";

            this.Load += MotherUI_Load;

            VolumeLabel.UseSelectable = false;
            VolumeBar.UseSelectable = false;

            LoadApps();

			  // A small dpi issue fix
            MainAppClass mainApp = new MainAppClass("");

            mainApp.MdiParent = this;
            mainApp.Visible = true;

            mainApp.Close();

            // Reset the on-Screen-Controls...
            Hub.Left = -500;
            VolumePanel.Top = -100;
        }

        public void LoadApps()
        {
            XmlDocument appsReader = new XmlDocument();
            appsReader.Load("data/settings/apps.xml");
            appsReader.SelectNodes("//apps");
			  AppsGrid.Items.Clear();

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
            if (hubVisible)
            {
                Transitions.Transition t = new Transitions.Transition(new Transitions.TransitionType_Deceleration(1000));
                t.add(Hub, "Left", -500);
                t.run();
                hubVisible = !hubVisible;
            }
            else
            {
                Transitions.Transition t = new Transitions.Transition(new Transitions.TransitionType_Deceleration(1000));
                t.add(Hub, "Left", 12);
                t.run();
                hubVisible = !hubVisible;
            }
        }

        private void CloseApp(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Close Virtual_OS?", "Are you sure", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void MotherUI_Paint(object sender, PaintEventArgs e)
        {
            
        }
        
        private void SetupBtn_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            new Login() { Visible = true }.StartRun();
        }

        private void VolumeBtn_Click(object sender, EventArgs e)
        {
            if (volVisible)
            {
                Transitions.Transition t = new Transitions.Transition(new Transitions.TransitionType_Deceleration(1000));
                t.add(VolumePanel, "Top", -100);
                t.run();
                volVisible = !volVisible;
            }
            else
            {
                Transitions.Transition t = new Transitions.Transition(new Transitions.TransitionType_Deceleration(1000));
                t.add(VolumePanel, "Top", 50);
                t.run();
                volVisible = !volVisible;
            }
        }

        private void VolumeBar_ValueChanged(object sender, ScrollEventArgs e)
        {
            VolumeLabel.Text = $"{this.VolumeBar.Value.ToString()}%";

        }
        private void RunAppFromHTMLFile(string file, string name, string pub)
        {
            string fileData = "file://" + System.Environment.CurrentDirectory.Replace(@"\", "/") + "/applications/" + name + " - By " + pub + "/" + file;
            MainAppClass mainApp = new MainAppClass(fileData);

            mainApp.MdiParent = this;


            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.Load(System.Environment.CurrentDirectory.Replace(@"\", "/") + "/applications/" + name + " - By " + pub + "/" + file);
            
            try
            {
                foreach (HtmlAgilityPack.HtmlNode noder in htmlDoc.DocumentNode.SelectNodes("//import"))
                {
                    string atri = noder.GetAttributeValue("data", "");
                    // Add the imports
                    if (atri == "System")
                    {
                        mainApp.WebUI.RegisterJsObject("System", new JSCoreSystem(), false);
                    }
                    else if (atri == "System.IO")
                    {
                        mainApp.WebUI.RegisterJsObject("IO", new MainSource.JSCoreIO(), false);
                    }
                    else if (atri == "System.Values")
                    {
                        mainApp.WebUI.RegisterJsObject("Values", new Values(PersonName + LastName, PersonName, LastName), false);
                    }
                    this.WindowState = FormWindowState.Maximized;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            mainApp.Visible = true;

        }
        public class Values
        {
            public string Username { get; }
            public string LastName { get; }
            public string FirstName { get; }

            public Values(string username, string name, string surname)
            {
                Username = username;
                LastName = surname;
                FirstName = name;
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
                                Settings s = new Settings();
                                s.Owner = this;
                                s.MdiParent = this;
                                s.Show();
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
            MainAppClass p = new MainAppClass("http://127.0.0.1:8080/");
            p.MdiParent = this;
            p.Show();
            
        }
        
        public void InstallApp()
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                string nameFile = new Random().Next(0, 9999).ToString();
                Directory.CreateDirectory(nameFile);

                System.IO.Compression.ZipFile.ExtractToDirectory(op.FileName, nameFile);
                String[] data = File.ReadAllText(nameFile + "/app.txt").Split(',');

                string appname = $"{data[0]} - By {data[1]}";

                Directory.CreateDirectory("applications/" + appname);

                if (File.Exists(appname + "/index.html"))
                    File.Delete(appname + "/index.html");

                File.Copy(nameFile + "/index.html", "applications/" + appname + "/index.html");

                XmlDocument xdm = new XmlDocument();
                xdm.Load("data/settings/apps.xml");

                XmlNode app = xdm.CreateElement("app");

                XmlNode publisher = xdm.CreateElement("publisher");
                publisher.InnerText = data[1];

                XmlNode name = xdm.CreateElement("name");
                name.InnerText = data[0];

                XmlNode open = xdm.CreateElement("open");
                open.InnerText = "run(index.html)";

                app.AppendChild(name);
                app.AppendChild(open);
                app.AppendChild(publisher);

                xdm.DocumentElement.AppendChild(app);
                xdm.Save("data/settings/apps.xml");
                MessageBox.Show(xdm.InnerXml);
                foreach (string file in Directory.GetFiles(nameFile))
                {
                    File.Delete(file);

                }
                Directory.Delete(nameFile);
            }
        }

        private void AppsGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}