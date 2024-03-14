namespace CodeChum
{
    partial class TemperatureConverter
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
            label1 = new Label();
            celsiusTextBox = new TextBox();
            convertButton = new Button();
            fahrenheitLabel = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 62);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Celcius (°C)";
            // 
            // celsiusTextBox
            // 
            celsiusTextBox.Location = new Point(108, 80);
            celsiusTextBox.Multiline = true;
            celsiusTextBox.Name = "celsiusTextBox";
            celsiusTextBox.Size = new Size(173, 23);
            celsiusTextBox.TabIndex = 2;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(152, 134);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(75, 23);
            convertButton.TabIndex = 3;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += btnConvert_Click;
            // 
            // fahrenheitLabel
            // 
            fahrenheitLabel.AutoSize = true;
            fahrenheitLabel.BorderStyle = BorderStyle.Fixed3D;
            fahrenheitLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fahrenheitLabel.Location = new Point(108, 196);
            fahrenheitLabel.MinimumSize = new Size(173, 24);
            fahrenheitLabel.Name = "fahrenheitLabel";
            fahrenheitLabel.Size = new Size(173, 24);
            fahrenheitLabel.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 178);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 5;
            label2.Text = "Fahrenheit (°F)";
            // 
            // TemperatureConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 308);
            Controls.Add(fahrenheitLabel);
            Controls.Add(label2);
            Controls.Add(convertButton);
            Controls.Add(celsiusTextBox);
            Controls.Add(label1);
            Name = "TemperatureConverter";
            Text = "TemperatureConverter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox celsiusTextBox;
        private Button convertButton;
        private Label fahrenheitLabel;
        private Label label2;
    }
}