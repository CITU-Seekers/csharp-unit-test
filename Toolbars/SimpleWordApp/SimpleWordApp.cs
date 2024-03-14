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
    public partial class SimpleWordApp : Form
    {
        public SimpleWordApp()
        {
            InitializeComponent();
            fontToolStripComboBox.SelectedIndex = 0;
            colorToolStripComboBox.SelectedIndex = 0;
            fontSizeToolStripTextBox.Text = "12";
        }

        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fontToolStripComboBox.SelectedIndex == 0)
            {
                mainRichTextBox.Font = new Font("Arial", 12);
            }
            else if (fontToolStripComboBox.SelectedIndex == 1)
            {
                mainRichTextBox.Font = new Font("Times New Roman", 12);
            }
            else if (fontToolStripComboBox.SelectedIndex == 2)
            {
                mainRichTextBox.Font = new Font("Cascadia Code", 12);
            }
            else if (fontToolStripComboBox.SelectedIndex == 3)
            {
                mainRichTextBox.Font = new Font("Segoe UI", 12);
            }
            else if (fontToolStripComboBox.SelectedIndex == 4)
            {
                mainRichTextBox.Font = new Font("Tahoma", 12);
            }
            else if (fontToolStripComboBox.SelectedIndex == 5)
            {
                mainRichTextBox.Font = new Font("Verdana", 12);
            }
        }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (colorToolStripComboBox.SelectedIndex == 0)
            {
                mainRichTextBox.ForeColor = Color.Black;
            }
            else if (colorToolStripComboBox.SelectedIndex == 1)
            {
                mainRichTextBox.ForeColor = Color.Red;
            }
            else if (colorToolStripComboBox.SelectedIndex == 2)
            {
                mainRichTextBox.ForeColor = Color.Green;
            }
            else if (colorToolStripComboBox.SelectedIndex == 3)
            {
                mainRichTextBox.ForeColor = Color.Blue;
            }
            else if (colorToolStripComboBox.SelectedIndex == 4)
            {
                mainRichTextBox.ForeColor = Color.Orange;
            }
        }

        private void FontSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            //Change the font size
            mainRichTextBox.Font = new Font(mainRichTextBox.Font.FontFamily, float.Parse(fontSizeToolStripTextBox.Text));
        }

        private void MainRichTextBox_TextChanged(object sender, EventArgs e)
        {
            //Every text changed event, Display in the StatusBar "Word Counting..." for 5 seconds and then display the word count
            toolStripStatusLabel.Text = "Word Counting...";
            Task.Delay(5000).ContinueWith(t => toolStripStatusLabel.Text = "Word Count: " + mainRichTextBox.Text.Split(' ').Length);
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            //Clear the text box and reset the font size and color to default values
            mainRichTextBox.Clear();
            mainRichTextBox.Font = new Font("Arial", 12);
            mainRichTextBox.ForeColor = Color.Black;
            fontToolStripComboBox.SelectedIndex = 0;
            colorToolStripComboBox.SelectedIndex = 0;
            fontSizeToolStripTextBox.Text = "12";

            //Display in the StatusBar "New File Created" for 5 seconds
            toolStripStatusLabel.Text = "New File Created";
            Task.Delay(5000).ContinueWith(t => toolStripStatusLabel.Text = "");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Display in the StatusBar "File Saved" for 5 seconds
            toolStripStatusLabel.Text = "File Saved";
            Task.Delay(5000).ContinueWith(t => toolStripStatusLabel.Text = "");
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            //Display in the StatusBar "Printing..." for 5 seconds
            toolStripStatusLabel.Text = "Printing...";
            Task.Delay(5000).ContinueWith(t => toolStripStatusLabel.Text = "");
        }
    }
}
