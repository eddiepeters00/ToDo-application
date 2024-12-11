using System.Drawing.Text;

namespace Assignment_6___ToDo_Reminder
{
    public partial class MainForm : Form
    {
        private TaskManager taskManager;

        //Working with only one file located in the same directory as the applications EXE - file 
        private string fileName = Application.StartupPath + "\\Tasks.txt";
        public MainForm()
        {
            InitializeComponent();

            //Initialize GUI
            InitializeGUI();
        }


        /// <summary>
        /// 
        /// </summary>
        private void InitializeGUI()
        {
            this.Text = "ToDo Reminder by Eddie Peters";
            taskManager = new TaskManager();

            cmbPriority.Items.Clear();
            cmbPriority.Items.AddRange(Enum.GetNames(typeof(PriorityType)));
            cmbPriority.SelectedIndex = (int)PriorityType.Normal;

            lstTodo.Items.Clear();
            lblTimer.Text = String.Empty;
            clockTimer.Start();

            txtTodo.Text = String.Empty;

            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd  HH:mm";

            toolTip.ShowAlways = true;
            toolTip.SetToolTip(dateTimePicker, "Click to open calendar for date, write in time here.");
            toolTip.SetToolTip(cmbPriority, "Select the priority");

            string tips = "TO CHANGE: Select an item first!" + Environment.NewLine;
            tips += "Make your changes in the input controls," + Environment.NewLine;
            tips += "Click the Change button." + Environment.NewLine;

            toolTip.SetToolTip(lstTodo, tips);
            toolTip.SetToolTip(btnChange, tips);

            string delTips = "Select an item first and then click this button!";
            toolTip.SetToolTip(btnDelete, delTips);
            btnDelete.Enabled = false;
            btnChange.Enabled = false;

            string desTips = "Write your sins here!";
            toolTip.SetToolTip(txtTodo, delTips);

            menuFileOpen.Enabled = true;
            menuFileSave.Enabled = true;
        }

        /// <summary>
        /// Disables buttons and updates todo list
        /// </summary>
        private void UpdateGUI()
        {
            btnDelete.Enabled = false;
            btnChange.Enabled = false;

            lstTodo.Items.Clear();
            string[] infoStrings = taskManager.GetInfoStringsList();
            if (infoStrings != null)
                lstTodo.Items.AddRange(infoStrings);
        }


        /// <summary>
        /// Reads the user input
        /// <returns>A new Task object</returns>
        /// </summary>
        private Task ReadInput()
        {
            Task task = new Task();
            task.TaskDate = dateTimePicker.Value;
            task.Description = txtTodo.Text;
            task.Priority = (PriorityType)cmbPriority.SelectedIndex;
            return task;
        }

        /// <summary>
        /// Cleans the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileNew_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }


        /// <summary>
        /// Updates the GUI with the saved tasklist on your computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            string errMessage = "Something went wrong when opening the file";
            bool ok = taskManager.ReadDataFromFile(fileName);
            if (!ok)
            {
                MessageBox.Show(errMessage);
            }
            else
            {
                UpdateGUI();
            }
        }


        /// <summary>
        /// Saves the tasklist to your computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileSave_Click(object sender, EventArgs e)
        {
            string errMessage = "Something went wrong while saving data to file";
            bool ok = taskManager.WriteDataToFile(fileName);
            if (!ok)
            {
                MessageBox.Show(errMessage);
            }
            else
            {
                MessageBox.Show("Data saved to file: " + Environment.NewLine + fileName);
            }
        }


        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Sure to exit the program?", "Think twice", MessageBoxButtons.OKCancel);
            if (dlgResult == DialogResult.OK)
            {
                Application.Exit();
            }

        }


        /// <summary>
        /// Makes the timer label tick as a digital clock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Task task = ReadInput();
            if (taskManager.AddNewTask(task))
            {
                UpdateGUI();
            }
        }


        /// <summary>
        /// Changes information of a selected task in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (lstTodo.SelectedIndices.Count > 0)
            {
                int index = lstTodo.SelectedIndices[0];
                Task newTask = ReadInput();


                //Update contact
                if (taskManager.ChangeTask(newTask, index))
                {
                    UpdateGUI();
                }

            }
        }


        /// <summary>
        /// Deletes a selected task in the list
        /// Displays messagebox to user to confirm deletion
        /// updates gui
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTodo.SelectedIndices.Count > 0)
            {
                //index from chosen todo in list
                int index = lstTodo.SelectedIndices[0];

                //Show messagebox to confirm or cancel deletion
                DialogResult dlgResult = MessageBox.Show("Are you sure you want to delete this task?", "Delete task", MessageBoxButtons.OKCancel);

                if (dlgResult == DialogResult.OK && taskManager.DeleteTask(index))
                {
                    UpdateGUI();
                }
            }
        }


        /// <summary>
        /// Enables the change and delete button if an item in the list is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstTodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnChange.Enabled = true;
        }


        /// <summary>
        /// Displays an aboutbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }
    }
}
