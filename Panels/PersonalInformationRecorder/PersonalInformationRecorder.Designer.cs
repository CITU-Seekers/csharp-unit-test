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
            this.firstPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.secondPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.quoteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.thirdPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quoteDisplayRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.firstPanel.SuspendLayout();
            this.secondPanel.SuspendLayout();
            this.thirdPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstPanel
            // 
            this.firstPanel.Controls.Add(this.label2);
            this.firstPanel.Controls.Add(this.label1);
            this.firstPanel.Controls.Add(this.ageTextBox);
            this.firstPanel.Controls.Add(this.nameTextBox);
            this.firstPanel.Location = new System.Drawing.Point(103, 21);
            this.firstPanel.Name = "firstPanel";
            this.firstPanel.Size = new System.Drawing.Size(222, 157);
            this.firstPanel.TabIndex = 0;
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
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(20, 101);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(178, 27);
            this.ageTextBox.TabIndex = 1;
            this.ageTextBox.TextChanged += new System.EventHandler(this.AgeTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(19, 36);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(178, 27);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // secondPanel
            // 
            this.secondPanel.Controls.Add(this.label3);
            this.secondPanel.Controls.Add(this.quoteRichTextBox);
            this.secondPanel.Location = new System.Drawing.Point(100, 18);
            this.secondPanel.Name = "secondPanel";
            this.secondPanel.Size = new System.Drawing.Size(222, 157);
            this.secondPanel.TabIndex = 1;
            this.secondPanel.Visible = false;
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
            // quoteRichTextBox
            // 
            this.quoteRichTextBox.Location = new System.Drawing.Point(19, 36);
            this.quoteRichTextBox.Name = "quoteRichTextBox";
            this.quoteRichTextBox.Size = new System.Drawing.Size(183, 110);
            this.quoteRichTextBox.TabIndex = 0;
            this.quoteRichTextBox.Text = "";
            this.quoteRichTextBox.TextChanged += new System.EventHandler(this.QuoteRichTextBox_TextChanged);
            // 
            // thirdPanel
            // 
            this.thirdPanel.Controls.Add(this.label5);
            this.thirdPanel.Controls.Add(this.label4);
            this.thirdPanel.Controls.Add(this.quoteDisplayRichTextBox);
            this.thirdPanel.Controls.Add(this.ageLabel);
            this.thirdPanel.Controls.Add(this.nameLabel);
            this.thirdPanel.Location = new System.Drawing.Point(91, 18);
            this.thirdPanel.Name = "thirdPanel";
            this.thirdPanel.Size = new System.Drawing.Size(234, 196);
            this.thirdPanel.TabIndex = 2;
            this.thirdPanel.Visible = false;
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
            // quoteDisplayRichTextBox
            // 
            this.quoteDisplayRichTextBox.Location = new System.Drawing.Point(20, 111);
            this.quoteDisplayRichTextBox.Name = "quoteDisplayRichTextBox";
            this.quoteDisplayRichTextBox.ReadOnly = true;
            this.quoteDisplayRichTextBox.Size = new System.Drawing.Size(183, 69);
            this.quoteDisplayRichTextBox.TabIndex = 1;
            this.quoteDisplayRichTextBox.Text = "";
            // 
            // ageLabel
            // 
            this.ageLabel.Location = new System.Drawing.Point(66, 66);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(145, 25);
            this.ageLabel.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(75, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(145, 25);
            this.nameLabel.TabIndex = 0;
            // 
            // prevButton
            // 
            this.prevButton.Enabled = false;
            this.prevButton.Location = new System.Drawing.Point(103, 235);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(84, 25);
            this.prevButton.TabIndex = 3;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(238, 235);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(84, 25);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MultipagePersonalInformationRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 289);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.thirdPanel);
            this.Controls.Add(this.secondPanel);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.firstPanel);
            this.Name = "MultipagePersonalInformationRecorder";
            this.Text = "Personal Information Recorder";
            this.firstPanel.ResumeLayout(false);
            this.firstPanel.PerformLayout();
            this.secondPanel.ResumeLayout(false);
            this.secondPanel.PerformLayout();
            this.thirdPanel.ResumeLayout(false);
            this.thirdPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel firstPanel;
        private TextBox ageTextBox;
        private TextBox nameTextBox;
        private Panel secondPanel;
        private RichTextBox quoteRichTextBox;
        private Panel thirdPanel;
        private RichTextBox quoteDisplayRichTextBox;
        private Label ageLabel;
        private Label nameLabel;
        private Button prevButton;
        private Button nextButton;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label4;
    }
}