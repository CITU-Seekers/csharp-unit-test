namespace CodeChum
{
    partial class TaskSchedule
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
            label1 = new Label();
            dateTimePicker = new DateTimePicker();
            taskSummaryLabel = new Label();
            addButton = new Button();
            label3 = new Label();
            taskTextBox = new TextBox();
            label2 = new Label();
            toDoListLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(73, 60);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 5;
            label1.Text = "Date";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(73, 88);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 4;
            // 
            // ReservationSummary
            // 
            taskSummaryLabel.AutoSize = true;
            taskSummaryLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            taskSummaryLabel.Location = new Point(73, 259);
            taskSummaryLabel.Name = "taskSummaryLabel";
            taskSummaryLabel.Size = new Size(0, 20);
            taskSummaryLabel.TabIndex = 11;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(73, 212);
            addButton.Name = "addButton";
            addButton.Size = new Size(80, 31);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(73, 130);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 9;
            label3.Text = "Task Name";
            // 
            // taskTextBox
            // 
            taskTextBox.Location = new Point(73, 162);
            taskTextBox.Name = "taskTextBox";
            taskTextBox.Size = new Size(200, 23);
            taskTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(354, 60);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 12;
            label2.Text = "TO DO:";
            // 
            // lblToDoList
            // 
            toDoListLabel.AutoSize = true;
            toDoListLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            toDoListLabel.Location = new Point(372, 80);
            toDoListLabel.Name = "toDoListLabel";
            toDoListLabel.Size = new Size(0, 20);
            toDoListLabel.TabIndex = 13;
            // 
            // TaskSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toDoListLabel);
            Controls.Add(label2);
            Controls.Add(taskSummaryLabel);
            Controls.Add(addButton);
            Controls.Add(label3);
            Controls.Add(taskTextBox);
            Controls.Add(label1);
            Controls.Add(dateTimePicker);
            Name = "TaskSchedule";
            Text = "TaskScheduler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private Label taskSummaryLabel;
        private Button addButton;
        private Label label3;
        private TextBox taskTextBox;
        private Label label2;
        private Label toDoListLabel;
    }
}