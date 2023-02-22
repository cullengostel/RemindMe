using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Media;

namespace RemindMe
{
    public partial class Agenda : Form
    {
        public static Agenda instance;
        public Timer clockTimer = new Timer();
        public static SoundPlayer AlarmSound = new SoundPlayer("Alert_0_LoFi.wav");
        public Agenda()
        {
            InitializeComponent();
            BuildAgenda();
            instance = this;
        }
        private void Agenda_Load(object sender, EventArgs e)
        {
            DateLabelUpdate();
            clockTimer.Interval = 1000;
            clockTimer.Tick += new EventHandler(this.ClockTimerTick);
            clockTimer.Start();
        }
        public void AddDateDivider(String dateTime)
        {
            Label dividerLabel = new Label();
            dividerLabel.Anchor = AnchorStyles.Bottom;
            dividerLabel.AutoSize = true;
            dividerLabel.Margin = new Padding(0, 8, 0, 0); 
            dividerLabel.Text = dateTime;
            MainFlowPanel.Controls.Add(dividerLabel);
        }
        public void BuildAgenda()
        {
            
            MainFlowPanel.Controls.Clear();
            GlobalVars.taskList.Sort();
            String lastDateTime = DateTime.Now.ToString(GlobalVars.DividerFormat);
            int count = 0;
            foreach(Task t in GlobalVars.taskList)
            {
                String tDateTime = t.StartTime.ToString(GlobalVars.DividerFormat);
                if (!lastDateTime.Equals(tDateTime))
                {
                    AddDateDivider(tDateTime);
                }else if (count == 0)
                {
                    AddDateDivider("Today: " + DateTime.Now.ToString("M"));
                }
                Size dateSeperatorSize = new Size(100, 1);
                AddSeparator(dateSeperatorSize, true);
                AddTaskToAgenda(t);
                AddSeparator(GlobalVars.separatorSize);
                lastDateTime = tDateTime;
                count++;
            }
        }

        //Adds TaskControl for given to ask to MainFlowPanel
        public void AddTaskToAgenda(Task newTask)
        {
            TaskControl newTaskControl = new TaskControl(newTask);
            MainFlowPanel.Controls.Add(newTaskControl);
        }

        //Adds a horizontal line 'separator' into the MainFlowPanel
        private void AddSeparator(Size size)
        {
            Label label = new Label
            {
                BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D,
                Size = size
            };
            MainFlowPanel.Controls.Add(label);
        }
        /// <summary>
        /// Adds horizontal separator 
        /// </summary>
        /// <param name="size">Size of separator</param>
        /// <param name="centered">Anchors separator to bottom</param>
        private void AddSeparator(Size size, bool centered)
        {
            Label label = new Label
            {            
                BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D,
                Size = size
            };
            if (centered)
                label.Anchor = AnchorStyles.Bottom;
            MainFlowPanel.Controls.Add(label);
        }

        //Timer ticks every second
        //Every tick DateLabelUpdate is run and
        //alarm is played if necessary
        private void ClockTimerTick(object sender, EventArgs e)
        {
            DateLabelUpdate();         
            for (int i = 0; i < GlobalVars.taskList.Count(); i++) 
            {
                if (DateTime.Compare(GlobalVars.taskList[i].StartTime, DateTime.Now) <= 0 && GlobalVars.taskList[i].Alarm)
                {
                    AlarmSound.Play();
                    SystemTrayIcon.BalloonTipText = GlobalVars.taskList[i].Name;
                    SystemTrayIcon.ShowBalloonTip(1000);
                }
            }
        }

        //Updates the date label to reflect the current time
        private void DateLabelUpdate()
        {
            DateLabel.Text = "It is currently: " + DateTime.Now.ToString(GlobalVars.DateLabelFormat);
        }

        //Opens newTaskForm and sets it to be topmost
        private void NewTaskButton_Click(object sender, EventArgs e)
        {
            if (!GlobalVars.NewTaskOpen)
            {
                NewTaskForm newTaskForm = new NewTaskForm();
                newTaskForm.Show();
                newTaskForm.TopMost = true;
                GlobalVars.NewTaskOpen = true;
            }
        }

        //Opens settings form and sets it to be topmost
        //Only opens if GlobalVars.SettingsOpen = false
        //Assigns GlobalVars.SettingsOpen to true
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (!GlobalVars.SettingsOpen)
            {
                SettingsForm settings = new SettingsForm();
                settings.Show();
                settings.TopMost = true;
                GlobalVars.SettingsOpen = true;
            }
        }

        private void Agenda_OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason.Equals(CloseReason.UserClosing) && GlobalVars.MinimizeToTray && !GlobalVars.SystemTrayClosed)
            {
                e.Cancel = true;
                this.Hide();
                SystemTrayIcon.BalloonTipText = "Minimized to System Tray";
                SystemTrayIcon.ShowBalloonTip(1000);
            }
        }

        private void SystemTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!this.Visible)
                this.Show();
        }

        private void AgendaMenuStripItem_Click(object sender, EventArgs e)
        {
            if (!this.Visible)
                this.Show();
        }

        private void ExitMenuStripItem_Click(object sender, EventArgs e)
        {
            GlobalVars.SystemTrayClosed = true;
            this.Close();
        }

        private void Agenda_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                this.Show();
            else
                this.Hide();
        }
    }
}
