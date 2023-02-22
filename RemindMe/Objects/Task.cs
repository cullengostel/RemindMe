using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemindMe
{
    public class Task : IComparable
    {
        public String Name { get; set; }
        public DateTime StartTime { get; set; }
        public bool Alarm { get; set; }
        public Task(String name, DateTime startTime, bool alarm)
        {
            Name = name;
            Alarm = alarm;
            StartTime = startTime;
        }
        public int CompareTo(object obj)
        {
            Task task = obj as Task;
            if (task.Name.Equals(this.Name) && task.StartTime.Equals(this.StartTime))
                return 0;
            else if (DateTime.Compare(task.StartTime, this.StartTime) == 0)
            {
                if (String.Compare(task.Name, this.Name) < 0)
                    return 1;
                else
                    return -1;
            }
            else
                return DateTime.Compare(this.StartTime, task.StartTime);
        }
        override public string ToString()
        {
            string str = this.Name;
            str += "|" + this.StartTime;
            str += "|" + this.Alarm;
            return str;
        }
    }  
}
