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
    public partial class EditTaskForm : Form
    {
        public Task EditFormTask { get; set; }
        public EditTaskForm(Task editTask)
        {
            InitializeComponent();
            EditFormTask = editTask;
            TaskNameTextBox.Text = EditFormTask.Name;
            StartTimePicker.Value = EditFormTask.StartTime;
            AlarmCheckBox.Checked = EditFormTask.Alarm;
            this.StartTimePicker.CustomFormat = GlobalVars.PickerFormat;
        }

        private void EditTaskForm_Load(object sender, EventArgs e)
        {
            this.Location = Agenda.instance.Location;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //After validating TaskName != whitespace and the entered DateTime
        //is after now 
        private void SaveTaskButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TaskNameTextBox.Text))
                MessageBox.Show("Please enter a task name.");
            else if (DateTime.Compare(StartTimePicker.Value, DateTime.Now) < 0)
                MessageBox.Show("Please enter a valid start time.");
            else
            {
                Task editedTask = new Task(TaskNameTextBox.Text, StartTimePicker.Value, AlarmCheckBox.Checked);
                GlobalVars.taskList[GlobalVars.taskList.IndexOf(EditFormTask)] = editedTask;
                Agenda.instance.BuildAgenda();
                Close();
            }
        }

        //Closes form on lost focus
        private void EditTaskForm_Deactivate(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Makes GlobalVars.EditTaskOpen = false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditTaskForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVars.EditTaskOpen = false;
        }
    }
}
