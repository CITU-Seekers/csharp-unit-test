namespace CodeChum
{
    partial class SurveyForm
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
            NameTextBox = new TextBox();
            EmailTextBox = new TextBox();
            SatisfactionNumericControl = new NumericUpDown();
            YesRadioButton = new RadioButton();
            NoRadioButton = new RadioButton();
            SubmitButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)SatisfactionNumericControl).BeginInit();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(39, 24);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Name";
            NameTextBox.Size = new Size(292, 27);
            NameTextBox.TabIndex = 0;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(39, 56);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.PlaceholderText = "Email";
            EmailTextBox.Size = new Size(292, 27);
            EmailTextBox.TabIndex = 1;
            // 
            // SatisfactionNumericControl
            // 
            SatisfactionNumericControl.Location = new Point(39, 119);
            SatisfactionNumericControl.Name = "SatisfactionNumericControl";
            SatisfactionNumericControl.Size = new Size(292, 27);
            SatisfactionNumericControl.TabIndex = 2;
            // 
            // YesRadioButton
            // 
            YesRadioButton.AutoSize = true;
            YesRadioButton.Location = new Point(108, 188);
            YesRadioButton.Name = "YesRadioButton";
            YesRadioButton.Size = new Size(51, 24);
            YesRadioButton.TabIndex = 3;
            YesRadioButton.TabStop = true;
            YesRadioButton.Text = "Yes";
            YesRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoRadioButton
            // 
            NoRadioButton.AutoSize = true;
            NoRadioButton.Location = new Point(175, 186);
            NoRadioButton.Name = "NoRadioButton";
            NoRadioButton.Size = new Size(50, 24);
            NoRadioButton.TabIndex = 4;
            NoRadioButton.TabStop = true;
            NoRadioButton.Text = "No";
            NoRadioButton.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(234, 221);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(97, 35);
            SubmitButton.TabIndex = 5;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 96);
            label1.Name = "label1";
            label1.Size = new Size(273, 20);
            label1.TabIndex = 6;
            label1.Text = "How satisfied are you with our product?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 162);
            label2.Name = "label2";
            label2.Size = new Size(288, 20);
            label2.TabIndex = 7;
            label2.Text = "Would you be disappointed if our product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 188);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 8;
            label3.Text = "is gone?";
            // 
            // SurveyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 281);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SubmitButton);
            Controls.Add(NoRadioButton);
            Controls.Add(YesRadioButton);
            Controls.Add(SatisfactionNumericControl);
            Controls.Add(EmailTextBox);
            Controls.Add(NameTextBox);
            Name = "SurveyForm";
            Text = "Survey Form";
            Load += SurveyForm_Load;
            ((System.ComponentModel.ISupportInitialize)SatisfactionNumericControl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTextBox;
        private TextBox EmailTextBox;
        private NumericUpDown SatisfactionNumericControl;
        private RadioButton YesRadioButton;
        private RadioButton NoRadioButton;
        private Button SubmitButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}