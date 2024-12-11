namespace Assignment_6___ToDo_Reminder
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuFileNew = new ToolStripMenuItem();
            openDataFileToolStripMenuItem = new ToolStripSeparator();
            menuFileOpen = new ToolStripMenuItem();
            menuFileSave = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuFileExit = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            dateTimePicker = new DateTimePicker();
            label2 = new Label();
            cmbPriority = new ComboBox();
            label3 = new Label();
            txtTodo = new TextBox();
            btnAdd = new Button();
            grpTodoList = new GroupBox();
            lstTodo = new ListBox();
            btnChange = new Button();
            btnDelete = new Button();
            lblTimer = new Label();
            toolTip = new ToolTip(components);
            clockTimer = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            grpTodoList.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1038, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuFileNew, openDataFileToolStripMenuItem, menuFileOpen, menuFileSave, toolStripSeparator1, menuFileExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(46, 24);
            menuFile.Text = "File";
            // 
            // menuFileNew
            // 
            menuFileNew.Name = "menuFileNew";
            menuFileNew.ShortcutKeys = Keys.Control | Keys.N;
            menuFileNew.Size = new Size(187, 26);
            menuFileNew.Text = "New";
            menuFileNew.Click += menuFileNew_Click;
            // 
            // openDataFileToolStripMenuItem
            // 
            openDataFileToolStripMenuItem.Name = "openDataFileToolStripMenuItem";
            openDataFileToolStripMenuItem.Size = new Size(184, 6);
            // 
            // menuFileOpen
            // 
            menuFileOpen.Name = "menuFileOpen";
            menuFileOpen.Size = new Size(187, 26);
            menuFileOpen.Text = "Open data file";
            menuFileOpen.Click += menuFileOpen_Click;
            // 
            // menuFileSave
            // 
            menuFileSave.Name = "menuFileSave";
            menuFileSave.Size = new Size(187, 26);
            menuFileSave.Text = "Save data file";
            menuFileSave.Click += menuFileSave_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(184, 6);
            // 
            // menuFileExit
            // 
            menuFileExit.Name = "menuFileExit";
            menuFileExit.ShortcutKeys = Keys.Alt | Keys.F4;
            menuFileExit.Size = new Size(187, 26);
            menuFileExit.Text = "Exit";
            menuFileExit.Click += menuFileExit_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(224, 26);
            aboutToolStripMenuItem.Text = "About...";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 1;
            label1.Text = "Date and time";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(162, 71);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(294, 27);
            dateTimePicker.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(507, 76);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 3;
            label2.Text = "Priority";
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(569, 68);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(151, 28);
            cmbPriority.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 5;
            label3.Text = "To do";
            // 
            // txtTodo
            // 
            txtTodo.Location = new Point(89, 115);
            txtTodo.Name = "txtTodo";
            txtTodo.Size = new Size(631, 27);
            txtTodo.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(285, 165);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(171, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grpTodoList
            // 
            grpTodoList.Controls.Add(lstTodo);
            grpTodoList.Location = new Point(12, 242);
            grpTodoList.Name = "grpTodoList";
            grpTodoList.Size = new Size(957, 247);
            grpTodoList.TabIndex = 8;
            grpTodoList.TabStop = false;
            grpTodoList.Text = "To Do";
            // 
            // lstTodo
            // 
            lstTodo.FormattingEnabled = true;
            lstTodo.Location = new Point(6, 46);
            lstTodo.Name = "lstTodo";
            lstTodo.Size = new Size(945, 184);
            lstTodo.TabIndex = 0;
            lstTodo.SelectedIndexChanged += lstTodo_SelectedIndexChanged;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(89, 509);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(126, 29);
            btnChange.TabIndex = 1;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(316, 509);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.ForeColor = SystemColors.HotTrack;
            lblTimer.Location = new Point(850, 509);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(79, 20);
            lblTimer.TabIndex = 10;
            lblTimer.Text = "00 : 00 : 00";
            // 
            // clockTimer
            // 
            clockTimer.Enabled = true;
            clockTimer.Interval = 1000;
            clockTimer.Tick += clockTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1038, 560);
            Controls.Add(lblTimer);
            Controls.Add(btnDelete);
            Controls.Add(btnChange);
            Controls.Add(grpTodoList);
            Controls.Add(btnAdd);
            Controls.Add(txtTodo);
            Controls.Add(label3);
            Controls.Add(cmbPriority);
            Controls.Add(label2);
            Controls.Add(dateTimePicker);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpTodoList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuFileSave;
        private ToolStripMenuItem menuFileExit;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem menuFileNew;
        private ToolStripSeparator openDataFileToolStripMenuItem;
        private ToolStripMenuItem menuFileOpen;
        private ToolStripSeparator toolStripSeparator1;
        private Label label1;
        private DateTimePicker dateTimePicker;
        private Label label2;
        private ComboBox cmbPriority;
        private Label label3;
        private TextBox txtTodo;
        private Button btnAdd;
        private GroupBox grpTodoList;
        private Button btnChange;
        private Button btnDelete;
        private Label lblTimer;
        private ToolTip toolTip;
        private System.Windows.Forms.Timer clockTimer;
        private ListBox lstTodo;
    }
}
