using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChum
{
    public partial class TabbedTextEditor : Form
    {
        public TabbedTextEditor()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (fileNameTextBox.Text.Equals(string.Empty))
            {
                return;
            }
            TabPage newTabPage = new TabPage();
            newTabPage.Name = fileNameTextBox.Text + "TabPage";
            newTabPage.Text = fileNameTextBox.Text;
            newTabPage.Size = new System.Drawing.Size(796, 352);
            newTabPage.BackColor = Color.White;
            RichTextBox newRichTextBox = new RichTextBox();
            newRichTextBox.Location = new System.Drawing.Point(33, 44);
            newRichTextBox.Size = new System.Drawing.Size(641, 188);
            newRichTextBox.Name = fileNameTextBox.Text + "RichTextBox";
            newTabPage.Size = new System.Drawing.Size(796, 352);
            newTabPage.Controls.Add(newRichTextBox);
            editorTabControl.TabPages.Add(newTabPage);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var tab = editorTabControl.SelectedTab;
            editorTabControl.SelectedTab = editorTabControl.TabPages[editorTabControl.SelectedIndex - 1];
            editorTabControl.TabPages.Remove(tab);
        }

        private void EditorTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (editorTabControl.SelectedTab == mainTabPage)
            {
                deleteButton.Enabled = false;
            }
            else
            {
                deleteButton.Enabled = true;
            }
        }
    }
}
