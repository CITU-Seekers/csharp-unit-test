namespace CodeChum
{
    partial class ClassCreationForm
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
            txtClassName = new TextBox();
            cboSched = new System.Windows.Forms.ComboBox();
            txtClassCode = new TextBox();
            txtClassDesc = new RichTextBox();
            btnCreateClass = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(57, 51);
            txtClassName.Name = "txtClassName";
            txtClassName.PlaceholderText = "Class Name";
            txtClassName.Size = new Size(331, 23);
            txtClassName.TabIndex = 0;
            // 
            // cboSched
            // 
            cboSched.FormattingEnabled = true;
            cboSched.Items.AddRange(new object[] { "7:30 AM - 9:30 AM", "9:30 AM - 11:30 AM", "1:00 PM - 3:00 PM", "3:00 PM - 5:00 PM", "5:00 PM - 7:00 PM", "7:00 PM - 9:00 PM" });
            cboSched.Location = new Point(57, 96);
            cboSched.Name = "cboSched";
            cboSched.Size = new Size(173, 23);
            cboSched.TabIndex = 1;
            // 
            // txtClassCode
            // 
            txtClassCode.Location = new Point(257, 96);
            txtClassCode.Name = "txtClassCode";
            txtClassCode.PlaceholderText = "Class Code";
            txtClassCode.Size = new Size(131, 23);
            txtClassCode.TabIndex = 2;
            // 
            // txtClassDesc
            // 
            txtClassDesc.Location = new Point(57, 140);
            txtClassDesc.Name = "txtClassDesc";
            txtClassDesc.Size = new Size(331, 144);
            txtClassDesc.TabIndex = 3;
            txtClassDesc.Text = "";
            // 
            // btnCreateClass
            // 
            btnCreateClass.Location = new Point(97, 307);
            btnCreateClass.Name = "btnCreateClass";
            btnCreateClass.Size = new Size(75, 23);
            btnCreateClass.TabIndex = 4;
            btnCreateClass.Text = "Create";
            btnCreateClass.UseVisualStyleBackColor = true;
            btnCreateClass.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(267, 307);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ClassCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 352);
            Controls.Add(btnCancel);
            Controls.Add(btnCreateClass);
            Controls.Add(txtClassDesc);
            Controls.Add(txtClassCode);
            Controls.Add(cboSched);
            Controls.Add(txtClassName);
            Name = "ClassCreationForm";
            Text = "ClassCreationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox txtClassName;
        public RichTextBox txtClassDesc;
        public System.Windows.Forms.ComboBox cboSched;
        public TextBox txtClassCode;
        private Button btnCreateClass;
        private Button btnCancel;
    }
}