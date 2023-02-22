using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RemindMe
{
    public static class GlobalVars
    {
        public static void LoadSave()
        {
            string[] lines = System.IO.File.ReadAllLines(FilePath);
            string[] settings = lines[0].Split('|');
            bool.TryParse(settings[0], out MinimizeToTray);
            int.TryParse(settings[1], out AlarmVolume);
            for(int i = 1; i < lines.Length; i++)
            {
                string[] s = lines[i].Split('|');
                DateTime t = DateTime.Parse(s[1]);
                taskList.Add(new Task(s[0], t, Convert.ToBoolean(s[2])));
            }
        }
        public static void Save()
        {
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
            using(StreamWriter sw = File.CreateText(FilePath))
            {
                sw.WriteLine(MinimizeToTray.ToString() + "|" + AlarmVolume);
                foreach(Task t in GlobalVars.taskList)
                {
                    sw.WriteLine(t);
                }
            }
        }
        private static String UserName = Environment.UserName;
        /// <summary>
        /// File path for save file
        /// </summary>
        public static String FilePath = "C:\\Users\\" + UserName + "\\AppData\\Local\\RemindMe.txt";
        /// <summary>
        /// Set to true once save file path exists
        /// </summary>
        public static bool SaveExists = false;
        /// <summary>
        /// Set to true when settings opened, false when closed
        /// </summary>
        public static bool SettingsOpen = false;
        /// <summary>
        /// Set to true when new task opened, false when closed
        /// </summary>
        public static bool NewTaskOpen = false;
        public static bool SystemTrayClosed = false;
        public static bool EditTaskOpen = false;
        public static string stringFlowFormat = "t";
        public static string DividerFormat = "dddd, MMMM dd yyyy";
        public static string DateLabelFormat = "dddd, MMMM dd yyyy - hh:mm tt";
        public static string PickerFormat = "ddd, MM/dd/yyyy - hh:mm tt";
        public static bool MinimizeToTray = true;
        public static int AlarmVolume = 0;
        public static List<Task> taskList = new List<Task>();
        public static System.Drawing.Size separatorSize = new System.Drawing.Size(323, 1);   
    }
}
