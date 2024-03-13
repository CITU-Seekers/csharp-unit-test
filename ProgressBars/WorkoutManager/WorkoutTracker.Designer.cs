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
            workoutComboBox = new ComboBox();
            durationNumericUpDown = new NumericUpDown();
            startButton = new Button();
            finishButton = new Button();
            progressBar = new ProgressBar();
            progressTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)durationNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // workoutComboBox
            // 
            workoutComboBox.FormattingEnabled = true;
            workoutComboBox.Items.AddRange(new object[] { "Jumping jacks", "High knees", "Burpees", "Jump rope", "Squats", "Push-ups" });
            workoutComboBox.Location = new Point(39, 93);
            workoutComboBox.Name = "workoutComboBox";
            workoutComboBox.Size = new Size(121, 23);
            workoutComboBox.TabIndex = 0;
            // 
            // durationNumericUpDown
            // 
            durationNumericUpDown.Location = new Point(229, 93);
            durationNumericUpDown.Name = "durationNumericUpDown";
            durationNumericUpDown.Size = new Size(120, 23);
            durationNumericUpDown.TabIndex = 1;
            // 
            // startButton
            // 
            startButton.Location = new Point(97, 161);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 2;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += btnStart_Click;
            // 
            // finishButton
            // 
            finishButton.Location = new Point(219, 164);
            finishButton.Name = "finishButton";
            finishButton.Size = new Size(75, 23);
            finishButton.TabIndex = 3;
            finishButton.Text = "Finish";
            finishButton.UseVisualStyleBackColor = true;
            finishButton.Click += btnFinish_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(39, 28);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(310, 23);
            progressBar.TabIndex = 4;
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
            Controls.Add(progressBar);
            Controls.Add(finishButton);
            Controls.Add(startButton);
            Controls.Add(durationNumericUpDown);
            Controls.Add(workoutComboBox);
            Name = "WorkoutTracker";
            Text = "WorkoutTracker";
            ((System.ComponentModel.ISupportInitialize)durationNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox workoutComboBox;
        private NumericUpDown durationNumericUpDown;
        private Button startButton;
        private Button finishButton;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer progressTimer;
    }
}