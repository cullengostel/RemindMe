namespace RemindMe
{
    partial class NewTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTaskForm));
            this.TaskNameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.CreateTaskAndExitButton = new System.Windows.Forms.Button();
            this.AlarmCheckBox = new System.Windows.Forms.CheckBox();
            this.AlarmLabel = new System.Windows.Forms.Label();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TaskNameTextBox
            // 
            this.TaskNameTextBox.Location = new System.Drawing.Point(83, 8);
            this.TaskNameTextBox.MaxLength = 26;
            this.TaskNameTextBox.Name = "TaskNameTextBox";
            this.TaskNameTextBox.Size = new System.Drawing.Size(196, 20);
            this.TaskNameTextBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(2, 8);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(65, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Task Name:";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(2, 34);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(58, 13);
            this.StartTimeLabel.TabIndex = 3;
            this.StartTimeLabel.Text = "Start Time:";
            // 
            // CreateTaskButton
            // 
            this.CreateTaskButton.Location = new System.Drawing.Point(5, 90);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Size = new System.Drawing.Size(274, 31);
            this.CreateTaskButton.TabIndex = 3;
            this.CreateTaskButton.Text = "Create Task";
            this.CreateTaskButton.UseVisualStyleBackColor = true;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // CreateTaskAndExitButton
            // 
            this.CreateTaskAndExitButton.Location = new System.Drawing.Point(5, 127);
            this.CreateTaskAndExitButton.Name = "CreateTaskAndExitButton";
            this.CreateTaskAndExitButton.Size = new System.Drawing.Size(274, 31);
            this.CreateTaskAndExitButton.TabIndex = 4;
            this.CreateTaskAndExitButton.Text = "Create Task and Exit ";
            this.CreateTaskAndExitButton.UseVisualStyleBackColor = true;
            this.CreateTaskAndExitButton.Click += new System.EventHandler(this.CreateTaskAndExitButton_Click);
            // 
            // AlarmCheckBox
            // 
            this.AlarmCheckBox.AutoSize = true;
            this.AlarmCheckBox.Location = new System.Drawing.Point(83, 60);
            this.AlarmCheckBox.Name = "AlarmCheckBox";
            this.AlarmCheckBox.Size = new System.Drawing.Size(59, 17);
            this.AlarmCheckBox.TabIndex = 2;
            this.AlarmCheckBox.Text = "On/Off";
            this.AlarmCheckBox.UseVisualStyleBackColor = true;
            this.AlarmCheckBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AlarmCheckBox_KeyDown);
            // 
            // AlarmLabel
            // 
            this.AlarmLabel.AutoSize = true;
            this.AlarmLabel.Location = new System.Drawing.Point(2, 60);
            this.AlarmLabel.Name = "AlarmLabel";
            this.AlarmLabel.Size = new System.Drawing.Size(36, 13);
            this.AlarmLabel.TabIndex = 10;
            this.AlarmLabel.Text = "Alarm:";
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CustomFormat = "";
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimePicker.Location = new System.Drawing.Point(83, 34);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.Size = new System.Drawing.Size(196, 20);
            this.StartTimePicker.TabIndex = 1;
            // 
            // NewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 162);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.AlarmLabel);
            this.Controls.Add(this.AlarmCheckBox);
            this.Controls.Add(this.CreateTaskAndExitButton);
            this.Controls.Add(this.CreateTaskButton);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.TaskNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RemindMe - New Task";
            this.Deactivate += new System.EventHandler(this.NewTaskForm_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewTaskForm_FormClosed);
            this.Load += new System.EventHandler(this.NewTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TaskNameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Button CreateTaskButton;
        private System.Windows.Forms.Button CreateTaskAndExitButton;
        private System.Windows.Forms.CheckBox AlarmCheckBox;
        private System.Windows.Forms.Label AlarmLabel;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
    }
}