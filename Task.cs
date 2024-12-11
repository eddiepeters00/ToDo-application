using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6___ToDo_Reminder
{
    public class Task
    {
        private DateTime date;
        private string description;
        private PriorityType priority;

        //Default constructor
        public Task() {
            //Set default priority
            priority = PriorityType.Normal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskDate"></param>
        public Task(DateTime taskDate) : this(taskDate, string.Empty, PriorityType.Normal) { }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="taskDate"></param>
        /// <param name="description"></param>
        /// <param name="priority"></param>
        public Task(DateTime taskDate, string description, PriorityType priority)
        {
            this.date = taskDate;
            this.description = description;
            this.priority = priority;
        }


        //Properties
        public String Description
        {
            get { return description; }
            set { if (!string.IsNullOrEmpty(value)) description = value; }
        }

        public PriorityType Priority { get { return priority; } set { priority = value; } }

        public DateTime TaskDate { get { return date; } set { date = value; } }


        /// <summary>
        /// Replaces the underscore in the enum with a space
        /// </summary>
        /// <returns>String representation of a Priority</returns>
        public string GetPriorityString()
        {
            return priority.ToString().Replace("_", " ");
        }


        /// <summary>
        /// Creates a string with hours and minutes
        /// </summary>
        /// <returns>String of hours and minutes</returns>
        private string GetTimeString() {
            return date.Hour.ToString() + ":" + date.Minute.ToString();
        }


        /// <summary>
        /// A formatted string with date, time, priority and description
        /// </summary>
        /// <returns>A formatted string</returns>
        public override string ToString()
        {
            string textOut = String.Format("{0, -20} {1, 10} {2, -16} {3, -20}", date.ToLongDateString(), GetTimeString(), GetPriorityString(), Description);
            return textOut;
        }
    }
}
