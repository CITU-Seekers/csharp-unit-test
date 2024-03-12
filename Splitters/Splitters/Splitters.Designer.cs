namespace CodeChum
{
    partial class Splitters
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.topSplitter = new System.Windows.Forms.Splitter();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.bottomSplitter = new System.Windows.Forms.Splitter();
            this.leftSplitter = new System.Windows.Forms.Splitter();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.rightSplitter = new System.Windows.Forms.Splitter();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.topSplitter);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 125);
            this.topPanel.TabIndex = 0;
            // 
            // topSplitter
            // 
            this.topSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.topSplitter.Location = new System.Drawing.Point(0, 0);
            this.topSplitter.Name = "topSplitter";
            this.topSplitter.Size = new System.Drawing.Size(800, 4);
            this.topSplitter.TabIndex = 0;
            this.topSplitter.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.bottomSplitter);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 325);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(800, 125);
            this.bottomPanel.TabIndex = 1;
            // 
            // bottomSplitter
            // 
            this.bottomSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomSplitter.Location = new System.Drawing.Point(0, 121);
            this.bottomSplitter.Name = "bottomSplitter";
            this.bottomSplitter.Size = new System.Drawing.Size(800, 4);
            this.bottomSplitter.TabIndex = 0;
            this.bottomSplitter.TabStop = false;
            // 
            // leftSplitter
            // 
            this.leftSplitter.Location = new System.Drawing.Point(0, 125);
            this.leftSplitter.Name = "leftSplitter";
            this.leftSplitter.Size = new System.Drawing.Size(4, 200);
            this.leftSplitter.TabIndex = 2;
            this.leftSplitter.TabStop = false;
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(4, 125);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(250, 200);
            this.leftPanel.TabIndex = 3;
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftPanel_Paint);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.rightSplitter);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(550, 125);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(250, 200);
            this.rightPanel.TabIndex = 4;
            // 
            // rightSplitter
            // 
            this.rightSplitter.Location = new System.Drawing.Point(0, 0);
            this.rightSplitter.Name = "rightSplitter";
            this.rightSplitter.Size = new System.Drawing.Size(4, 200);
            this.rightSplitter.TabIndex = 0;
            this.rightSplitter.TabStop = false;
            // 
            // centerPanel
            // 
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(254, 125);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(296, 200);
            this.centerPanel.TabIndex = 5;
            // 
            // Splitters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.leftSplitter);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "Splitters";
            this.Text = "Splitters";
            this.topPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel topPanel;
        private Splitter topSplitter;
        private Panel bottomPanel;
        private Splitter bottomSplitter;
        private Splitter leftSplitter;
        private Panel leftPanel;
        private Panel rightPanel;
        private Splitter rightSplitter;
        private Panel centerPanel;
    }
}