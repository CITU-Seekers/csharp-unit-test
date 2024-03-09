namespace CodeChum
{
    partial class SimpleQuestionnaire
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
            this.CheckButton = new System.Windows.Forms.Button();
            this.CharRadioButton = new System.Windows.Forms.RadioButton();
            this.IntRadioButton = new System.Windows.Forms.RadioButton();
            this.BooleanRadioButton = new System.Windows.Forms.RadioButton();
            this.StringRadioButton = new System.Windows.Forms.RadioButton();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(166, 193);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(84, 25);
            this.CheckButton.TabIndex = 0;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // CharRadioButton
            // 
            this.CharRadioButton.AutoSize = true;
            this.CharRadioButton.Checked = true;
            this.CharRadioButton.Location = new System.Drawing.Point(91, 62);
            this.CharRadioButton.Name = "CharRadioButton";
            this.CharRadioButton.Size = new System.Drawing.Size(93, 24);
            this.CharRadioButton.TabIndex = 1;
            this.CharRadioButton.TabStop = true;
            this.CharRadioButton.Text = "Character";
            this.CharRadioButton.UseVisualStyleBackColor = true;
            // 
            // IntRadioButton
            // 
            this.IntRadioButton.AutoSize = true;
            this.IntRadioButton.Location = new System.Drawing.Point(91, 92);
            this.IntRadioButton.Name = "IntRadioButton";
            this.IntRadioButton.Size = new System.Drawing.Size(77, 24);
            this.IntRadioButton.TabIndex = 2;
            this.IntRadioButton.Text = "Integer";
            this.IntRadioButton.UseVisualStyleBackColor = true;
            // 
            // BooleanRadioButton
            // 
            this.BooleanRadioButton.AutoSize = true;
            this.BooleanRadioButton.Location = new System.Drawing.Point(91, 122);
            this.BooleanRadioButton.Name = "BooleanRadioButton";
            this.BooleanRadioButton.Size = new System.Drawing.Size(85, 24);
            this.BooleanRadioButton.TabIndex = 3;
            this.BooleanRadioButton.Text = "Boolean";
            this.BooleanRadioButton.UseVisualStyleBackColor = true;
            // 
            // StringRadioButton
            // 
            this.StringRadioButton.AutoSize = true;
            this.StringRadioButton.Location = new System.Drawing.Point(91, 152);
            this.StringRadioButton.Name = "StringRadioButton";
            this.StringRadioButton.Size = new System.Drawing.Size(69, 24);
            this.StringRadioButton.TabIndex = 4;
            this.StringRadioButton.Text = "String";
            this.StringRadioButton.UseVisualStyleBackColor = true;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(180, 233);
            this.ResultLabel.MinimumSize = new System.Drawing.Size(60, 20);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(60, 20);
            this.ResultLabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Q:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(75, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Which one is not a primitive datatype?";
            // 
            // SimpleQuestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 271);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.StringRadioButton);
            this.Controls.Add(this.BooleanRadioButton);
            this.Controls.Add(this.IntRadioButton);
            this.Controls.Add(this.CharRadioButton);
            this.Controls.Add(this.CheckButton);
            this.Name = "SimpleQuestionnaire";
            this.Text = "Simple Questionnaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CheckButton;
        private RadioButton CharRadioButton;
        private RadioButton IntRadioButton;
        private RadioButton BooleanRadioButton;
        private RadioButton StringRadioButton;
        private Label ResultLabel;
        private Label label1;
        private Label label2;
    }
}