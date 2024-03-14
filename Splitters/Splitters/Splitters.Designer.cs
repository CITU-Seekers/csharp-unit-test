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
            topPanel = new Panel();
            topSplitter = new Splitter();
            bottomPanel = new Panel();
            bottomSplitter = new Splitter();
            leftSplitter = new Splitter();
            leftPanel = new Panel();
            rightPanel = new Panel();
            rightSplitter = new Splitter();
            centerPanel = new Panel();
            topPanel.SuspendLayout();
            bottomPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.Controls.Add(topSplitter);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(2, 2, 2, 2);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(622, 82);
            topPanel.TabIndex = 0;
            // 
            // topSplitter
            // 
            topSplitter.Dock = DockStyle.Top;
            topSplitter.Location = new Point(0, 0);
            topSplitter.Margin = new Padding(2, 2, 2, 2);
            topSplitter.Name = "topSplitter";
            topSplitter.Size = new Size(622, 3);
            topSplitter.TabIndex = 0;
            topSplitter.TabStop = false;
            // 
            // bottomPanel
            // 
            bottomPanel.Controls.Add(bottomSplitter);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 293);
            bottomPanel.Margin = new Padding(2, 2, 2, 2);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(622, 82);
            bottomPanel.TabIndex = 1;
            // 
            // bottomSplitter
            // 
            bottomSplitter.Dock = DockStyle.Bottom;
            bottomSplitter.Location = new Point(0, 79);
            bottomSplitter.Margin = new Padding(2, 2, 2, 2);
            bottomSplitter.Name = "bottomSplitter";
            bottomSplitter.Size = new Size(622, 3);
            bottomSplitter.TabIndex = 0;
            bottomSplitter.TabStop = false;
            // 
            // leftSplitter
            // 
            leftSplitter.Location = new Point(0, 82);
            leftSplitter.Margin = new Padding(2, 2, 2, 2);
            leftSplitter.Name = "leftSplitter";
            leftSplitter.Size = new Size(3, 211);
            leftSplitter.TabIndex = 2;
            leftSplitter.TabStop = false;
            // 
            // leftPanel
            // 
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(3, 82);
            leftPanel.Margin = new Padding(2, 2, 2, 2);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(194, 211);
            leftPanel.TabIndex = 3;
            leftPanel.Paint += LeftPanel_Paint;
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(rightSplitter);
            rightPanel.Dock = DockStyle.Right;
            rightPanel.Location = new Point(428, 82);
            rightPanel.Margin = new Padding(2, 2, 2, 2);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(194, 211);
            rightPanel.TabIndex = 4;
            // 
            // rightSplitter
            // 
            rightSplitter.Location = new Point(0, 0);
            rightSplitter.Margin = new Padding(2, 2, 2, 2);
            rightSplitter.Name = "rightSplitter";
            rightSplitter.Size = new Size(3, 211);
            rightSplitter.TabIndex = 0;
            rightSplitter.TabStop = false;
            rightSplitter.Dock = DockStyle.Right;
            // 
            // centerPanel
            // 
            centerPanel.Dock = DockStyle.Fill;
            centerPanel.Location = new Point(197, 82);
            centerPanel.Margin = new Padding(2, 2, 2, 2);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(231, 211);
            centerPanel.TabIndex = 5;
            // 
            // Splitters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 375);
            Controls.Add(centerPanel);
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            Controls.Add(leftSplitter);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Splitters";
            Text = "Splitters";
            topPanel.ResumeLayout(false);
            bottomPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            ResumeLayout(false);
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