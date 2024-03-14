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
            this.checkButton = new System.Windows.Forms.Button();
            this.charRadioButton = new System.Windows.Forms.RadioButton();
            this.intRadioButton = new System.Windows.Forms.RadioButton();
            this.booleanRadioButton = new System.Windows.Forms.RadioButton();
            this.stringRadioButton = new System.Windows.Forms.RadioButton();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(166, 193);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(84, 25);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // charRadioButton
            // 
            this.charRadioButton.AutoSize = true;
            this.charRadioButton.Checked = true;
            this.charRadioButton.Location = new System.Drawing.Point(91, 62);
            this.charRadioButton.Name = "charRadioButton";
            this.charRadioButton.Size = new System.Drawing.Size(93, 24);
            this.charRadioButton.TabIndex = 1;
            this.charRadioButton.TabStop = true;
            this.charRadioButton.Text = "Character";
            this.charRadioButton.UseVisualStyleBackColor = true;
            // 
            // intRadioButton
            // 
            this.intRadioButton.AutoSize = true;
            this.intRadioButton.Location = new System.Drawing.Point(91, 92);
            this.intRadioButton.Name = "intRadioButton";
            this.intRadioButton.Size = new System.Drawing.Size(77, 24);
            this.intRadioButton.TabIndex = 2;
            this.intRadioButton.Text = "Integer";
            this.intRadioButton.UseVisualStyleBackColor = true;
            // 
            // booleanRadioButton
            // 
            this.booleanRadioButton.AutoSize = true;
            this.booleanRadioButton.Location = new System.Drawing.Point(91, 122);
            this.booleanRadioButton.Name = "booleanRadioButton";
            this.booleanRadioButton.Size = new System.Drawing.Size(85, 24);
            this.booleanRadioButton.TabIndex = 3;
            this.booleanRadioButton.Text = "Boolean";
            this.booleanRadioButton.UseVisualStyleBackColor = true;
            // 
            // stringRadioButton
            // 
            this.stringRadioButton.AutoSize = true;
            this.stringRadioButton.Location = new System.Drawing.Point(91, 152);
            this.stringRadioButton.Name = "stringRadioButton";
            this.stringRadioButton.Size = new System.Drawing.Size(69, 24);
            this.stringRadioButton.TabIndex = 4;
            this.stringRadioButton.Text = "String";
            this.stringRadioButton.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(180, 233);
            this.resultLabel.MinimumSize = new System.Drawing.Size(60, 20);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(60, 20);
            this.resultLabel.TabIndex = 5;
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
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.stringRadioButton);
            this.Controls.Add(this.booleanRadioButton);
            this.Controls.Add(this.intRadioButton);
            this.Controls.Add(this.charRadioButton);
            this.Controls.Add(this.checkButton);
            this.Name = "SimpleQuestionnaire";
            this.Text = "Simple Questionnaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button checkButton;
        private RadioButton charRadioButton;
        private RadioButton intRadioButton;
        private RadioButton booleanRadioButton;
        private RadioButton stringRadioButton;
        private Label resultLabel;
        private Label label1;
        private Label label2;
    }
}