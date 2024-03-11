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
            this.HourNumericControl = new System.Windows.Forms.NumericUpDown();
            this.MinuteNumericControl = new System.Windows.Forms.NumericUpDown();
            this.TwelveHourLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HourNumericControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteNumericControl)).BeginInit();
            this.SuspendLayout();
            // 
            // HourNumericControl
            // 
            this.HourNumericControl.Location = new System.Drawing.Point(189, 37);
            this.HourNumericControl.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.HourNumericControl.Name = "HourNumericControl";
            this.HourNumericControl.Size = new System.Drawing.Size(71, 27);
            this.HourNumericControl.TabIndex = 0;
            this.HourNumericControl.ValueChanged += new System.EventHandler(this.HourNumericControl_ValueChanged);
            // 
            // MinuteNumericControl
            // 
            this.MinuteNumericControl.Location = new System.Drawing.Point(266, 37);
            this.MinuteNumericControl.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinuteNumericControl.Name = "MinuteNumericControl";
            this.MinuteNumericControl.Size = new System.Drawing.Size(69, 27);
            this.MinuteNumericControl.TabIndex = 1;
            this.MinuteNumericControl.ValueChanged += new System.EventHandler(this.MinuteNumericControl_ValueChanged);
            // 
            // TwelveHourLabel
            // 
            this.TwelveHourLabel.AutoSize = true;
            this.TwelveHourLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TwelveHourLabel.Location = new System.Drawing.Point(189, 77);
            this.TwelveHourLabel.Name = "TwelveHourLabel";
            this.TwelveHourLabel.Size = new System.Drawing.Size(89, 25);
            this.TwelveHourLabel.TabIndex = 2;
            this.TwelveHourLabel.Text = "12:00 AM";
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
            this.Controls.Add(this.TwelveHourLabel);
            this.Controls.Add(this.MinuteNumericControl);
            this.Controls.Add(this.HourNumericControl);
            this.Name = "TimeConverter";
            this.Text = "Time Converter";
            ((System.ComponentModel.ISupportInitialize)(this.HourNumericControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteNumericControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown HourNumericControl;
        private NumericUpDown MinuteNumericControl;
        private Label TwelveHourLabel;
        private Label label1;
        private Label label2;
    }
}