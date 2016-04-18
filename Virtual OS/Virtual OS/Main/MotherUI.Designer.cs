using MetroFramework.Controls;

namespace Virtual_OS.Main
{
    partial class MotherUI
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
            this.TopPanel = new MetroFramework.Controls.MetroPanel();
            this.VolumeBtn = new System.Windows.Forms.PictureBox();
            this.HubButton = new System.Windows.Forms.PictureBox();
            this.Hub = new MetroFramework.Controls.MetroPanel();
            this.AppsGrid = new System.Windows.Forms.ListView();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.ShowDevToolsBtn = new MetroFramework.Controls.MetroButton();
            this.SetupBtn = new MetroFramework.Controls.MetroButton();
            this.SettingsButton = new MetroFramework.Controls.MetroButton();
            this.ExitBtn = new MetroFramework.Controls.MetroButton();
            this.HubSplitter = new System.Windows.Forms.Splitter();
            this.VolumePanel = new System.Windows.Forms.Panel();
            this.VolumeLabel = new MetroFramework.Controls.MetroLink();
            this.VolumeBar = new MetroFramework.Controls.MetroTrackBar();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HubButton)).BeginInit();
            this.Hub.SuspendLayout();
            this.VolumePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.White;
            this.TopPanel.Controls.Add(this.VolumeBtn);
            this.TopPanel.Controls.Add(this.HubButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.HorizontalScrollbarBarColor = true;
            this.TopPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.TopPanel.HorizontalScrollbarSize = 10;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1306, 37);
            this.TopPanel.Style = MetroFramework.MetroColorStyle.White;
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopPanel.UseCustomBackColor = true;
            this.TopPanel.VerticalScrollbarBarColor = false;
            this.TopPanel.VerticalScrollbarHighlightOnWheel = false;
            this.TopPanel.VerticalScrollbarSize = 10;
            // 
            // VolumeBtn
            // 
            this.VolumeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeBtn.BackColor = System.Drawing.Color.Gray;
            this.VolumeBtn.BackgroundImage = global::Virtual_OS.Properties.Resources.Volume_low_icon;
            this.VolumeBtn.Image = global::Virtual_OS.Properties.Resources.Volume_low_icon;
            this.VolumeBtn.Location = new System.Drawing.Point(1262, 0);
            this.VolumeBtn.Name = "VolumeBtn";
            this.VolumeBtn.Size = new System.Drawing.Size(44, 37);
            this.VolumeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VolumeBtn.TabIndex = 7;
            this.VolumeBtn.TabStop = false;
            this.VolumeBtn.Click += new System.EventHandler(this.VolumeBtn_Click);
            // 
            // HubButton
            // 
            this.HubButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HubButton.Image = global::Virtual_OS.Properties.Resources._365;
            this.HubButton.Location = new System.Drawing.Point(0, 0);
            this.HubButton.Name = "HubButton";
            this.HubButton.Size = new System.Drawing.Size(41, 37);
            this.HubButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HubButton.TabIndex = 3;
            this.HubButton.TabStop = false;
            this.HubButton.Click += new System.EventHandler(this.HubButton_Click);
            // 
            // Hub
            // 
            this.Hub.BackColor = System.Drawing.Color.Gray;
            this.Hub.Controls.Add(this.AppsGrid);
            this.Hub.Controls.Add(this.WelcomeLabel);
            this.Hub.Controls.Add(this.ShowDevToolsBtn);
            this.Hub.Controls.Add(this.SetupBtn);
            this.Hub.Controls.Add(this.SettingsButton);
            this.Hub.Controls.Add(this.ExitBtn);
            this.Hub.Controls.Add(this.HubSplitter);
            this.Hub.HorizontalScrollbarBarColor = true;
            this.Hub.HorizontalScrollbarHighlightOnWheel = false;
            this.Hub.HorizontalScrollbarSize = 10;
            this.Hub.Location = new System.Drawing.Point(12, 43);
            this.Hub.Name = "Hub";
            this.Hub.Size = new System.Drawing.Size(483, 478);
            this.Hub.TabIndex = 2;
            this.Hub.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Hub.VerticalScrollbarBarColor = true;
            this.Hub.VerticalScrollbarHighlightOnWheel = false;
            this.Hub.VerticalScrollbarSize = 10;
            // 
            // AppsGrid
            // 
            this.AppsGrid.Location = new System.Drawing.Point(6, 23);
            this.AppsGrid.MultiSelect = false;
            this.AppsGrid.Name = "AppsGrid";
            this.AppsGrid.Size = new System.Drawing.Size(329, 452);
            this.AppsGrid.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.AppsGrid.TabIndex = 11;
            this.AppsGrid.UseCompatibleStateImageBehavior = false;
            this.AppsGrid.View = System.Windows.Forms.View.Tile;
            this.AppsGrid.DoubleClick += new System.EventHandler(this.AppsGrid_DoubleClick);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.WelcomeLabel.Location = new System.Drawing.Point(3, 3);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(94, 17);
            this.WelcomeLabel.TabIndex = 10;
            this.WelcomeLabel.Text = "Hello, ADMIN!";
            // 
            // ShowDevToolsBtn
            // 
            this.ShowDevToolsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowDevToolsBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ShowDevToolsBtn.Location = new System.Drawing.Point(341, 292);
            this.ShowDevToolsBtn.Name = "ShowDevToolsBtn";
            this.ShowDevToolsBtn.Size = new System.Drawing.Size(142, 42);
            this.ShowDevToolsBtn.TabIndex = 9;
            this.ShowDevToolsBtn.Text = "Dev Tools";
            this.ShowDevToolsBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ShowDevToolsBtn.UseSelectable = true;
            this.ShowDevToolsBtn.Click += new System.EventHandler(this.ShowDevToolsBtn_Click);
            // 
            // SetupBtn
            // 
            this.SetupBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetupBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.SetupBtn.Location = new System.Drawing.Point(341, 340);
            this.SetupBtn.Name = "SetupBtn";
            this.SetupBtn.Size = new System.Drawing.Size(142, 42);
            this.SetupBtn.TabIndex = 9;
            this.SetupBtn.Text = "Setup";
            this.SetupBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SetupBtn.UseSelectable = true;
            this.SetupBtn.Click += new System.EventHandler(this.SetupBtn_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.SettingsButton.Location = new System.Drawing.Point(341, 388);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(142, 42);
            this.SettingsButton.TabIndex = 9;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SettingsButton.UseSelectable = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ExitBtn.Location = new System.Drawing.Point(341, 436);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(142, 42);
            this.ExitBtn.TabIndex = 9;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ExitBtn.UseSelectable = true;
            this.ExitBtn.Click += new System.EventHandler(this.CloseApp);
            // 
            // HubSplitter
            // 
            this.HubSplitter.BackColor = System.Drawing.SystemColors.Control;
            this.HubSplitter.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.HubSplitter.Location = new System.Drawing.Point(0, 0);
            this.HubSplitter.Name = "HubSplitter";
            this.HubSplitter.Size = new System.Drawing.Size(341, 478);
            this.HubSplitter.TabIndex = 0;
            this.HubSplitter.TabStop = false;
            // 
            // VolumePanel
            // 
            this.VolumePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumePanel.BackColor = System.Drawing.Color.DimGray;
            this.VolumePanel.Controls.Add(this.VolumeLabel);
            this.VolumePanel.Controls.Add(this.VolumeBar);
            this.VolumePanel.Location = new System.Drawing.Point(997, 46);
            this.VolumePanel.Name = "VolumePanel";
            this.VolumePanel.Size = new System.Drawing.Size(297, 111);
            this.VolumePanel.TabIndex = 4;
            this.VolumePanel.Visible = false;
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(107, 13);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(82, 27);
            this.VolumeLabel.TabIndex = 7;
            this.VolumeLabel.Text = "50%";
            this.VolumeLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.VolumeLabel.UseSelectable = true;
            // 
            // VolumeBar
            // 
            this.VolumeBar.BackColor = System.Drawing.Color.Transparent;
            this.VolumeBar.Location = new System.Drawing.Point(15, 13);
            this.VolumeBar.MouseWheelBarPartitions = 1;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(266, 85);
            this.VolumeBar.TabIndex = 6;
            this.VolumeBar.Text = "Volume";
            this.VolumeBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.VolumeBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VolumeBar_ValueChanged);
            // 
            // MotherUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 782);
            this.Controls.Add(this.VolumePanel);
            this.Controls.Add(this.Hub);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MotherUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MotherUI";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MotherUI_Paint);
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HubButton)).EndInit();
            this.Hub.ResumeLayout(false);
            this.Hub.PerformLayout();
            this.VolumePanel.ResumeLayout(false);
            this.VolumePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroPanel TopPanel;
        private MetroPanel Hub;
        private System.Windows.Forms.PictureBox HubButton;
        private System.Windows.Forms.Splitter HubSplitter;
        private MetroButton ExitBtn;
        private System.Windows.Forms.Label WelcomeLabel;
        private MetroButton SettingsButton;
        private MetroButton SetupBtn;
        private System.Windows.Forms.Panel VolumePanel;
        private MetroTrackBar VolumeBar;
        private System.Windows.Forms.PictureBox VolumeBtn;
        public MetroLink VolumeLabel;
        private System.Windows.Forms.ListView AppsGrid;
        private MetroButton ShowDevToolsBtn;
    }
}