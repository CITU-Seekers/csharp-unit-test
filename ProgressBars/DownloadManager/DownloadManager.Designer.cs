namespace CodeChum
{
    partial class DownloadManager
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
            groupBox1 = new GroupBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            btnDownload = new Button();
            btnCancel = new Button();
            progressBar = new ProgressBar();
            ProgressTimer = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(91, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(230, 239);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Files Manager";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox5.Location = new Point(51, 159);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(73, 24);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Videos";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.Location = new Point(51, 129);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(60, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "PDFs";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(51, 99);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(95, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Excel Files";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(51, 69);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(143, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Word Documents";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(51, 39);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(73, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Games";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(91, 311);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(75, 23);
            btnDownload.TabIndex = 1;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(246, 311);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(-1, 1);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(432, 23);
            progressBar.TabIndex = 3;
            // 
            // ProgressTimer
            // 
            ProgressTimer.Tick += ProgressTimer_Tick;
            // 
            // DownloadManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 369);
            Controls.Add(progressBar);
            Controls.Add(btnCancel);
            Controls.Add(btnDownload);
            Controls.Add(groupBox1);
            Name = "DownloadManager";
            Text = "DownloadManager";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button btnDownload;
        private Button btnCancel;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer ProgressTimer;
    }
}