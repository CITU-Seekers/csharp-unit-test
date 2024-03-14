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
            TreeNode treeNode15 = new TreeNode("Sample");
            TreeNode treeNode16 = new TreeNode("Landscape");
            TreeNode treeNode17 = new TreeNode("Pictures", new TreeNode[] { treeNode15, treeNode16 });
            TreeNode treeNode18 = new TreeNode("Valorant - Haven Ace");
            TreeNode treeNode19 = new TreeNode("Videos", new TreeNode[] { treeNode18 });
            TreeNode treeNode20 = new TreeNode("CS123 - Assignment");
            TreeNode treeNode21 = new TreeNode("Documents", new TreeNode[] { treeNode20 });
            TreeNode treeNode22 = new TreeNode("C:", new TreeNode[] { treeNode17, treeNode19, treeNode21 });
            TreeNode treeNode23 = new TreeNode("Valhalla");
            TreeNode treeNode24 = new TreeNode("GTA6");
            TreeNode treeNode25 = new TreeNode("Games", new TreeNode[] { treeNode23, treeNode24 });
            TreeNode treeNode26 = new TreeNode("Project1");
            TreeNode treeNode27 = new TreeNode("Work", new TreeNode[] { treeNode26 });
            TreeNode treeNode28 = new TreeNode("D:", new TreeNode[] { treeNode25, treeNode27 });
            mainTreeView = new TreeView();
            mainMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            fileNameTextBox = new TextBox();
            searchButton = new Button();
            messageLabel = new Label();
            filePathLabel = new Label();
            renameButton = new Button();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainTreeView
            // 
            mainTreeView.Location = new Point(23, 29);
            mainTreeView.Name = "mainTreeView";
            treeNode15.Name = "SamplePic";
            treeNode15.Text = "Sample";
            treeNode16.Name = "LandscapePic";
            treeNode16.Text = "Landscape";
            treeNode17.Name = "PicturesFolder";
            treeNode17.Text = "Pictures";
            treeNode18.Name = "ValorantVid";
            treeNode18.Text = "Valorant - Haven Ace";
            treeNode19.Name = "VideosFolder";
            treeNode19.Text = "Videos";
            treeNode20.Name = "CS123Doc";
            treeNode20.Text = "CS123 - Assignment";
            treeNode21.Name = "DocumentsFolder";
            treeNode21.Text = "Documents";
            treeNode22.Name = "CDrive";
            treeNode22.Text = "C:";
            treeNode23.Name = "ValhallaGame";
            treeNode23.Text = "Valhalla";
            treeNode24.Name = "GTA6Game";
            treeNode24.Text = "GTA6";
            treeNode25.Name = "GamesFolder";
            treeNode25.Text = "Games";
            treeNode26.Name = "Project1Work";
            treeNode26.Text = "Project1";
            treeNode27.Name = "WorkFolder";
            treeNode27.Text = "Work";
            treeNode28.Name = "DDrive";
            treeNode28.Text = "D:";
            mainTreeView.Nodes.AddRange(new TreeNode[] { treeNode22, treeNode28 });
            mainTreeView.Size = new Size(242, 210);
            mainTreeView.TabIndex = 0;
            mainTreeView.AfterSelect += MainTreeView_AfterSelect;
            // 
            // MainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(538, 24);
            mainMenuStrip.TabIndex = 1;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += NewMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += OpenMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitMenuItem_Click;
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.Location = new Point(316, 100);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.Size = new Size(182, 23);
            fileNameTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(423, 142);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 3;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += SearchButton_Click;
            // 
            // MessageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            messageLabel.ForeColor = SystemColors.Highlight;
            messageLabel.Location = new Point(315, 51);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(0, 20);
            messageLabel.TabIndex = 4;
            // 
            // FilePathLabel
            // 
            filePathLabel.AutoSize = true;
            filePathLabel.Location = new Point(315, 215);
            filePathLabel.Name = "filePathLabel";
            filePathLabel.Size = new Size(0, 15);
            filePathLabel.TabIndex = 5;
            // 
            // renameButton
            // 
            renameButton.Location = new Point(315, 142);
            renameButton.Name = "renameButton";
            renameButton.Size = new Size(75, 23);
            renameButton.TabIndex = 6;
            renameButton.Text = "Rename";
            renameButton.UseVisualStyleBackColor = true;
            renameButton.Click += RenameButton_Click;
            // 
            // FileExplorer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 265);
            Controls.Add(renameButton);
            Controls.Add(filePathLabel);
            Controls.Add(messageLabel);
            Controls.Add(searchButton);
            Controls.Add(fileNameTextBox);
            Controls.Add(mainTreeView);
            Controls.Add(mainMenuStrip);
            Name = "FileExplorer";
            Text = "FileExplorer";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TreeView mainTreeView;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TextBox fileNameTextBox;
        private Button searchButton;
        private Label messageLabel;
        private Label filePathLabel;
        private Button renameButton;
    }
}