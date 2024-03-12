namespace CodeChum
{
    partial class TextBoxFocus
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
            firstTextBox = new TextBox();
            secondTextBox = new TextBox();
            thirdTextBox = new TextBox();
            messageLabel = new Label();
            firstTextBoxFocusButton = new Button();
            secondTextBoxFocusButton = new Button();
            thirdTextBoxFocusButton = new Button();
            SuspendLayout();
            // 
            // firstTextBox
            // 
            firstTextBox.Location = new Point(19, 58);
            firstTextBox.Margin = new Padding(3, 2, 3, 2);
            firstTextBox.Name = "firstTextBox";
            firstTextBox.PlaceholderText = "First Text Box";
            firstTextBox.Size = new Size(324, 23);
            firstTextBox.TabIndex = 0;
            firstTextBox.Enter += FirstTextBox_Enter;
            // 
            // secondTextBox
            // 
            secondTextBox.Location = new Point(19, 88);
            secondTextBox.Margin = new Padding(3, 2, 3, 2);
            secondTextBox.Name = "secondTextBox";
            secondTextBox.PlaceholderText = "Second Text Box";
            secondTextBox.Size = new Size(324, 23);
            secondTextBox.TabIndex = 1;
            secondTextBox.Enter += SecondTextBox_Enter;
            // 
            // thirdTextBox
            // 
            thirdTextBox.Location = new Point(19, 119);
            thirdTextBox.Margin = new Padding(3, 2, 3, 2);
            thirdTextBox.Name = "thirdTextBox";
            thirdTextBox.PlaceholderText = "Third Text Box";
            thirdTextBox.Size = new Size(324, 23);
            thirdTextBox.TabIndex = 2;
            thirdTextBox.Enter += ThirdTextBox_Enter;
            // 
            // messageLabel
            // 
            messageLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            messageLabel.Location = new Point(83, 23);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(207, 22);
            messageLabel.TabIndex = 3;
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // firstTextBoxFocusButton
            // 
            firstTextBoxFocusButton.Location = new Point(31, 161);
            firstTextBoxFocusButton.Margin = new Padding(3, 2, 3, 2);
            firstTextBoxFocusButton.Name = "firstTextBoxFocusButton";
            firstTextBoxFocusButton.Size = new Size(82, 22);
            firstTextBoxFocusButton.TabIndex = 4;
            firstTextBoxFocusButton.Text = "1";
            firstTextBoxFocusButton.UseVisualStyleBackColor = true;
            firstTextBoxFocusButton.Click += FocusOnTextBox;
            // 
            // secondTextBoxFocusButton
            // 
            secondTextBoxFocusButton.Location = new Point(145, 161);
            secondTextBoxFocusButton.Margin = new Padding(3, 2, 3, 2);
            secondTextBoxFocusButton.Name = "secondTextBoxFocusButton";
            secondTextBoxFocusButton.Size = new Size(82, 22);
            secondTextBoxFocusButton.TabIndex = 5;
            secondTextBoxFocusButton.Text = "2";
            secondTextBoxFocusButton.UseVisualStyleBackColor = true;
            secondTextBoxFocusButton.Click += FocusOnTextBox;
            // 
            // thirdTextBoxFocusButton
            // 
            thirdTextBoxFocusButton.Location = new Point(261, 161);
            thirdTextBoxFocusButton.Margin = new Padding(3, 2, 3, 2);
            thirdTextBoxFocusButton.Name = "thirdTextBoxFocusButton";
            thirdTextBoxFocusButton.Size = new Size(82, 22);
            thirdTextBoxFocusButton.TabIndex = 6;
            thirdTextBoxFocusButton.Text = "3";
            thirdTextBoxFocusButton.UseVisualStyleBackColor = true;
            thirdTextBoxFocusButton.Click += FocusOnTextBox;
            // 
            // TextBoxFocus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 204);
            Controls.Add(thirdTextBoxFocusButton);
            Controls.Add(secondTextBoxFocusButton);
            Controls.Add(firstTextBoxFocusButton);
            Controls.Add(messageLabel);
            Controls.Add(thirdTextBox);
            Controls.Add(secondTextBox);
            Controls.Add(firstTextBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TextBoxFocus";
            Text = "Focusing on TextBoxes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstTextBox;
        private TextBox secondTextBox;
        private TextBox thirdTextBox;
        private Label messageLabel;
        private Button firstTextBoxFocusButton;
        private Button secondTextBoxFocusButton;
        private Button thirdTextBoxFocusButton;
    }
}