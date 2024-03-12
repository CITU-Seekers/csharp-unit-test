namespace CodeChum
{
    partial class SimpleDatePicker
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
            exactDateTimePicker = new DateTimePicker();
            dateLabel = new Label();
            SuspendLayout();
            // 
            // exactDateTimePicker
            // 
            exactDateTimePicker.Location = new Point(25, 22);
            exactDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            exactDateTimePicker.Name = "exactDateTimePicker";
            exactDateTimePicker.Size = new Size(248, 23);
            exactDateTimePicker.TabIndex = 0;
            exactDateTimePicker.ValueChanged += DateTimePicker_ValueChanged;
            // 
            // dateLabel
            // 
            dateLabel.Location = new Point(25, 52);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(248, 22);
            dateLabel.TabIndex = 1;
            dateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SimpleDatePicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 161);
            Controls.Add(dateLabel);
            Controls.Add(exactDateTimePicker);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SimpleDatePicker";
            Text = "Simple Date Picker";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker exactDateTimePicker;
        private Label dateLabel;
    }
}