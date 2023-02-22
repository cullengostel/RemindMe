using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemindMe
{
    public partial class TaskControl : UserControl
    {
        public Task ControlFormTask { get; set; }
        public TaskControl(Task controlTask)
        {
            InitializeComponent();
            ControlFormTask = controlTask;
            TaskNameLabel.Text = ControlFormTask.StartTime.ToString(GlobalVars.stringFlowFormat) + " - " + ControlFormTask.Name;
            AlarmCheckBox.Checked = ControlFormTask.Alarm;
            if (GlobalVars.taskList.IndexOf(ControlFormTask) > 0)
            {
                AlarmCheckBox.Text = "";
            }
        }

        private void AlarmCheckBox_KeyDown(object sender, KeyEventArgs e)
                                 {
            if (e.KeyCode == Keys.Enter)
            {
                AlarmCheckBox.Checked = !AlarmCheckBox.Checked;
            }
        }

        /// <summary>
        /// Creates new EditTaskForm editForm, shows form, makes topmost
        /// Assigns EditTaskOpen true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditTextItem_Click(object sender, EventArgs e)
        {
            if (!GlobalVars.EditTaskOpen)
            {
                EditTaskForm editForm = new EditTaskForm(ControlFormTask);
                editForm.Show();
                editForm.TopMost = true;
                GlobalVars.EditTaskOpen = true;
            }
        }
        /// <summary>
        /// Shows TaskMenuStrip at location of TaskControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskControl_MouseClick(object sender, MouseEventArgs e)
        {
                TaskMenuStrip.Show(MousePosition);
        }

        private void DeleteTaskItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + ControlFormTask.Name + "?", 
                "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GlobalVars.taskList.Remove(ControlFormTask);
                Agenda.instance.BuildAgenda();
            }
        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            GlobalVars.taskList.Remove(ControlFormTask);
            Agenda.instance.BuildAgenda();
        }

        private void AlarmCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVars.taskList[GlobalVars.taskList.IndexOf(ControlFormTask)].Alarm = AlarmCheckBox.Checked;
        }

        private void TaskControl_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            this.TaskNameLabel.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            this.AlarmCheckBox.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);

        }

        private void TaskControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromKnownColor(KnownColor.Control);
            this.TaskNameLabel.BackColor = Color.FromKnownColor(KnownColor.Control);
            this.AlarmCheckBox.BackColor = Color.FromKnownColor(KnownColor.Control);
        }
    }
}
