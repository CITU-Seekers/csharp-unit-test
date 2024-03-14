namespace CodeChum
{
    partial class TimeConverter
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
            this.hourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.twelveHourLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // hourNumericUpDown
            // 
            this.hourNumericUpDown.Location = new System.Drawing.Point(189, 37);
            this.hourNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourNumericUpDown.Name = "hourNumericUpDown";
            this.hourNumericUpDown.Size = new System.Drawing.Size(71, 27);
            this.hourNumericUpDown.TabIndex = 0;
            this.hourNumericUpDown.ValueChanged += new System.EventHandler(this.HourNumericControl_ValueChanged);
            // 
            // minuteNumericUpDown
            // 
            this.minuteNumericUpDown.Location = new System.Drawing.Point(266, 37);
            this.minuteNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteNumericUpDown.Name = "minuteNumericUpDown";
            this.minuteNumericUpDown.Size = new System.Drawing.Size(69, 27);
            this.minuteNumericUpDown.TabIndex = 1;
            this.minuteNumericUpDown.ValueChanged += new System.EventHandler(this.MinuteNumericControl_ValueChanged);
            // 
            // twelveHourLabel
            // 
            this.twelveHourLabel.AutoSize = true;
            this.twelveHourLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.twelveHourLabel.Location = new System.Drawing.Point(189, 77);
            this.twelveHourLabel.Name = "twelveHourLabel";
            this.twelveHourLabel.Size = new System.Drawing.Size(89, 25);
            this.twelveHourLabel.TabIndex = 2;
            this.twelveHourLabel.Text = "12:00 AM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "24 Hour Format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(53, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "12 Hour Format";
            // 
            // TimeConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 124);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.twelveHourLabel);
            this.Controls.Add(this.minuteNumericUpDown);
            this.Controls.Add(this.hourNumericUpDown);
            this.Name = "TimeConverter";
            this.Text = "Time Converter";
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown hourNumericUpDown;
        private NumericUpDown minuteNumericUpDown;
        private Label twelveHourLabel;
        private Label label1;
        private Label label2;
    }
}