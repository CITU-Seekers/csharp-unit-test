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
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            satisfactionNumericControl = new NumericUpDown();
            yesRadioButton = new RadioButton();
            noRadioButton = new RadioButton();
            submitButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)satisfactionNumericControl).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(39, 24);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Name";
            nameTextBox.Size = new Size(292, 27);
            nameTextBox.TabIndex = 0;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(39, 56);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Email";
            emailTextBox.Size = new Size(292, 27);
            emailTextBox.TabIndex = 1;
            // 
            // satisfactionNumericControl
            // 
            satisfactionNumericControl.Location = new Point(39, 119);
            satisfactionNumericControl.Name = "satisfactionNumericControl";
            satisfactionNumericControl.Size = new Size(292, 27);
            satisfactionNumericControl.TabIndex = 2;
            // 
            // yesRadioButton
            // 
            yesRadioButton.AutoSize = true;
            yesRadioButton.Location = new Point(108, 188);
            yesRadioButton.Name = "yesRadioButton";
            yesRadioButton.Size = new Size(51, 24);
            yesRadioButton.TabIndex = 3;
            yesRadioButton.TabStop = true;
            yesRadioButton.Text = "Yes";
            yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // noRadioButton
            // 
            noRadioButton.AutoSize = true;
            noRadioButton.Location = new Point(175, 186);
            noRadioButton.Name = "noRadioButton";
            noRadioButton.Size = new Size(50, 24);
            noRadioButton.TabIndex = 4;
            noRadioButton.TabStop = true;
            noRadioButton.Text = "No";
            noRadioButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(234, 221);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(97, 35);
            submitButton.TabIndex = 5;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += SubmitButton_Click;
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
            Controls.Add(submitButton);
            Controls.Add(noRadioButton);
            Controls.Add(yesRadioButton);
            Controls.Add(satisfactionNumericControl);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            Name = "SurveyForm";
            Text = "Survey Form";
            Load += SurveyForm_Load;
            ((System.ComponentModel.ISupportInitialize)satisfactionNumericControl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private NumericUpDown satisfactionNumericControl;
        private RadioButton yesRadioButton;
        private RadioButton noRadioButton;
        private Button submitButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}