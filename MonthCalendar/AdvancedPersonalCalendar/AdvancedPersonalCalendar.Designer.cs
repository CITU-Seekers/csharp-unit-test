namespace CodeChum
{
    partial class AdvancedPersonalCalendar
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
            monthCalendar = new MonthCalendar();
            eventNameTextBox = new TextBox();
            frequencyComboBox = new ComboBox();
            addButton = new Button();
            eventLabel = new Label();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(74, 33);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 0;
            // 
            // eventNameTextBox
            // 
            eventNameTextBox.Location = new Point(74, 207);
            eventNameTextBox.Multiline = true;
            eventNameTextBox.Name = "eventNameTextBox";
            eventNameTextBox.Size = new Size(227, 23);
            eventNameTextBox.TabIndex = 1;
            // 
            // frequencyComboBox
            // 
            frequencyComboBox.FormattingEnabled = true;
            frequencyComboBox.Items.AddRange(new object[] { "None", "Daily", "Every Weekdays", "Every Weekends", "Every Week", "Every Month", "Every Year" });
            frequencyComboBox.Location = new Point(74, 236);
            frequencyComboBox.Name = "frequencyComboBox";
            frequencyComboBox.Size = new Size(121, 23);
            frequencyComboBox.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.Location = new Point(226, 236);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Add Event";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += btnAdd_Click;
            // 
            // eventLabel
            // 
            eventLabel.AutoSize = true;
            eventLabel.Location = new Point(74, 271);
            eventLabel.Name = "eventLabel";
            eventLabel.Size = new Size(0, 15);
            eventLabel.TabIndex = 4;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(226, 267);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += btnDelete_Click;
            // 
            // AdvancedPersonalCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 321);
            Controls.Add(deleteButton);
            Controls.Add(eventLabel);
            Controls.Add(addButton);
            Controls.Add(frequencyComboBox);
            Controls.Add(eventNameTextBox);
            Controls.Add(monthCalendar);
            Name = "AdvancedPersonalCalendar";
            Text = "AdvancedPersonalCalendar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar;
        private TextBox eventNameTextBox;
        private System.Windows.Forms.ComboBox frequencyComboBox;
        private Button addButton;
        private Label eventLabel;
        private Button deleteButton;
    }
}