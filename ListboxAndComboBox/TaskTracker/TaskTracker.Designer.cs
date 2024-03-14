namespace CodeChum
{
    partial class TaskTracker
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
            toDoListBox = new ListBox();
            finishedListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            doneButton = new Button();
            addButton = new Button();
            taskNameTextBox = new TextBox();
            revertButton = new Button();
            SuspendLayout();
            // 
            // toDoListBox
            // 
            toDoListBox.FormattingEnabled = true;
            toDoListBox.ItemHeight = 15;
            toDoListBox.Location = new Point(121, 51);
            toDoListBox.Name = "toDoListBox";
            toDoListBox.Size = new Size(194, 229);
            toDoListBox.TabIndex = 0;
            // 
            // finishedListBox
            // 
            finishedListBox.FormattingEnabled = true;
            finishedListBox.ItemHeight = 15;
            finishedListBox.Location = new Point(424, 51);
            finishedListBox.Name = "finishedListBox";
            finishedListBox.Size = new Size(194, 229);
            finishedListBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(121, 27);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 2;
            label1.Text = "To Do:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(424, 27);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 3;
            label2.Text = "Finished:";
            // 
            // doneButton
            // 
            doneButton.Location = new Point(334, 147);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(75, 23);
            doneButton.TabIndex = 4;
            doneButton.Text = "Done";
            doneButton.UseVisualStyleBackColor = true;
            doneButton.Click += btnDone_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(260, 295);
            addButton.Name = "addButton";
            addButton.Size = new Size(57, 23);
            addButton.TabIndex = 7;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += btnAdd_Click;
            // 
            // taskNameTextBox
            // 
            taskNameTextBox.Location = new Point(121, 295);
            taskNameTextBox.Name = "taskNameTextBox";
            taskNameTextBox.Size = new Size(133, 23);
            taskNameTextBox.TabIndex = 6;
            // 
            // revertButton
            // 
            revertButton.Location = new Point(480, 295);
            revertButton.Name = "revertButton";
            revertButton.Size = new Size(75, 23);
            revertButton.TabIndex = 8;
            revertButton.Text = "Revert";
            revertButton.UseVisualStyleBackColor = true;
            revertButton.Click += btnRevert_Click;
            // 
            // TaskTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(revertButton);
            Controls.Add(addButton);
            Controls.Add(taskNameTextBox);
            Controls.Add(doneButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(finishedListBox);
            Controls.Add(toDoListBox);
            Name = "TaskTracker";
            Text = "TaskTracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox toDoListBox;
        private System.Windows.Forms.ListBox finishedListBox;
        private Label label1;
        private Label label2;
        private Button doneButton;
        private Button addButton;
        private TextBox taskNameTextBox;
        private Button revertButton;
    }
}