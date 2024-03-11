namespace CodeChum
{
    partial class PersonalInformationRecorder
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
            this.FirstPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SecondPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.QuoteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ThirdPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.QuoteDisplayRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.FirstPanel.SuspendLayout();
            this.SecondPanel.SuspendLayout();
            this.ThirdPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstPanel
            // 
            this.FirstPanel.Controls.Add(this.label2);
            this.FirstPanel.Controls.Add(this.label1);
            this.FirstPanel.Controls.Add(this.AgeTextBox);
            this.FirstPanel.Controls.Add(this.NameTextBox);
            this.FirstPanel.Location = new System.Drawing.Point(103, 21);
            this.FirstPanel.Name = "FirstPanel";
            this.FirstPanel.Size = new System.Drawing.Size(222, 157);
            this.FirstPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(20, 101);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(178, 27);
            this.AgeTextBox.TabIndex = 1;
            this.AgeTextBox.TextChanged += new System.EventHandler(this.AgeTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(19, 36);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(178, 27);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // SecondPanel
            // 
            this.SecondPanel.Controls.Add(this.label3);
            this.SecondPanel.Controls.Add(this.QuoteRichTextBox);
            this.SecondPanel.Location = new System.Drawing.Point(100, 18);
            this.SecondPanel.Name = "SecondPanel";
            this.SecondPanel.Size = new System.Drawing.Size(222, 157);
            this.SecondPanel.TabIndex = 1;
            this.SecondPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quote";
            // 
            // QuoteRichTextBox
            // 
            this.QuoteRichTextBox.Location = new System.Drawing.Point(19, 36);
            this.QuoteRichTextBox.Name = "QuoteRichTextBox";
            this.QuoteRichTextBox.Size = new System.Drawing.Size(183, 110);
            this.QuoteRichTextBox.TabIndex = 0;
            this.QuoteRichTextBox.Text = "";
            this.QuoteRichTextBox.TextChanged += new System.EventHandler(this.QuoteRichTextBox_TextChanged);
            // 
            // ThirdPanel
            // 
            this.ThirdPanel.Controls.Add(this.label5);
            this.ThirdPanel.Controls.Add(this.label4);
            this.ThirdPanel.Controls.Add(this.QuoteDisplayRichTextBox);
            this.ThirdPanel.Controls.Add(this.AgeLabel);
            this.ThirdPanel.Controls.Add(this.NameLabel);
            this.ThirdPanel.Location = new System.Drawing.Point(91, 18);
            this.ThirdPanel.Name = "ThirdPanel";
            this.ThirdPanel.Size = new System.Drawing.Size(234, 196);
            this.ThirdPanel.TabIndex = 2;
            this.ThirdPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name:";
            // 
            // QuoteDisplayRichTextBox
            // 
            this.QuoteDisplayRichTextBox.Location = new System.Drawing.Point(20, 111);
            this.QuoteDisplayRichTextBox.Name = "QuoteDisplayRichTextBox";
            this.QuoteDisplayRichTextBox.ReadOnly = true;
            this.QuoteDisplayRichTextBox.Size = new System.Drawing.Size(183, 69);
            this.QuoteDisplayRichTextBox.TabIndex = 1;
            this.QuoteDisplayRichTextBox.Text = "";
            // 
            // AgeLabel
            // 
            this.AgeLabel.Location = new System.Drawing.Point(66, 66);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(145, 25);
            this.AgeLabel.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(75, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(145, 25);
            this.NameLabel.TabIndex = 0;
            // 
            // PrevButton
            // 
            this.PrevButton.Enabled = false;
            this.PrevButton.Location = new System.Drawing.Point(103, 235);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(84, 25);
            this.PrevButton.TabIndex = 3;
            this.PrevButton.Text = "Previous";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(238, 235);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(84, 25);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MultipagePersonalInformationRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 289);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ThirdPanel);
            this.Controls.Add(this.SecondPanel);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.FirstPanel);
            this.Name = "MultipagePersonalInformationRecorder";
            this.Text = "Personal Information Recorder";
            this.FirstPanel.ResumeLayout(false);
            this.FirstPanel.PerformLayout();
            this.SecondPanel.ResumeLayout(false);
            this.SecondPanel.PerformLayout();
            this.ThirdPanel.ResumeLayout(false);
            this.ThirdPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel FirstPanel;
        private TextBox AgeTextBox;
        private TextBox NameTextBox;
        private Panel SecondPanel;
        private RichTextBox QuoteRichTextBox;
        private Panel ThirdPanel;
        private RichTextBox QuoteDisplayRichTextBox;
        private Label AgeLabel;
        private Label NameLabel;
        private Button PrevButton;
        private Button NextButton;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label4;
    }
}