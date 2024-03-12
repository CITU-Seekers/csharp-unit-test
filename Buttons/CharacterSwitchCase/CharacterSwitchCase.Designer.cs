namespace CodeChum
{
    partial class CharacterSwitchCase
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
            this.textLabel = new System.Windows.Forms.Label();
            this.switchCaseVowelsButton = new System.Windows.Forms.Button();
            this.switchCaseConsonantsButton = new System.Windows.Forms.Button();
            this.switchCaseAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLabel.Location = new System.Drawing.Point(54, 35);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(268, 38);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "I love programming!";
            // 
            // switchCaseVowelsButton
            // 
            this.switchCaseVowelsButton.Location = new System.Drawing.Point(100, 97);
            this.switchCaseVowelsButton.Name = "switchCaseVowelsButton";
            this.switchCaseVowelsButton.Size = new System.Drawing.Size(151, 25);
            this.switchCaseVowelsButton.TabIndex = 1;
            this.switchCaseVowelsButton.Text = "Switch Vowels";
            this.switchCaseVowelsButton.UseVisualStyleBackColor = true;
            this.switchCaseVowelsButton.Click += new System.EventHandler(this.SwitchCaseVowelsButton_Click);
            // 
            // switchCaseConsonantsButton
            // 
            this.switchCaseConsonantsButton.Location = new System.Drawing.Point(100, 147);
            this.switchCaseConsonantsButton.Name = "switchCaseConsonantsButton";
            this.switchCaseConsonantsButton.Size = new System.Drawing.Size(151, 25);
            this.switchCaseConsonantsButton.TabIndex = 2;
            this.switchCaseConsonantsButton.Text = "Switch Consonants";
            this.switchCaseConsonantsButton.UseVisualStyleBackColor = true;
            this.switchCaseConsonantsButton.Click += new System.EventHandler(this.SwitchCaseConsonantsButton_Click);
            // 
            // switchCaseAllButton
            // 
            this.switchCaseAllButton.Location = new System.Drawing.Point(100, 197);
            this.switchCaseAllButton.Name = "switchCaseAllButton";
            this.switchCaseAllButton.Size = new System.Drawing.Size(151, 25);
            this.switchCaseAllButton.TabIndex = 3;
            this.switchCaseAllButton.Text = "Switch All";
            this.switchCaseAllButton.UseVisualStyleBackColor = true;
            this.switchCaseAllButton.Click += new System.EventHandler(this.SwitchCaseAllButton_Click);
            // 
            // CharacterSwitchCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 253);
            this.Controls.Add(this.switchCaseAllButton);
            this.Controls.Add(this.switchCaseConsonantsButton);
            this.Controls.Add(this.switchCaseVowelsButton);
            this.Controls.Add(this.textLabel);
            this.Name = "CharacterSwitchCase";
            this.Text = "Case Switch ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label textLabel;
        private Button switchCaseVowelsButton;
        private Button switchCaseConsonantsButton;
        private Button switchCaseAllButton;
    }
}