namespace CodeChum
{
    partial class FileExplorer
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
            TreeNode treeNode1 = new TreeNode("Sample");
            TreeNode treeNode2 = new TreeNode("Landscape");
            TreeNode treeNode3 = new TreeNode("Pictures", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Valorant - Haven Ace");
            TreeNode treeNode5 = new TreeNode("Videos", new TreeNode[] { treeNode4 });
            TreeNode treeNode6 = new TreeNode("CS123 - Assignment");
            TreeNode treeNode7 = new TreeNode("Documents", new TreeNode[] { treeNode6 });
            TreeNode treeNode8 = new TreeNode("C:", new TreeNode[] { treeNode3, treeNode5, treeNode7 });
            TreeNode treeNode9 = new TreeNode("Valhalla");
            TreeNode treeNode10 = new TreeNode("GTA6");
            TreeNode treeNode11 = new TreeNode("Games", new TreeNode[] { treeNode9, treeNode10 });
            TreeNode treeNode12 = new TreeNode("Project1");
            TreeNode treeNode13 = new TreeNode("Work", new TreeNode[] { treeNode12 });
            TreeNode treeNode14 = new TreeNode("D:", new TreeNode[] { treeNode11, treeNode13 });
            MainTreeView = new System.Windows.Forms.TreeView();
            MainMenuStrip = new MenuStrip();
            FileToolStrip = new ToolStripMenuItem();
            NewMenuItem = new ToolStripMenuItem();
            OpenMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            txtFileName = new TextBox();
            SearchButton = new Button();
            MessageLabel = new Label();
            FilePathLabel = new Label();
            RenameButton = new Button();
            MainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainTreeView
            // 
            MainTreeView.Location = new Point(23, 29);
            MainTreeView.Name = "MainTreeView";
            treeNode1.Name = "SamplePic";
            treeNode1.Text = "Sample";
            treeNode2.Name = "LandscapePic";
            treeNode2.Text = "Landscape";
            treeNode3.Name = "PicturesFolder";
            treeNode3.Text = "Pictures";
            treeNode4.Name = "ValorantVid";
            treeNode4.Text = "Valorant - Haven Ace";
            treeNode5.Name = "VideosFolder";
            treeNode5.Text = "Videos";
            treeNode6.Name = "CS123Doc";
            treeNode6.Text = "CS123 - Assignment";
            treeNode7.Name = "DocumentsFolder";
            treeNode7.Text = "Documents";
            treeNode8.Name = "CDrive";
            treeNode8.Text = "C:";
            treeNode9.Name = "ValhallaGame";
            treeNode9.Text = "Valhalla";
            treeNode10.Name = "GTA6Game";
            treeNode10.Text = "GTA6";
            treeNode11.Name = "GamesFolder";
            treeNode11.Text = "Games";
            treeNode12.Name = "Project1Work";
            treeNode12.Text = "Project1";
            treeNode13.Name = "WorkFolder";
            treeNode13.Text = "Work";
            treeNode14.Name = "DDrive";
            treeNode14.Text = "D:";
            MainTreeView.Nodes.AddRange(new TreeNode[] { treeNode8, treeNode14 });
            MainTreeView.Size = new Size(242, 210);
            MainTreeView.TabIndex = 0;
            MainTreeView.AfterSelect += MainTreeView_AfterSelect;
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { FileToolStrip });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(538, 24);
            MainMenuStrip.TabIndex = 1;
            MainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStrip
            // 
            FileToolStrip.DropDownItems.AddRange(new ToolStripItem[] { NewMenuItem, OpenMenuItem, ExitMenuItem });
            FileToolStrip.Name = "FileToolStrip";
            FileToolStrip.Size = new Size(37, 20);
            FileToolStrip.Text = "File";
            // 
            // NewMenuItem
            // 
            NewMenuItem.Name = "NewMenuItem";
            NewMenuItem.Size = new Size(103, 22);
            NewMenuItem.Text = "New";
            NewMenuItem.Click += NewMenuItem_Click;
            // 
            // OpenMenuItem
            // 
            OpenMenuItem.Name = "OpenMenuItem";
            OpenMenuItem.Size = new Size(103, 22);
            OpenMenuItem.Text = "Open";
            OpenMenuItem.Click += OpenMenuItem_Click;
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(103, 22);
            ExitMenuItem.Text = "Exit";
            ExitMenuItem.Click += ExitMenuItem_Click;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(316, 100);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(182, 23);
            txtFileName.TabIndex = 2;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(423, 142);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 3;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // MessageLabel
            // 
            MessageLabel.AutoSize = true;
            MessageLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MessageLabel.ForeColor = SystemColors.Highlight;
            MessageLabel.Location = new Point(315, 51);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(0, 20);
            MessageLabel.TabIndex = 4;
            // 
            // FilePathLabel
            // 
            FilePathLabel.AutoSize = true;
            FilePathLabel.Location = new Point(315, 215);
            FilePathLabel.Name = "FilePathLabel";
            FilePathLabel.Size = new Size(0, 15);
            FilePathLabel.TabIndex = 5;
            // 
            // RenameButton
            // 
            RenameButton.Location = new Point(315, 142);
            RenameButton.Name = "RenameButton";
            RenameButton.Size = new Size(75, 23);
            RenameButton.TabIndex = 6;
            RenameButton.Text = "Rename";
            RenameButton.UseVisualStyleBackColor = true;
            RenameButton.Click += RenameButton_Click;
            // 
            // FileExplorer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 265);
            Controls.Add(RenameButton);
            Controls.Add(FilePathLabel);
            Controls.Add(MessageLabel);
            Controls.Add(SearchButton);
            Controls.Add(txtFileName);
            Controls.Add(MainTreeView);
            Controls.Add(MainMenuStrip);
            Name = "FileExplorer";
            Text = "FileExplorer";
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TreeView MainTreeView;
        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem FileToolStrip;
        private ToolStripMenuItem NewMenuItem;
        private ToolStripMenuItem OpenMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private TextBox txtFileName;
        private Button SearchButton;
        private Label MessageLabel;
        private Label FilePathLabel;
        private Button RenameButton;
    }
}