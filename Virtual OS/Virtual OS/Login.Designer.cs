namespace Virtual_OS
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopBar = new MetroFramework.Controls.MetroPanel();
            this.SetUpLabel = new MetroFramework.Controls.MetroLink();
            this.TitleLabel = new MetroFramework.Controls.MetroLabel();
            this.Main = new BlueActivity.Controls.ColorWithAlpha();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.ResetLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CopyInfo = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Done = new MetroFramework.Controls.MetroButton();
            this.ShowPass = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Main2 = new BlueActivity.Controls.ColorWithAlpha();
            this.CloseButton = new MetroFramework.Controls.MetroLink();
            this.TopBar.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.Controls.Add(this.CloseButton);
            this.TopBar.Controls.Add(this.SetUpLabel);
            this.TopBar.Controls.Add(this.TitleLabel);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.HorizontalScrollbarBarColor = true;
            this.TopBar.HorizontalScrollbarHighlightOnWheel = false;
            this.TopBar.HorizontalScrollbarSize = 10;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(1086, 41);
            this.TopBar.Style = MetroFramework.MetroColorStyle.Black;
            this.TopBar.TabIndex = 2;
            this.TopBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopBar.VerticalScrollbarBarColor = false;
            this.TopBar.VerticalScrollbarHighlightOnWheel = false;
            this.TopBar.VerticalScrollbarSize = 10;
            // 
            // SetUpLabel
            // 
            this.SetUpLabel.AutoSize = true;
            this.SetUpLabel.Location = new System.Drawing.Point(1001, 9);
            this.SetUpLabel.Name = "SetUpLabel";
            this.SetUpLabel.Size = new System.Drawing.Size(82, 27);
            this.SetUpLabel.TabIndex = 4;
            this.SetUpLabel.Text = "Set Up";
            this.SetUpLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SetUpLabel.UseSelectable = true;
            this.SetUpLabel.Click += new System.EventHandler(this.Setup);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(88, 20);
            this.TitleLabel.Style = MetroFramework.MetroColorStyle.White;
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Login - VOS";
            this.TitleLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Main
            // 
            this.Main.Alpha = 250;
            this.Main.Color = System.Drawing.Color.Black;
            this.Main.Parent = null;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.ResetLinkLabel);
            this.metroPanel1.Controls.Add(this.CopyInfo);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 678);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1086, 42);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = false;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // ResetLinkLabel
            // 
            this.ResetLinkLabel.AutoSize = true;
            this.ResetLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResetLinkLabel.Location = new System.Drawing.Point(1002, 12);
            this.ResetLinkLabel.Name = "ResetLinkLabel";
            this.ResetLinkLabel.Size = new System.Drawing.Size(53, 17);
            this.ResetLinkLabel.TabIndex = 8;
            this.ResetLinkLabel.TabStop = true;
            this.ResetLinkLabel.Text = "Reset?";
            this.ResetLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ResetLinkLabel_LinkClicked);
            // 
            // CopyInfo
            // 
            this.CopyInfo.AutoSize = true;
            this.CopyInfo.BackColor = System.Drawing.Color.Transparent;
            this.CopyInfo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.CopyInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CopyInfo.Location = new System.Drawing.Point(12, 9);
            this.CopyInfo.Name = "CopyInfo";
            this.CopyInfo.Size = new System.Drawing.Size(482, 20);
            this.CopyInfo.Style = MetroFramework.MetroColorStyle.White;
            this.CopyInfo.TabIndex = 4;
            this.CopyInfo.Text = "Login - VOS - Thanks For Using Virtual_OS! Hope you enjoy the 1.0 beta!";
            this.CopyInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Done);
            this.groupBox1.Controls.Add(this.ShowPass);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.PasswordBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UsernameBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(340, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // Done
            // 
            this.Done.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Done.Location = new System.Drawing.Point(6, 156);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(402, 132);
            this.Done.TabIndex = 8;
            this.Done.Text = "Login";
            this.Done.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Done.UseSelectable = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // ShowPass
            // 
            this.ShowPass.AutoSize = true;
            this.ShowPass.DisplayStatus = false;
            this.ShowPass.Location = new System.Drawing.Point(60, 124);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(50, 21);
            this.ShowPass.TabIndex = 13;
            this.ShowPass.Text = "Off";
            this.ShowPass.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ShowPass.UseSelectable = true;
            this.ShowPass.CheckedChanged += new System.EventHandler(this.ShowPass_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel1.Location = new System.Drawing.Point(6, 124);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 20);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Show:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(10, 99);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(398, 22);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(10, 52);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(398, 22);
            this.UsernameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // Main2
            // 
            this.Main2.Alpha = 200;
            this.Main2.Color = System.Drawing.Color.DimGray;
            this.Main2.Parent = null;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Location = new System.Drawing.Point(913, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(82, 27);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CloseButton.UseSelectable = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Virtual_OS.Properties.Resources.horizon_decline_blue_water_rocks_calm_landscape_46098_1280x720;
            this.ClientSize = new System.Drawing.Size(1086, 720);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel TopBar;
        private BlueActivity.Controls.ColorWithAlpha Main;
        private MetroFramework.Controls.MetroLabel TitleLabel;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel CopyInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroToggle ShowPass;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton Done;
        private BlueActivity.Controls.ColorWithAlpha Main2;
        private System.Windows.Forms.LinkLabel ResetLinkLabel;
        public MetroFramework.Controls.MetroLink SetUpLabel;
        public MetroFramework.Controls.MetroLink CloseButton;
    }
}

