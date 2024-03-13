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
            classNameTextBox = new TextBox();
            scheduleComboBox = new ComboBox();
            classCodeTextBox = new TextBox();
            classDescriptionRichTextBox = new RichTextBox();
            createClassButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // classNameTextBox
            // 
            classNameTextBox.Location = new Point(57, 51);
            classNameTextBox.Name = "classNameTextBox";
            classNameTextBox.PlaceholderText = "Class Name";
            classNameTextBox.Size = new Size(331, 23);
            classNameTextBox.TabIndex = 0;
            // 
            // scheduleComboBox
            // 
            scheduleComboBox.FormattingEnabled = true;
            scheduleComboBox.Items.AddRange(new object[] { "7:30 AM - 9:30 AM", "9:30 AM - 11:30 AM", "1:00 PM - 3:00 PM", "3:00 PM - 5:00 PM", "5:00 PM - 7:00 PM", "7:00 PM - 9:00 PM" });
            scheduleComboBox.Location = new Point(57, 96);
            scheduleComboBox.Name = "scheduleComboBox";
            scheduleComboBox.Size = new Size(173, 23);
            scheduleComboBox.TabIndex = 1;
            // 
            // classCodeTextBox
            // 
            classCodeTextBox.Location = new Point(257, 96);
            classCodeTextBox.Name = "classCodeTextBox";
            classCodeTextBox.PlaceholderText = "Class Code";
            classCodeTextBox.Size = new Size(131, 23);
            classCodeTextBox.TabIndex = 2;
            // 
            // classDescriptionRichTextBox
            // 
            classDescriptionRichTextBox.Location = new Point(57, 140);
            classDescriptionRichTextBox.Name = "classDescriptionRichTextBox";
            classDescriptionRichTextBox.Size = new Size(331, 144);
            classDescriptionRichTextBox.TabIndex = 3;
            classDescriptionRichTextBox.Text = "";
            // 
            // createClassButton
            // 
            createClassButton.Location = new Point(97, 307);
            createClassButton.Name = "createClassButton";
            createClassButton.Size = new Size(75, 23);
            createClassButton.TabIndex = 4;
            createClassButton.Text = "Create";
            createClassButton.UseVisualStyleBackColor = true;
            createClassButton.Click += btnCreate_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(267, 307);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += btnCancel_Click;
            // 
            // ClassCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 352);
            Controls.Add(cancelButton);
            Controls.Add(createClassButton);
            Controls.Add(classDescriptionRichTextBox);
            Controls.Add(classCodeTextBox);
            Controls.Add(scheduleComboBox);
            Controls.Add(classNameTextBox);
            Name = "ClassCreationForm";
            Text = "ClassCreationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox classNameTextBox;
        public RichTextBox classDescriptionRichTextBox;
        public System.Windows.Forms.ComboBox scheduleComboBox;
        public TextBox classCodeTextBox;
        private Button createClassButton;
        private Button cancelButton;
    }
}