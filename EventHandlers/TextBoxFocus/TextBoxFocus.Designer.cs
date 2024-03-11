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
            this.FirstTextBox = new System.Windows.Forms.TextBox();
            this.SecondTextBox = new System.Windows.Forms.TextBox();
            this.ThirdTextBox = new System.Windows.Forms.TextBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.FirstTextBoxFocusButton = new System.Windows.Forms.Button();
            this.SecondTextBoxFocusButton = new System.Windows.Forms.Button();
            this.ThirdTextBoxFocusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstTextBox
            // 
            this.FirstTextBox.Location = new System.Drawing.Point(22, 78);
            this.FirstTextBox.Name = "FirstTextBox";
            this.FirstTextBox.PlaceholderText = "First Text Box";
            this.FirstTextBox.Size = new System.Drawing.Size(370, 27);
            this.FirstTextBox.TabIndex = 0;
            this.FirstTextBox.Enter += new System.EventHandler(this.FirstTextBox_Enter);
            // 
            // SecondTextBox
            // 
            this.SecondTextBox.Location = new System.Drawing.Point(22, 117);
            this.SecondTextBox.Name = "SecondTextBox";
            this.SecondTextBox.PlaceholderText = "Second Text Box";
            this.SecondTextBox.Size = new System.Drawing.Size(370, 27);
            this.SecondTextBox.TabIndex = 1;
            this.SecondTextBox.Enter += new System.EventHandler(this.SecondTextBox_Enter);
            // 
            // ThirdTextBox
            // 
            this.ThirdTextBox.Location = new System.Drawing.Point(22, 159);
            this.ThirdTextBox.Name = "ThirdTextBox";
            this.ThirdTextBox.PlaceholderText = "Third Text Box";
            this.ThirdTextBox.Size = new System.Drawing.Size(370, 27);
            this.ThirdTextBox.TabIndex = 2;
            this.ThirdTextBox.Enter += new System.EventHandler(this.ThirdTextBox_Enter);
            // 
            // MessageLabel
            // 
            this.MessageLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MessageLabel.Location = new System.Drawing.Point(95, 31);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(237, 30);
            this.MessageLabel.TabIndex = 3;
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstTextBoxFocusButton
            // 
            this.FirstTextBoxFocusButton.Location = new System.Drawing.Point(25, 215);
            this.FirstTextBoxFocusButton.Name = "FirstTextBoxFocusButton";
            this.FirstTextBoxFocusButton.Size = new System.Drawing.Size(94, 29);
            this.FirstTextBoxFocusButton.TabIndex = 4;
            this.FirstTextBoxFocusButton.Text = "1";
            this.FirstTextBoxFocusButton.UseVisualStyleBackColor = true;
            this.FirstTextBoxFocusButton.Click += new System.EventHandler(this.FocusOnTextBox);
            // 
            // SecondTextBoxFocusButton
            // 
            this.SecondTextBoxFocusButton.Location = new System.Drawing.Point(166, 215);
            this.SecondTextBoxFocusButton.Name = "SecondTextBoxFocusButton";
            this.SecondTextBoxFocusButton.Size = new System.Drawing.Size(94, 29);
            this.SecondTextBoxFocusButton.TabIndex = 5;
            this.SecondTextBoxFocusButton.Text = "2";
            this.SecondTextBoxFocusButton.UseVisualStyleBackColor = true;
            this.SecondTextBoxFocusButton.Click += new System.EventHandler(this.FocusOnTextBox);
            // 
            // ThirdTextBoxFocusButton
            // 
            this.ThirdTextBoxFocusButton.Location = new System.Drawing.Point(298, 215);
            this.ThirdTextBoxFocusButton.Name = "ThirdTextBoxFocusButton";
            this.ThirdTextBoxFocusButton.Size = new System.Drawing.Size(94, 29);
            this.ThirdTextBoxFocusButton.TabIndex = 6;
            this.ThirdTextBoxFocusButton.Text = "3";
            this.ThirdTextBoxFocusButton.UseVisualStyleBackColor = true;
            this.ThirdTextBoxFocusButton.Click += new System.EventHandler(this.FocusOnTextBox);
            // 
            // TextBoxFocus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 272);
            this.Controls.Add(this.ThirdTextBoxFocusButton);
            this.Controls.Add(this.SecondTextBoxFocusButton);
            this.Controls.Add(this.FirstTextBoxFocusButton);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ThirdTextBox);
            this.Controls.Add(this.SecondTextBox);
            this.Controls.Add(this.FirstTextBox);
            this.Name = "TextBoxFocus";
            this.Text = "Focusing on TextBoxes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FirstTextBox;
        private TextBox SecondTextBox;
        private TextBox ThirdTextBox;
        private Label MessageLabel;
        private Button FirstTextBoxFocusButton;
        private Button SecondTextBoxFocusButton;
        private Button ThirdTextBoxFocusButton;
    }
}