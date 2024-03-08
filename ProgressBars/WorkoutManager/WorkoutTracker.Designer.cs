namespace CodeChum
{
    partial class WorkoutTracker
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
            components = new System.ComponentModel.Container();
            comboBox1 = new System.Windows.Forms.ComboBox();
            numericUpDown1 = new NumericUpDown();
            btnStart = new Button();
            btnFinish = new Button();
            progressBar1 = new ProgressBar();
            progressTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Jumping jacks", "High knees", "Burpees", "Jump rope", "Squats", "Push-ups" });
            comboBox1.Location = new Point(39, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(229, 93);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(97, 161);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnFinish
            // 
            btnFinish.Location = new Point(219, 164);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(75, 23);
            btnFinish.TabIndex = 3;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += btnFinish_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(39, 28);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(310, 23);
            progressBar1.TabIndex = 4;
            // 
            // progressTimer
            // 
            progressTimer.Interval = 1000;
            progressTimer.Tick += progressTimer_Tick;
            // 
            // WorkoutTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 262);
            Controls.Add(progressBar1);
            Controls.Add(btnFinish);
            Controls.Add(btnStart);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Name = "WorkoutTracker";
            Text = "WorkoutTracker";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Button btnStart;
        private Button btnFinish;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer progressTimer;
    }
}