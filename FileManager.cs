using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_6___ToDo_Reminder
{
    class FileManager
    {

        private const string fileVersionToken = "ToDoRe_24";
        private const double fileVersionNr = 1.0;


        /// <summary>
        /// Reads all of the tasks from the saved file on your computer using the StreamReader class
        /// Updates tasklist with the read tasks
        /// </summary>
        /// <param name="taskList"></param>
        /// <param name="fileName"></param>
        /// <returns>true if read is successfull, otherwise false</returns>
        public bool ReadTaskListFromFile(List<Task> taskList, string fileName)
        {
            bool ok = true;
            StreamReader reader = null;
            try
            {
                //Clear the contents of tasklist
                if (taskList != null)
                    taskList.Clear();
                else
                    taskList = new List<Task>();

                reader = new StreamReader(fileName);

                //Ensure that it is the correct file
                string versionTest = reader.ReadLine();
                //Ensure correct version nmbr
                double version = double.Parse(reader.ReadLine());

                if((versionTest == fileVersionToken) && (version == fileVersionNr))
                {
                    //Read num of items (tasks) to read
                    int count = int.Parse(reader.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Task task = new Task();
                        task.Description = reader.ReadLine();
                        task.Priority = (PriorityType)Enum.Parse(typeof(PriorityType), reader.ReadLine());

                        //Datetime.Year,month etc are readonly!
                        int year = 0, month = 0, day = 0;
                        int hour, minute = 0, second = 0;

                        year = int.Parse(reader.ReadLine());
                        month = int.Parse(reader.ReadLine()); 
                        day = int.Parse(reader.ReadLine()); 
                        hour = int.Parse(reader.ReadLine()); 
                        minute = int.Parse(reader.ReadLine()); 
                        second = int.Parse(reader.ReadLine());

                        task.TaskDate = new DateTime(year, month, day, hour, minute, second);
                        taskList.Add(task);
                    }

                } else
                {
                    ok = false;
                }
            }

            catch
            {
                ok = false;
            }

            finally
            {
                if (reader != null)
                    reader.Close();
            }


            return ok;
        }


        /// <summary>
        /// Saves the tasklist to a file using the Stramwriter class
        /// </summary>
        /// <param name="taskList"></param>
        /// <param name="fileName"></param>
        /// <returns>true if writing is successfull, otherwise false</returns>
        public bool SaveTaskListToFile(List<Task> taskList, string fileName) {

            bool ok = true;
            StreamWriter writer = null; 
            try
            {
                writer = new StreamWriter(fileName);
                writer.WriteLine(fileVersionToken);
                writer.WriteLine(fileVersionNr);
                writer.WriteLine(taskList.Count);

                for (int i = 0; i < taskList.Count; i++)
                {
                    writer.WriteLine(taskList[i].Description);
                    writer.WriteLine(taskList[i].Priority.ToString());
                    writer.WriteLine(taskList[i].TaskDate.Year);
                    writer.WriteLine(taskList[i].TaskDate.Month);
                    writer.WriteLine(taskList[i].TaskDate.Day);
                    writer.WriteLine(taskList[i].TaskDate.Hour);
                    writer.WriteLine(taskList[i].TaskDate.Minute);
                    writer.WriteLine(taskList[i].TaskDate.Second);
                }
            }

            catch
            {
                ok = false;
            }

            finally
            {
                if (writer != null)
                    writer.Close();
            }
            
            
            return ok;
        }

    }
}
