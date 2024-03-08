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
            ToDoList = new System.Windows.Forms.ListBox();
            FinishedList = new System.Windows.Forms.ListBox();
            label1 = new Label();
            label2 = new Label();
            btnDone = new Button();
            btnAdd = new Button();
            TaskName = new TextBox();
            btnRevert = new Button();
            SuspendLayout();
            // 
            // ToDoList
            // 
            ToDoList.FormattingEnabled = true;
            ToDoList.ItemHeight = 15;
            ToDoList.Location = new Point(121, 51);
            ToDoList.Name = "ToDoList";
            ToDoList.Size = new Size(194, 229);
            ToDoList.TabIndex = 0;
            // 
            // FinishedList
            // 
            FinishedList.FormattingEnabled = true;
            FinishedList.ItemHeight = 15;
            FinishedList.Location = new Point(424, 51);
            FinishedList.Name = "FinishedList";
            FinishedList.Size = new Size(194, 229);
            FinishedList.TabIndex = 1;
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
            // btnDone
            // 
            btnDone.Location = new Point(334, 147);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(75, 23);
            btnDone.TabIndex = 4;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(260, 295);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(57, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // TaskName
            // 
            TaskName.Location = new Point(121, 295);
            TaskName.Name = "TaskName";
            TaskName.Size = new Size(133, 23);
            TaskName.TabIndex = 6;
            // 
            // btnRevert
            // 
            btnRevert.Location = new Point(480, 295);
            btnRevert.Name = "btnRevert";
            btnRevert.Size = new Size(75, 23);
            btnRevert.TabIndex = 8;
            btnRevert.Text = "Revert";
            btnRevert.UseVisualStyleBackColor = true;
            btnRevert.Click += btnRevert_Click;
            // 
            // TaskTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRevert);
            Controls.Add(btnAdd);
            Controls.Add(TaskName);
            Controls.Add(btnDone);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FinishedList);
            Controls.Add(ToDoList);
            Name = "TaskTracker";
            Text = "TaskTracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox ToDoList;
        private System.Windows.Forms.ListBox FinishedList;
        private Label label1;
        private Label label2;
        private Button btnDone;
        private Button btnAdd;
        private TextBox TaskName;
        private Button btnRevert;
    }
}