namespace RemindMe
{
    partial class Agenda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.NewTaskButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.MainFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SystemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SystemTrayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AgendaMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemTrayMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewTaskButton
            // 
            this.NewTaskButton.Location = new System.Drawing.Point(9, 274);
            this.NewTaskButton.Name = "NewTaskButton";
            this.NewTaskButton.Size = new System.Drawing.Size(282, 35);
            this.NewTaskButton.TabIndex = 1;
            this.NewTaskButton.Text = "New Task";
            this.NewTaskButton.UseVisualStyleBackColor = true;
            this.NewTaskButton.Click += new System.EventHandler(this.NewTaskButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.Location = new System.Drawing.Point(297, 274);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(35, 35);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MainFlowPanel
            // 
            this.MainFlowPanel.AutoScroll = true;
            this.MainFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MainFlowPanel.Location = new System.Drawing.Point(-3, -2);
            this.MainFlowPanel.Name = "MainFlowPanel";
            this.MainFlowPanel.Size = new System.Drawing.Size(351, 251);
            this.MainFlowPanel.TabIndex = 0;
            this.MainFlowPanel.WrapContents = false;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(8, 258);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(59, 13);
            this.DateLabel.TabIndex = 8;
            this.DateLabel.Text = "Date Label";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SystemTrayIcon
            // 
            this.SystemTrayIcon.ContextMenuStrip = this.SystemTrayMenuStrip;
            this.SystemTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("SystemTrayIcon.Icon")));
            this.SystemTrayIcon.Text = "RemindMe";
            this.SystemTrayIcon.Visible = true;
            this.SystemTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SystemTrayIcon_MouseDoubleClick);
            // 
            // SystemTrayMenuStrip
            // 
            this.SystemTrayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgendaMenuStripItem,
            this.SettingsMenuStripItem,
            this.ExitMenuStripItem});
            this.SystemTrayMenuStrip.Name = "SystemTrayMenuStrip";
            this.SystemTrayMenuStrip.Size = new System.Drawing.Size(117, 70);
            // 
            // AgendaMenuStripItem
            // 
            this.AgendaMenuStripItem.Name = "AgendaMenuStripItem";
            this.AgendaMenuStripItem.Size = new System.Drawing.Size(116, 22);
            this.AgendaMenuStripItem.Text = "Agenda";
            this.AgendaMenuStripItem.Click += new System.EventHandler(this.AgendaMenuStripItem_Click);
            // 
            // SettingsMenuStripItem
            // 
            this.SettingsMenuStripItem.Name = "SettingsMenuStripItem";
            this.SettingsMenuStripItem.Size = new System.Drawing.Size(116, 22);
            this.SettingsMenuStripItem.Text = "Settings";
            this.SettingsMenuStripItem.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ExitMenuStripItem
            // 
            this.ExitMenuStripItem.Name = "ExitMenuStripItem";
            this.ExitMenuStripItem.Size = new System.Drawing.Size(116, 22);
            this.ExitMenuStripItem.Text = "Exit";
            this.ExitMenuStripItem.Click += new System.EventHandler(this.ExitMenuStripItem_Click);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 316);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.MainFlowPanel);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.NewTaskButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Agenda";
            this.Text = "RemindMe - Agenda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Agenda_OnFormClosing);
            this.Load += new System.EventHandler(this.Agenda_Load);
            this.VisibleChanged += new System.EventHandler(this.Agenda_VisibleChanged);
            this.SystemTrayMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewTaskButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.FlowLayoutPanel MainFlowPanel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.NotifyIcon SystemTrayIcon;
        private System.Windows.Forms.ContextMenuStrip SystemTrayMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AgendaMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuStripItem;
    }
}

