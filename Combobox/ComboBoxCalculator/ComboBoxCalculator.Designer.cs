namespace CodeChum
{
    partial class ComboBoxCalculator
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
            this.TextNumber1 = new System.Windows.Forms.TextBox();
            this.TextNumber2 = new System.Windows.Forms.TextBox();
            this.OperationsComboBox = new System.Windows.Forms.ComboBox();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextNumber1
            // 
            this.TextNumber1.Location = new System.Drawing.Point(29, 37);
            this.TextNumber1.Name = "TextNumber1";
            this.TextNumber1.Size = new System.Drawing.Size(74, 27);
            this.TextNumber1.TabIndex = 0;
            // 
            // TextNumber2
            // 
            this.TextNumber2.Location = new System.Drawing.Point(218, 36);
            this.TextNumber2.Name = "TextNumber2";
            this.TextNumber2.Size = new System.Drawing.Size(63, 27);
            this.TextNumber2.TabIndex = 1;
            // 
            // OperationsComboBox
            // 
            this.OperationsComboBox.FormattingEnabled = true;
            this.OperationsComboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.OperationsComboBox.Location = new System.Drawing.Point(127, 36);
            this.OperationsComboBox.Name = "OperationsComboBox";
            this.OperationsComboBox.Size = new System.Drawing.Size(70, 28);
            this.OperationsComboBox.TabIndex = 2;
            // 
            // ComputeButton
            // 
            this.ComputeButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComputeButton.Location = new System.Drawing.Point(143, 99);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(150, 36);
            this.ComputeButton.TabIndex = 3;
            this.ComputeButton.Text = "Calculate";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(331, 39);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 20);
            this.ResultLabel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            // 
            // ComboBoxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 160);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.OperationsComboBox);
            this.Controls.Add(this.TextNumber2);
            this.Controls.Add(this.TextNumber1);
            this.Name = "ComboBoxCalculator";
            this.Text = "Combo Box Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextNumber1;
        private TextBox TextNumber2;
        private System.Windows.Forms.ComboBox OperationsComboBox;
        private Button ComputeButton;
        private Label ResultLabel;
        private Label label1;
    }
}