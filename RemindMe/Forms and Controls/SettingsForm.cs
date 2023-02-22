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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        //Load event. Sets start location and matches controls values
        //to their associated settings
        private void LoadSettings(object sender, EventArgs e)
        {
            this.Location = Agenda.instance.Location;
            AlarmVolumeSlider.Value = GlobalVars.AlarmVolume;
            currentVolumeLabel.Text = AlarmVolumeSlider.Value.ToString() + "%";
            SystemTrayCheckBox.Checked = GlobalVars.MinimizeToTray;
        }

        //Ditto but for Minimize to System Tray
        private void SystemTrayCheckBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SystemTrayCheckBox.Checked = !SystemTrayCheckBox.Checked;
        }

        //Sets volume label equal to the current volume as a percentage
        private void AlarmVolumeSlider_Scroll(object sender, EventArgs e)
        {
            currentVolumeLabel.Text = AlarmVolumeSlider.Value.ToString() + "%";
        }

        //Assigns all GlobalVar settings and closes the form on click
        private void SaveButton_Click(object sender, EventArgs e)
        {
            GlobalVars.AlarmVolume = AlarmVolumeSlider.Value;
            GlobalVars.MinimizeToTray = SystemTrayCheckBox.Checked;
            Close();
        }

        //Exits the form on click
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Closes form on lost focus
        private void SettingsForm_Deactivate(object sender, EventArgs e)
        {
            //Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVars.SettingsOpen = false;
        }
    }
}
