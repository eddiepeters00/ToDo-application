using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6___ToDo_Reminder
{
    class TaskManager
    {
        //Declare a List<T> Object where T is a Task type
        List<Task> taskList;


        /// <summary>
        /// Constructor, creates a new List of Task objects
        /// </summary>
        public TaskManager()
        {
            taskList = new List<Task>();
        }


        /// <summary>
        /// Reads data from file using the fileManager class
        /// </summary>
        /// <param name="fileName">File to be read</param>
        /// <returns>true if read is successfull, otherwise false</returns>
        public bool ReadDataFromFile(string fileName)
        {
            FileManager fileManager = new FileManager();

            //Objects are passed by ref so tasklist will be updated
            return fileManager.ReadTaskListFromFile(taskList, fileName);
        }


        /// <summary>
        /// Writes data to a file using the FileManager class
        /// </summary>
        /// <param name="fileName">File to be written to</param>
        /// <returns>true if write is successfull, otherwise false</returns>
        public bool WriteDataToFile(string fileName)
        {
            FileManager fileManager = new FileManager();
            return fileManager.SaveTaskListToFile(taskList, fileName);
        }


        /// <summary>
        /// Add a new object at the end of the tasklist
        /// </summary>
        /// <param name="newTask">The task object that is to be added</param>
        /// <returns>true if task is added successfully, otherwise false</returns>
        public bool AddNewTask(Task newTask)
        {
            bool ok = true;

            if (newTask != null)
            {
                taskList.Add(newTask);
            }
            else
            {
                ok = false;
            }

            return ok;
        }


        /// <summary>
        /// Deletes a task in the list
        /// </summary>
        /// <param name="newTask">The index of the task object that is to be deleted</param>
        /// <returns>true if task is deleted successfully, otherwise false</returns>
        public bool DeleteTask(int index)
        {
            bool ok = true;

            if (index >= 0 )
            {
                taskList.RemoveAt(index);
            }
            else
            {
                ok = false;
            }

            return ok;
        }


        /// <summary>
        /// Changes a task in the list
        /// </summary>
        /// <param name="task">The new task object</param>
        /// <param name="index">The index of the task in the list</param>
        /// <returns>true if task is changed successfully, otherwise false</returns>
        public bool ChangeTask(Task task, int index)
        {
            bool ok = true;

            if (task != null && index >= 0)
            {
                taskList[index] = task;
            }
            else
            {
                ok = false;
            }

            return ok;
        }


        /// <summary>
        /// Creates a string[] of tasks from tasklist
        /// </summary>
        /// <returns>String[] of tasks</returns>
        public string[] GetInfoStringsList()
        {
            //Create local array of string elements with a capacity = num
            string[] infoStrings = new string[taskList.Count];

            for (int i = 0; i < infoStrings.Length; i++)
            {
                infoStrings[i] = taskList[i].ToString();
            }

            return infoStrings;
        }
    }
}
