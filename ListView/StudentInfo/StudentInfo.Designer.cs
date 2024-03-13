namespace CodeChum
{
    partial class StudentInfo
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
            studentListView = new ListView();
            studID = new ColumnHeader();
            studName = new ColumnHeader();
            studDOB = new ColumnHeader();
            CourseYear = new ColumnHeader();
            removeButton = new Button();
            addButton = new Button();
            birthDayDateTimePicker = new DateTimePicker();
            studentNameTextBox = new TextBox();
            studentIDTextBox = new TextBox();
            courseComboBox = new ComboBox();
            yearComboBox = new ComboBox();
            SuspendLayout();
            // 
            // studentListView
            // 
            studentListView.Columns.AddRange(new ColumnHeader[] { studID, studName, studDOB, CourseYear });
            studentListView.Location = new Point(38, 26);
            studentListView.Name = "studentListView";
            studentListView.Size = new Size(425, 142);
            studentListView.TabIndex = 7;
            studentListView.UseCompatibleStateImageBehavior = false;
            studentListView.View = View.Details;
            // 
            // studID
            // 
            studID.Text = "ID";
            studID.Width = 80;
            // 
            // studName
            // 
            studName.Text = "Name";
            studName.Width = 150;
            // 
            // studDOB
            // 
            studDOB.Text = "Date of Birth";
            studDOB.Width = 100;
            // 
            // CourseYear
            // 
            CourseYear.Text = "Course & Year";
            CourseYear.Width = 100;
            // 
            // removeButton
            // 
            removeButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            removeButton.Location = new Point(318, 367);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 30);
            removeButton.TabIndex = 13;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += btnRemove_Click;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(108, 367);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 30);
            addButton.TabIndex = 12;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += btnAdd_Click;
            // 
            // birthDayDateTimePicker
            // 
            birthDayDateTimePicker.Location = new Point(38, 277);
            birthDayDateTimePicker.Name = "birthDayDateTimePicker";
            birthDayDateTimePicker.Size = new Size(425, 23);
            birthDayDateTimePicker.TabIndex = 10;
            // 
            // studentNameTextBox
            // 
            studentNameTextBox.Location = new Point(38, 239);
            studentNameTextBox.Name = "studentNameTextBox";
            studentNameTextBox.PlaceholderText = "Name";
            studentNameTextBox.Size = new Size(425, 23);
            studentNameTextBox.TabIndex = 9;
            // 
            // studentIDTextBox
            // 
            studentIDTextBox.Location = new Point(38, 201);
            studentIDTextBox.Name = "studentIDTextBox";
            studentIDTextBox.PlaceholderText = "ID";
            studentIDTextBox.Size = new Size(425, 23);
            studentIDTextBox.TabIndex = 8;
            // 
            // courseComboBox
            // 
            courseComboBox.FormattingEnabled = true;
            courseComboBox.Items.AddRange(new object[] { "BSCS", "BSBA", "BSIT", "BMMA", "BSCE", "BSME", "BSTM", "BSHRM" });
            courseComboBox.Location = new Point(38, 315);
            courseComboBox.Name = "courseComboBox";
            courseComboBox.Size = new Size(234, 23);
            courseComboBox.TabIndex = 14;
            courseComboBox.Text = "Course";
            // 
            // yearComboBox
            // 
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Items.AddRange(new object[] { "1st Year", "2nd Year", "3rd Year", "4th Year" });
            yearComboBox.Location = new Point(318, 315);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.RightToLeft = RightToLeft.No;
            yearComboBox.Size = new Size(113, 23);
            yearComboBox.TabIndex = 15;
            yearComboBox.Text = "Year";
            // 
            // StudentInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 450);
            Controls.Add(yearComboBox);
            Controls.Add(courseComboBox);
            Controls.Add(studentListView);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(birthDayDateTimePicker);
            Controls.Add(studentNameTextBox);
            Controls.Add(studentIDTextBox);
            Name = "StudentInfo";
            Text = "StudentInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView studentListView;
        private ColumnHeader studID;
        private ColumnHeader studName;
        private ColumnHeader studDOB;
        private Button removeButton;
        private Button addButton;
        private System.Windows.Forms.DateTimePicker birthDayDateTimePicker;
        private TextBox studentNameTextBox;
        private TextBox studentIDTextBox;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private ColumnHeader CourseYear;
    }
}