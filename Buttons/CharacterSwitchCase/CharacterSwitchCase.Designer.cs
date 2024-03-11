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
            this.Label = new System.Windows.Forms.Label();
            this.SwitchCaseVowelsButton = new System.Windows.Forms.Button();
            this.SwitchCaseConsonantsButton = new System.Windows.Forms.Button();
            this.SwitchCaseAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label.Location = new System.Drawing.Point(54, 35);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(268, 38);
            this.Label.TabIndex = 0;
            this.Label.Text = "I love programming!";
            // 
            // SwitchCaseVowelsButton
            // 
            this.SwitchCaseVowelsButton.Location = new System.Drawing.Point(100, 97);
            this.SwitchCaseVowelsButton.Name = "SwitchCaseVowelsButton";
            this.SwitchCaseVowelsButton.Size = new System.Drawing.Size(151, 25);
            this.SwitchCaseVowelsButton.TabIndex = 1;
            this.SwitchCaseVowelsButton.Text = "Switch Vowels";
            this.SwitchCaseVowelsButton.UseVisualStyleBackColor = true;
            this.SwitchCaseVowelsButton.Click += new System.EventHandler(this.SwitchCaseVowelsButton_Click);
            // 
            // SwitchCaseConsonantsButton
            // 
            this.SwitchCaseConsonantsButton.Location = new System.Drawing.Point(100, 147);
            this.SwitchCaseConsonantsButton.Name = "SwitchCaseConsonantsButton";
            this.SwitchCaseConsonantsButton.Size = new System.Drawing.Size(151, 25);
            this.SwitchCaseConsonantsButton.TabIndex = 2;
            this.SwitchCaseConsonantsButton.Text = "Switch Consonants";
            this.SwitchCaseConsonantsButton.UseVisualStyleBackColor = true;
            this.SwitchCaseConsonantsButton.Click += new System.EventHandler(this.SwitchCaseConsonantsButton_Click);
            // 
            // SwitchCaseAllButton
            // 
            this.SwitchCaseAllButton.Location = new System.Drawing.Point(100, 197);
            this.SwitchCaseAllButton.Name = "SwitchCaseAllButton";
            this.SwitchCaseAllButton.Size = new System.Drawing.Size(151, 25);
            this.SwitchCaseAllButton.TabIndex = 3;
            this.SwitchCaseAllButton.Text = "Switch All";
            this.SwitchCaseAllButton.UseVisualStyleBackColor = true;
            this.SwitchCaseAllButton.Click += new System.EventHandler(this.SwitchCaseAllButton_Click);
            // 
            // CharacterSwitchCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 253);
            this.Controls.Add(this.SwitchCaseAllButton);
            this.Controls.Add(this.SwitchCaseConsonantsButton);
            this.Controls.Add(this.SwitchCaseVowelsButton);
            this.Controls.Add(this.Label);
            this.Name = "CharacterSwitchCase";
            this.Text = "Case Switch ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Label;
        private Button SwitchCaseVowelsButton;
        private Button SwitchCaseConsonantsButton;
        private Button SwitchCaseAllButton;
    }
}