namespace Virtual_OS.FirstRun
{
    partial class SetupDialog
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.CopyInfo = new MetroFramework.Controls.MetroLabel();
            this.Done = new MetroFramework.Controls.MetroButton();
            this.UsernameLabel = new MetroFramework.Controls.MetroLabel();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.ShowPass = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.RealNameLabel = new MetroFramework.Controls.MetroLabel();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.CopyInfo);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 637);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1086, 42);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = false;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // CopyInfo
            // 
            this.CopyInfo.AutoSize = true;
            this.CopyInfo.BackColor = System.Drawing.Color.Transparent;
            this.CopyInfo.FontSize = MetroFramework.MetroLabelSize.Small;
            this.CopyInfo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.CopyInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CopyInfo.Location = new System.Drawing.Point(285, 7);
            this.CopyInfo.Name = "CopyInfo";
            this.CopyInfo.Size = new System.Drawing.Size(431, 17);
            this.CopyInfo.Style = MetroFramework.MetroColorStyle.White;
            this.CopyInfo.TabIndex = 4;
            this.CopyInfo.Text = "Setup - VOS - Thanks For Using Virtual OS! Hope you enjoy the 1.0 beta!";
            this.CopyInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Done
            // 
            this.Done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Done.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Done.Location = new System.Drawing.Point(12, 580);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(54, 51);
            this.Done.TabIndex = 7;
            this.Done.Text = "✔";
            this.Done.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Done.UseSelectable = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.UsernameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsernameLabel.Location = new System.Drawing.Point(379, 210);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(78, 20);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "Username:";
            this.UsernameLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UsernameLabel.UseCustomBackColor = true;
            this.UsernameLabel.UseCustomForeColor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.PasswordLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordLabel.Location = new System.Drawing.Point(379, 278);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(67, 17);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PasswordLabel.UseCustomBackColor = true;
            this.PasswordLabel.UseCustomForeColor = true;
            // 
            // ShowPass
            // 
            this.ShowPass.AutoSize = true;
            this.ShowPass.DisplayStatus = false;
            this.ShowPass.Location = new System.Drawing.Point(696, 309);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(50, 21);
            this.ShowPass.TabIndex = 11;
            this.ShowPass.Text = "Off";
            this.ShowPass.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ShowPass.UseSelectable = true;
            this.ShowPass.CheckedChanged += new System.EventHandler(this.ShowPass_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel1.Location = new System.Drawing.Point(625, 308);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 17);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Show:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(379, 233);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(240, 22);
            this.UsernameBox.TabIndex = 12;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(379, 308);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(240, 22);
            this.PasswordBox.TabIndex = 12;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(379, 373);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(125, 22);
            this.NameBox.TabIndex = 14;
            // 
            // RealNameLabel
            // 
            this.RealNameLabel.AutoSize = true;
            this.RealNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.RealNameLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.RealNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.RealNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RealNameLabel.Location = new System.Drawing.Point(379, 343);
            this.RealNameLabel.Name = "RealNameLabel";
            this.RealNameLabel.Size = new System.Drawing.Size(157, 17);
            this.RealNameLabel.TabIndex = 13;
            this.RealNameLabel.Text = "Real Name And Surname:";
            this.RealNameLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RealNameLabel.UseCustomBackColor = true;
            this.RealNameLabel.UseCustomForeColor = true;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(510, 373);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(109, 22);
            this.SurnameBox.TabIndex = 15;
            // 
            // SetupDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.RealNameLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.UsernameLabel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "SetupDialog";
            this.Size = new System.Drawing.Size(1086, 679);
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UseCustomBackColor = true;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel CopyInfo;
        private MetroFramework.Controls.MetroButton Done;
        private MetroFramework.Controls.MetroLabel UsernameLabel;
        private MetroFramework.Controls.MetroLabel PasswordLabel;
        private MetroFramework.Controls.MetroToggle ShowPass;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox NameBox;
        private MetroFramework.Controls.MetroLabel RealNameLabel;
        private System.Windows.Forms.TextBox SurnameBox;
    }
}
