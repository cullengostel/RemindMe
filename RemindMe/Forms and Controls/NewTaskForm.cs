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
    public partial class NewTaskForm : Form
    {
        public NewTaskForm()
        {
            InitializeComponent();
            this.StartTimePicker.CustomFormat = GlobalVars.PickerFormat;
        }

        //Load Event. Sets location to top right of Agenda
        private void NewTaskForm_Load(object sender, EventArgs e)
        {
            this.Location = Agenda.instance.Location;
        }

        //Creates task and adds it to global taskList
        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            //Validates name isn't whitespace and start time is after current time
            if (String.IsNullOrWhiteSpace(TaskNameTextBox.Text))
                MessageBox.Show("Please enter a task name.");
            else if (DateTime.Compare(StartTimePicker.Value, DateTime.Now) < 0)
                MessageBox.Show("Please enter a valid start time.");
            else {
                Task newTask = new Task(TaskNameTextBox.Text, StartTimePicker.Value, AlarmCheckBox.Checked);
                //Validates task doesn't already exist (identical startTime/taskName) and then adds task to tasklist
                if (TaskDoesNotExist(newTask))
                {
                    GlobalVars.taskList.Add(newTask);
                    Agenda.instance.BuildAgenda();
                    TaskNameTextBox.Text = "";
                    AlarmCheckBox.Checked = false;
                }
                else
                {
                    MessageBox.Show("The entered task already exists.");
                }
            }
        } 

        //Returns false if task already in list, true otherwise
        private bool TaskDoesNotExist(Task task)
        {
            foreach(Task t in GlobalVars.taskList)
            {
                if (task.CompareTo(t) == 0)
                    return false;
            }
            return true;
        }

        //Same as CreateTaskButton_Click, but closes if there were no input errors
        private void CreateTaskAndExitButton_Click(object sender, EventArgs e)
        {
            bool isError = true;
            if (String.IsNullOrWhiteSpace(TaskNameTextBox.Text))
                MessageBox.Show("Please enter a task name.");
            else if (DateTime.Compare(StartTimePicker.Value, DateTime.Now) < 0)
                MessageBox.Show("Please enter a valid start time.");
            else
            {
                Task newTask = new Task(TaskNameTextBox.Text, StartTimePicker.Value, AlarmCheckBox.Checked);
                if (TaskDoesNotExist(newTask))
                {
                    GlobalVars.taskList.Add(newTask);
                    Agenda.instance.BuildAgenda();
                    isError = false;
                }
                else
                    MessageBox.Show("The entered task already exists.");
            }
            if (!isError)
                Close();
        }

        //Allows user to use enter key to check AlarmCheckBox
        private void AlarmCheckBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AlarmCheckBox.Checked = !AlarmCheckBox.Checked;
        }

        //Closes the form on lost focus
        private void NewTaskForm_Deactivate(object sender, EventArgs e)
        {
            //Close();
        }

        //Assigns GlobalVar.SettingsOpen to false
        private void NewTaskForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVars.NewTaskOpen = false;
        }
    }
}
