namespace RemindMe
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.AlarmVolumeSlider = new System.Windows.Forms.TrackBar();
            this.AlarmVolumeLabel = new System.Windows.Forms.Label();
            this.HeaderLabelSeperator = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.currentVolumeLabel = new System.Windows.Forms.Label();
            this.SystemTrayCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmVolumeSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // AlarmVolumeSlider
            // 
            this.AlarmVolumeSlider.Location = new System.Drawing.Point(133, 12);
            this.AlarmVolumeSlider.Maximum = 100;
            this.AlarmVolumeSlider.Name = "AlarmVolumeSlider";
            this.AlarmVolumeSlider.Size = new System.Drawing.Size(182, 45);
            this.AlarmVolumeSlider.TabIndex = 0;
            this.AlarmVolumeSlider.Scroll += new System.EventHandler(this.AlarmVolumeSlider_Scroll);
            // 
            // AlarmVolumeLabel
            // 
            this.AlarmVolumeLabel.AutoSize = true;
            this.AlarmVolumeLabel.Location = new System.Drawing.Point(12, 12);
            this.AlarmVolumeLabel.Name = "AlarmVolumeLabel";
            this.AlarmVolumeLabel.Size = new System.Drawing.Size(74, 13);
            this.AlarmVolumeLabel.TabIndex = 3;
            this.AlarmVolumeLabel.Text = "Alarm Volume:";
            // 
            // HeaderLabelSeperator
            // 
            this.HeaderLabelSeperator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HeaderLabelSeperator.Location = new System.Drawing.Point(1, 50);
            this.HeaderLabelSeperator.Name = "HeaderLabelSeperator";
            this.HeaderLabelSeperator.Size = new System.Drawing.Size(400, 1);
            this.HeaderLabelSeperator.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(1, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 1);
            this.label1.TabIndex = 9;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 102);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(303, 38);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save and Exit";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 146);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(303, 38);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit Without Saving";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // currentVolumeLabel
            // 
            this.currentVolumeLabel.Location = new System.Drawing.Point(83, 7);
            this.currentVolumeLabel.Name = "currentVolumeLabel";
            this.currentVolumeLabel.Size = new System.Drawing.Size(35, 23);
            this.currentVolumeLabel.TabIndex = 12;
            this.currentVolumeLabel.Text = "0%";
            this.currentVolumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SystemTrayCheckBox
            // 
            this.SystemTrayCheckBox.AutoSize = true;
            this.SystemTrayCheckBox.Location = new System.Drawing.Point(15, 61);
            this.SystemTrayCheckBox.Name = "SystemTrayCheckBox";
            this.SystemTrayCheckBox.Size = new System.Drawing.Size(139, 17);
            this.SystemTrayCheckBox.TabIndex = 2;
            this.SystemTrayCheckBox.Text = "Minimize to System Tray";
            this.SystemTrayCheckBox.UseVisualStyleBackColor = true;
            this.SystemTrayCheckBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SystemTrayCheckBox_KeyDown);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 193);
            this.Controls.Add(this.SystemTrayCheckBox);
            this.Controls.Add(this.currentVolumeLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeaderLabelSeperator);
            this.Controls.Add(this.AlarmVolumeLabel);
            this.Controls.Add(this.AlarmVolumeSlider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RemindMe - Settings";
            this.Deactivate += new System.EventHandler(this.SettingsForm_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.LoadSettings);
            ((System.ComponentModel.ISupportInitialize)(this.AlarmVolumeSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar AlarmVolumeSlider;
        private System.Windows.Forms.Label AlarmVolumeLabel;
        private System.Windows.Forms.Label HeaderLabelSeperator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label currentVolumeLabel;
        private System.Windows.Forms.CheckBox SystemTrayCheckBox;
    }
}