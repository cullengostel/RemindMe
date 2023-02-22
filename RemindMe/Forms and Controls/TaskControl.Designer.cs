namespace RemindMe
{
    partial class TaskControl
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
            this.components = new System.ComponentModel.Container();
            this.TaskNameLabel = new System.Windows.Forms.Label();
            this.AlarmCheckBox = new System.Windows.Forms.CheckBox();
            this.TaskMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditTaskItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTaskItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompleteButton = new System.Windows.Forms.Button();
            this.TaskMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Location = new System.Drawing.Point(3, 5);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(62, 13);
            this.TaskNameLabel.TabIndex = 0;
            this.TaskNameLabel.Text = "Task Name";
            this.TaskNameLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TaskControl_MouseClick);
            this.TaskNameLabel.MouseLeave += new System.EventHandler(this.TaskControl_MouseLeave);
            this.TaskNameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TaskControl_MouseMove);
            // 
            // AlarmCheckBox
            // 
            this.AlarmCheckBox.AutoSize = true;
            this.AlarmCheckBox.Location = new System.Drawing.Point(197, 3);
            this.AlarmCheckBox.Name = "AlarmCheckBox";
            this.AlarmCheckBox.Size = new System.Drawing.Size(52, 17);
            this.AlarmCheckBox.TabIndex = 2;
            this.AlarmCheckBox.Text = "Alarm";
            this.AlarmCheckBox.UseVisualStyleBackColor = true;
            this.AlarmCheckBox.CheckedChanged += new System.EventHandler(this.AlarmCheckBox_CheckedChanged);
            this.AlarmCheckBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AlarmCheckBox_KeyDown);
            this.AlarmCheckBox.MouseLeave += new System.EventHandler(this.TaskControl_MouseLeave);
            this.AlarmCheckBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TaskControl_MouseMove);
            // 
            // TaskMenuStrip
            // 
            this.TaskMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditTaskItem,
            this.DeleteTaskItem});
            this.TaskMenuStrip.Name = "TaskMenuStrip";
            this.TaskMenuStrip.ShowImageMargin = false;
            this.TaskMenuStrip.Size = new System.Drawing.Size(108, 48);
            // 
            // EditTaskItem
            // 
            this.EditTaskItem.Name = "EditTaskItem";
            this.EditTaskItem.Size = new System.Drawing.Size(107, 22);
            this.EditTaskItem.Text = "Edit Task";
            this.EditTaskItem.Click += new System.EventHandler(this.EditTextItem_Click);
            // 
            // DeleteTaskItem
            // 
            this.DeleteTaskItem.Name = "DeleteTaskItem";
            this.DeleteTaskItem.Size = new System.Drawing.Size(107, 22);
            this.DeleteTaskItem.Text = "Delete Task";
            this.DeleteTaskItem.Click += new System.EventHandler(this.DeleteTaskItem_Click);
            // 
            // CompleteButton
            // 
            this.CompleteButton.Location = new System.Drawing.Point(247, 0);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(75, 24);
            this.CompleteButton.TabIndex = 3;
            this.CompleteButton.Text = "Complete";
            this.CompleteButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CompleteButton.UseVisualStyleBackColor = true;
            this.CompleteButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CompleteButton);
            this.Controls.Add(this.AlarmCheckBox);
            this.Controls.Add(this.TaskNameLabel);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(322, 24);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TaskControl_MouseClick);
            this.MouseLeave += new System.EventHandler(this.TaskControl_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TaskControl_MouseMove);
            this.TaskMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TaskNameLabel;
        private System.Windows.Forms.CheckBox AlarmCheckBox;
        private System.Windows.Forms.ContextMenuStrip TaskMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem EditTaskItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteTaskItem;
        private System.Windows.Forms.Button CompleteButton;
    }
}
