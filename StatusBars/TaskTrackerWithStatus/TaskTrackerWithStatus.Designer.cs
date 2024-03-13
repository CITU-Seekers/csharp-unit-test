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
            addButton = new Button();
            taskNameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            finishedListBox = new ListBox();
            toDoListBox = new ListBox();
            toDoToInProgressButton = new Button();
            label3 = new Label();
            inProgressListBox = new ListBox();
            inProgressToToDoButton = new Button();
            finishedToInProgressButton = new Button();
            inProgressToFinishedButton = new Button();
            progressStatusStrip = new StatusStrip();
            progressLabel = new ToolStripStatusLabel();
            progressBar = new ToolStripProgressBar();
            progressStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(172, 287);
            addButton.Name = "addButton";
            addButton.Size = new Size(57, 23);
            addButton.TabIndex = 15;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += btnAdd_Click;
            // 
            // taskNameTextBox
            // 
            taskNameTextBox.Location = new Point(33, 287);
            taskNameTextBox.Name = "taskNameTextBox";
            taskNameTextBox.Size = new Size(133, 23);
            taskNameTextBox.TabIndex = 14;
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
            // finishedListBox
            // 
            finishedListBox.FormattingEnabled = true;
            finishedListBox.ItemHeight = 15;
            finishedListBox.Location = new Point(597, 43);
            finishedListBox.Name = "finishedListBox";
            finishedListBox.Size = new Size(194, 229);
            finishedListBox.TabIndex = 10;
            // 
            // toDoListBox
            // 
            toDoListBox.FormattingEnabled = true;
            toDoListBox.ItemHeight = 15;
            toDoListBox.Location = new Point(33, 43);
            toDoListBox.Name = "toDoListBox";
            toDoListBox.Size = new Size(194, 229);
            toDoListBox.TabIndex = 9;
            // 
            // toDoToInProgressButton
            // 
            toDoToInProgressButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toDoToInProgressButton.Location = new Point(233, 117);
            toDoToInProgressButton.Name = "toDoToInProgressButton";
            toDoToInProgressButton.Size = new Size(75, 36);
            toDoToInProgressButton.TabIndex = 13;
            toDoToInProgressButton.Text = ">";
            toDoToInProgressButton.UseVisualStyleBackColor = true;
            toDoToInProgressButton.Click += toProgress_Click;
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
            // inProgressListBox
            // 
            inProgressListBox.FormattingEnabled = true;
            inProgressListBox.ItemHeight = 15;
            inProgressListBox.Location = new Point(316, 43);
            inProgressListBox.Name = "inProgressListBox";
            inProgressListBox.Size = new Size(194, 229);
            inProgressListBox.TabIndex = 17;
            // 
            // inProgressToToDoButton
            // 
            inProgressToToDoButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inProgressToToDoButton.Location = new Point(235, 174);
            inProgressToToDoButton.Name = "inProgressToToDoButton";
            inProgressToToDoButton.Size = new Size(75, 36);
            inProgressToToDoButton.TabIndex = 19;
            inProgressToToDoButton.Text = "<";
            inProgressToToDoButton.UseVisualStyleBackColor = true;
            inProgressToToDoButton.Click += backtoTODO_Click;
            // 
            // finishedToInProgressButton
            // 
            finishedToInProgressButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            finishedToInProgressButton.Location = new Point(518, 174);
            finishedToInProgressButton.Name = "finishedToInProgressButton";
            finishedToInProgressButton.Size = new Size(75, 36);
            finishedToInProgressButton.TabIndex = 21;
            finishedToInProgressButton.Text = "<";
            finishedToInProgressButton.UseVisualStyleBackColor = true;
            finishedToInProgressButton.Click += backtoProgress_Click;
            // 
            // inProgressToFinishedButton
            // 
            inProgressToFinishedButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inProgressToFinishedButton.Location = new Point(516, 117);
            inProgressToFinishedButton.Name = "inProgressToFinishedButton";
            inProgressToFinishedButton.Size = new Size(75, 36);
            inProgressToFinishedButton.TabIndex = 20;
            inProgressToFinishedButton.Text = ">";
            inProgressToFinishedButton.UseVisualStyleBackColor = true;
            inProgressToFinishedButton.Click += toFinished_Click;
            // 
            // progressStatusStrip
            // 
            progressStatusStrip.Items.AddRange(new ToolStripItem[] { progressLabel, progressBar });
            progressStatusStrip.Location = new Point(0, 428);
            progressStatusStrip.Name = "progressStatusStrip";
            progressStatusStrip.Size = new Size(852, 22);
            progressStatusStrip.TabIndex = 22;
            progressStatusStrip.Text = "statusStrip1";
            // 
            // ProgressLabel
            // 
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new Size(0, 17);
            // 
            // progressBar
            // 
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(100, 16);
            // 
            // TaskTrackerWithStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 450);
            Controls.Add(progressStatusStrip);
            Controls.Add(finishedToInProgressButton);
            Controls.Add(inProgressToFinishedButton);
            Controls.Add(inProgressToToDoButton);
            Controls.Add(label3);
            Controls.Add(inProgressListBox);
            Controls.Add(addButton);
            Controls.Add(taskNameTextBox);
            Controls.Add(toDoToInProgressButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(finishedListBox);
            Controls.Add(toDoListBox);
            Name = "TaskTrackerWithStatus";
            Text = "TaskTrackerWithStatus";
            progressStatusStrip.ResumeLayout(false);
            progressStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addButton;
        private TextBox taskNameTextBox;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.ListBox finishedListBox;
        private System.Windows.Forms.ListBox toDoListBox;
        private Button toDoToInProgressButton;
        private Label label3;
        private System.Windows.Forms.ListBox inProgressListBox;
        private Button inProgressToToDoButton;
        private Button finishedToInProgressButton;
        private Button inProgressToFinishedButton;
        private StatusStrip progressStatusStrip;
        private ToolStripStatusLabel progressLabel;
        private ToolStripProgressBar progressBar;
    }
}