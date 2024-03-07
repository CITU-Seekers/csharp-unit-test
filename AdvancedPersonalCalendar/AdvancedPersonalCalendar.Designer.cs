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
            MonthCalendar = new MonthCalendar();
            EventName = new TextBox();
            cboFrequency = new System.Windows.Forms.ComboBox();
            btnAdd = new Button();
            lblEvent = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // MonthCalendar
            // 
            MonthCalendar.Location = new Point(74, 33);
            MonthCalendar.Name = "MonthCalendar";
            MonthCalendar.TabIndex = 0;
            // 
            // EventName
            // 
            EventName.Location = new Point(74, 207);
            EventName.Multiline = true;
            EventName.Name = "EventName";
            EventName.Size = new Size(227, 23);
            EventName.TabIndex = 1;
            // 
            // cboFrequency
            // 
            cboFrequency.FormattingEnabled = true;
            cboFrequency.Items.AddRange(new object[] { "None", "Daily", "Every Weekdays", "Every Weekends", "Every Week", "Every Month", "Every Year" });
            cboFrequency.Location = new Point(74, 236);
            cboFrequency.Name = "cboFrequency";
            cboFrequency.Size = new Size(121, 23);
            cboFrequency.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(226, 236);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Event";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblEvent
            // 
            lblEvent.AutoSize = true;
            lblEvent.Location = new Point(74, 271);
            lblEvent.Name = "lblEvent";
            lblEvent.Size = new Size(0, 15);
            lblEvent.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(226, 267);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // AdvancedPersonalCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 321);
            Controls.Add(btnDelete);
            Controls.Add(lblEvent);
            Controls.Add(btnAdd);
            Controls.Add(cboFrequency);
            Controls.Add(EventName);
            Controls.Add(MonthCalendar);
            Name = "AdvancedPersonalCalendar";
            Text = "AdvancedPersonalCalendar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar MonthCalendar;
        private TextBox EventName;
        private System.Windows.Forms.ComboBox cboFrequency;
        private Button btnAdd;
        private Label lblEvent;
        private Button btnDelete;
    }
}