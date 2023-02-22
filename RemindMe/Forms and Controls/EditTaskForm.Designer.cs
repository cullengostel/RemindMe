namespace RemindMe
{
    partial class EditTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTaskForm));
            this.TaskNameTextBox = new System.Windows.Forms.TextBox();
            this.AlarmCheckBox = new System.Windows.Forms.CheckBox();
            this.TaskNameLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.SaveTaskButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AlarmLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskNameTextBox
            // 
            this.TaskNameTextBox.Location = new System.Drawing.Point(83, 5);
            this.TaskNameTextBox.MaxLength = 26;
            this.TaskNameTextBox.Name = "TaskNameTextBox";
            this.TaskNameTextBox.Size = new System.Drawing.Size(196, 20);
            this.TaskNameTextBox.TabIndex = 0;
            // 
            // AlarmCheckBox
            // 
            this.AlarmCheckBox.AutoSize = true;
            this.AlarmCheckBox.Location = new System.Drawing.Point(83, 57);
            this.AlarmCheckBox.Name = "AlarmCheckBox";
            this.AlarmCheckBox.Size = new System.Drawing.Size(59, 17);
            this.AlarmCheckBox.TabIndex = 2;
            this.AlarmCheckBox.Text = "On/Off";
            this.AlarmCheckBox.UseVisualStyleBackColor = true;
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Location = new System.Drawing.Point(5, 5);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(65, 13);
            this.TaskNameLabel.TabIndex = 3;
            this.TaskNameLabel.Text = "Task Name:";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(5, 31);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(58, 13);
            this.StartTimeLabel.TabIndex = 4;
            this.StartTimeLabel.Text = "Start Time:";
            // 
            // SaveTaskButton
            // 
            this.SaveTaskButton.Location = new System.Drawing.Point(8, 85);
            this.SaveTaskButton.Name = "SaveTaskButton";
            this.SaveTaskButton.Size = new System.Drawing.Size(271, 31);
            this.SaveTaskButton.TabIndex = 4;
            this.SaveTaskButton.Text = "Save Task";
            this.SaveTaskButton.UseVisualStyleBackColor = true;
            this.SaveTaskButton.Click += new System.EventHandler(this.SaveTaskButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(8, 122);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(271, 31);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CustomFormat = "";
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimePicker.Location = new System.Drawing.Point(83, 31);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.Size = new System.Drawing.Size(196, 20);
            this.StartTimePicker.TabIndex = 1;
            // 
            // AlarmLabel
            // 
            this.AlarmLabel.AutoSize = true;
            this.AlarmLabel.Location = new System.Drawing.Point(5, 57);
            this.AlarmLabel.Name = "AlarmLabel";
            this.AlarmLabel.Size = new System.Drawing.Size(36, 13);
            this.AlarmLabel.TabIndex = 13;
            this.AlarmLabel.Text = "Alarm:";
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 162);
            this.Controls.Add(this.AlarmLabel);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveTaskButton);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.TaskNameLabel);
            this.Controls.Add(this.AlarmCheckBox);
            this.Controls.Add(this.TaskNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RemindMe - Edit Task";
            this.Deactivate += new System.EventHandler(this.EditTaskForm_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditTaskForm_FormClosed);
            this.Load += new System.EventHandler(this.EditTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TaskNameTextBox;
        private System.Windows.Forms.CheckBox AlarmCheckBox;
        private System.Windows.Forms.Label TaskNameLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Button SaveTaskButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.Label AlarmLabel;
    }
}