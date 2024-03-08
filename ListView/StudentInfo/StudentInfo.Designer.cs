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
            StudentDB = new ListView();
            studID = new ColumnHeader();
            studName = new ColumnHeader();
            studDOB = new ColumnHeader();
            CourseYear = new ColumnHeader();
            btnRemove = new Button();
            btnAdd = new Button();
            BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            StudentName = new TextBox();
            StudentID = new TextBox();
            cboCourse = new System.Windows.Forms.ComboBox();
            cboYear = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // StudentDB
            // 
            StudentDB.Columns.AddRange(new ColumnHeader[] { studID, studName, studDOB, CourseYear });
            StudentDB.Location = new Point(38, 26);
            StudentDB.Name = "StudentDB";
            StudentDB.Size = new Size(425, 142);
            StudentDB.TabIndex = 7;
            StudentDB.UseCompatibleStateImageBehavior = false;
            StudentDB.View = View.Details;
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
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.Location = new Point(318, 367);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 30);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(108, 367);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 30);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // BirthDatePicker
            // 
            BirthDatePicker.Location = new Point(38, 277);
            BirthDatePicker.Name = "BirthDatePicker";
            BirthDatePicker.Size = new Size(425, 23);
            BirthDatePicker.TabIndex = 10;
            // 
            // StudentName
            // 
            StudentName.Location = new Point(38, 239);
            StudentName.Name = "StudentName";
            StudentName.PlaceholderText = "Name";
            StudentName.Size = new Size(425, 23);
            StudentName.TabIndex = 9;
            // 
            // StudentID
            // 
            StudentID.Location = new Point(38, 201);
            StudentID.Name = "StudentID";
            StudentID.PlaceholderText = "ID";
            StudentID.Size = new Size(425, 23);
            StudentID.TabIndex = 8;
            // 
            // cboCourse
            // 
            cboCourse.FormattingEnabled = true;
            cboCourse.Items.AddRange(new object[] { "BSCS", "BSBA", "BSIT", "BMMA", "BSCE", "BSME", "BSTM", "BSHRM" });
            cboCourse.Location = new Point(38, 315);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(234, 23);
            cboCourse.TabIndex = 14;
            cboCourse.Text = "Course";
            // 
            // cboYear
            // 
            cboYear.FormattingEnabled = true;
            cboYear.Items.AddRange(new object[] { "1st Year", "2nd Year", "3rd Year", "4th Year" });
            cboYear.Location = new Point(318, 315);
            cboYear.Name = "cboYear";
            cboYear.RightToLeft = RightToLeft.No;
            cboYear.Size = new Size(113, 23);
            cboYear.TabIndex = 15;
            cboYear.Text = "Year";
            // 
            // StudentInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 450);
            Controls.Add(cboYear);
            Controls.Add(cboCourse);
            Controls.Add(StudentDB);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(BirthDatePicker);
            Controls.Add(StudentName);
            Controls.Add(StudentID);
            Name = "StudentInfo";
            Text = "StudentInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView StudentDB;
        private ColumnHeader studID;
        private ColumnHeader studName;
        private ColumnHeader studDOB;
        private Button btnRemove;
        private Button btnAdd;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private TextBox StudentName;
        private TextBox StudentID;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.ComboBox cboYear;
        private ColumnHeader CourseYear;
    }
}