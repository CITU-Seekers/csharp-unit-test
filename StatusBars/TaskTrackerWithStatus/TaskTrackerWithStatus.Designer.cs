namespace CodeChum
{
    partial class TaskTrackerWithStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            TaskName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            FinishedList = new System.Windows.Forms.ListBox();
            ToDoList = new System.Windows.Forms.ListBox();
            toProgress = new Button();
            label3 = new Label();
            InProgressList = new System.Windows.Forms.ListBox();
            backtoTODO = new Button();
            backtoProgress = new Button();
            toFinished = new Button();
            ProgressStatusStrip = new StatusStrip();
            ProgressLabel = new ToolStripStatusLabel();
            ProgressBar = new ToolStripProgressBar();
            ProgressStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(172, 287);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(57, 23);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // TaskName
            // 
            TaskName.Location = new Point(33, 287);
            TaskName.Name = "TaskName";
            TaskName.Size = new Size(133, 23);
            TaskName.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(599, 19);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 12;
            label2.Text = "Finished:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 19);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 11;
            label1.Text = "To Do:";
            // 
            // FinishedList
            // 
            FinishedList.FormattingEnabled = true;
            FinishedList.ItemHeight = 15;
            FinishedList.Location = new Point(599, 43);
            FinishedList.Name = "FinishedList";
            FinishedList.Size = new Size(194, 229);
            FinishedList.TabIndex = 10;
            // 
            // ToDoList
            // 
            ToDoList.FormattingEnabled = true;
            ToDoList.ItemHeight = 15;
            ToDoList.Location = new Point(33, 43);
            ToDoList.Name = "ToDoList";
            ToDoList.Size = new Size(194, 229);
            ToDoList.TabIndex = 9;
            // 
            // toProgress
            // 
            toProgress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toProgress.Location = new Point(233, 117);
            toProgress.Name = "toProgress";
            toProgress.Size = new Size(75, 36);
            toProgress.TabIndex = 13;
            toProgress.Text = ">";
            toProgress.UseVisualStyleBackColor = true;
            toProgress.Click += toProgress_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(316, 19);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 18;
            label3.Text = "In Progress:";
            // 
            // InProgressList
            // 
            InProgressList.FormattingEnabled = true;
            InProgressList.ItemHeight = 15;
            InProgressList.Location = new Point(316, 43);
            InProgressList.Name = "InProgressList";
            InProgressList.Size = new Size(194, 229);
            InProgressList.TabIndex = 17;
            // 
            // backtoTODO
            // 
            backtoTODO.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            backtoTODO.Location = new Point(235, 174);
            backtoTODO.Name = "backtoTODO";
            backtoTODO.Size = new Size(75, 36);
            backtoTODO.TabIndex = 19;
            backtoTODO.Text = "<";
            backtoTODO.UseVisualStyleBackColor = true;
            backtoTODO.Click += backtoTODO_Click;
            // 
            // backtoProgress
            // 
            backtoProgress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            backtoProgress.Location = new Point(518, 174);
            backtoProgress.Name = "backtoProgress";
            backtoProgress.Size = new Size(75, 36);
            backtoProgress.TabIndex = 21;
            backtoProgress.Text = "<";
            backtoProgress.UseVisualStyleBackColor = true;
            backtoProgress.Click += backtoProgress_Click;
            // 
            // toFinished
            // 
            toFinished.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toFinished.Location = new Point(516, 117);
            toFinished.Name = "toFinished";
            toFinished.Size = new Size(75, 36);
            toFinished.TabIndex = 20;
            toFinished.Text = ">";
            toFinished.UseVisualStyleBackColor = true;
            toFinished.Click += toFinished_Click;
            // 
            // ProgressStatusStrip
            // 
            ProgressStatusStrip.Items.AddRange(new ToolStripItem[] { ProgressLabel, ProgressBar });
            ProgressStatusStrip.Location = new Point(0, 428);
            ProgressStatusStrip.Name = "ProgressStatusStrip";
            ProgressStatusStrip.Size = new Size(852, 22);
            ProgressStatusStrip.TabIndex = 22;
            ProgressStatusStrip.Text = "statusStrip1";
            // 
            // ProgressLabel
            // 
            ProgressLabel.Name = "ProgressLabel";
            ProgressLabel.Size = new Size(0, 17);
            // 
            // ProgressBar
            // 
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(100, 16);
            // 
            // TaskTrackerWithStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 450);
            Controls.Add(ProgressStatusStrip);
            Controls.Add(backtoProgress);
            Controls.Add(toFinished);
            Controls.Add(backtoTODO);
            Controls.Add(label3);
            Controls.Add(InProgressList);
            Controls.Add(btnAdd);
            Controls.Add(TaskName);
            Controls.Add(toProgress);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FinishedList);
            Controls.Add(ToDoList);
            Name = "TaskTrackerWithStatus";
            Text = "TaskTrackerWithStatus";
            ProgressStatusStrip.ResumeLayout(false);
            ProgressStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private TextBox TaskName;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.ListBox FinishedList;
        private System.Windows.Forms.ListBox ToDoList;
        private Button toProgress;
        private Label label3;
        private System.Windows.Forms.ListBox InProgressList;
        private Button backtoTODO;
        private Button backtoProgress;
        private Button toFinished;
        private StatusStrip ProgressStatusStrip;
        private ToolStripStatusLabel ProgressLabel;
        private ToolStripProgressBar ProgressBar;
    }
}