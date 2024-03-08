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
            DatePicker = new System.Windows.Forms.DateTimePicker();
            ReservationSummary = new Label();
            btnAdd = new Button();
            label3 = new Label();
            TaskName = new TextBox();
            label2 = new Label();
            lblToDoList = new Label();
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
            // DatePicker
            // 
            DatePicker.Location = new Point(73, 88);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(200, 23);
            DatePicker.TabIndex = 4;
            // 
            // ReservationSummary
            // 
            ReservationSummary.AutoSize = true;
            ReservationSummary.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ReservationSummary.Location = new Point(73, 259);
            ReservationSummary.Name = "ReservationSummary";
            ReservationSummary.Size = new Size(0, 20);
            ReservationSummary.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(73, 212);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 31);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
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
            // TaskName
            // 
            TaskName.Location = new Point(73, 162);
            TaskName.Name = "TaskName";
            TaskName.Size = new Size(200, 23);
            TaskName.TabIndex = 8;
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
            lblToDoList.AutoSize = true;
            lblToDoList.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblToDoList.Location = new Point(372, 80);
            lblToDoList.Name = "lblToDoList";
            lblToDoList.Size = new Size(0, 20);
            lblToDoList.TabIndex = 13;
            // 
            // TaskSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblToDoList);
            Controls.Add(label2);
            Controls.Add(ReservationSummary);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(TaskName);
            Controls.Add(label1);
            Controls.Add(DatePicker);
            Name = "TaskSchedule";
            Text = "TaskScheduler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private Label ReservationSummary;
        private Button btnAdd;
        private Label label3;
        private TextBox TaskName;
        private Label label2;
        private Label lblToDoList;
    }
}