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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopSplitter = new System.Windows.Forms.Splitter();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.BottomSplitter = new System.Windows.Forms.Splitter();
            this.LeftSplitter = new System.Windows.Forms.Splitter();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.RightSplitter = new System.Windows.Forms.Splitter();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.TopSplitter);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 125);
            this.TopPanel.TabIndex = 0;
            // 
            // TopSplitter
            // 
            this.TopSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopSplitter.Location = new System.Drawing.Point(0, 0);
            this.TopSplitter.Name = "TopSplitter";
            this.TopSplitter.Size = new System.Drawing.Size(800, 4);
            this.TopSplitter.TabIndex = 0;
            this.TopSplitter.TabStop = false;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.BottomSplitter);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 325);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(800, 125);
            this.BottomPanel.TabIndex = 1;
            // 
            // BottomSplitter
            // 
            this.BottomSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomSplitter.Location = new System.Drawing.Point(0, 121);
            this.BottomSplitter.Name = "BottomSplitter";
            this.BottomSplitter.Size = new System.Drawing.Size(800, 4);
            this.BottomSplitter.TabIndex = 0;
            this.BottomSplitter.TabStop = false;
            // 
            // LeftSplitter
            // 
            this.LeftSplitter.Location = new System.Drawing.Point(0, 125);
            this.LeftSplitter.Name = "LeftSplitter";
            this.LeftSplitter.Size = new System.Drawing.Size(4, 200);
            this.LeftSplitter.TabIndex = 2;
            this.LeftSplitter.TabStop = false;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(4, 125);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(250, 200);
            this.LeftPanel.TabIndex = 3;
            this.LeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftPanel_Paint);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.RightSplitter);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(550, 125);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(250, 200);
            this.RightPanel.TabIndex = 4;
            // 
            // RightSplitter
            // 
            this.RightSplitter.Location = new System.Drawing.Point(0, 0);
            this.RightSplitter.Name = "RightSplitter";
            this.RightSplitter.Size = new System.Drawing.Size(4, 200);
            this.RightSplitter.TabIndex = 0;
            this.RightSplitter.TabStop = false;
            // 
            // CenterPanel
            // 
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(254, 125);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(296, 200);
            this.CenterPanel.TabIndex = 5;
            // 
            // Splitters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.LeftSplitter);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "Splitters";
            this.Text = "Splitters";
            this.TopPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel TopPanel;
        private Splitter TopSplitter;
        private Panel BottomPanel;
        private Splitter BottomSplitter;
        private Splitter LeftSplitter;
        private Panel LeftPanel;
        private Panel RightPanel;
        private Splitter RightSplitter;
        private Panel CenterPanel;
    }
}