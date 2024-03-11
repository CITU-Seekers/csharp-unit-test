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
            FontComboBox.SelectedIndex = 0;
            ColorComboBox.SelectedIndex = 0;
            FontSizeTextBox.Text = "12";
        }

        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FontComboBox.SelectedIndex == 0)
            {
                MainRichTextBox.Font = new Font("Arial", 12);
            }
            else if (FontComboBox.SelectedIndex == 1)
            {
                MainRichTextBox.Font = new Font("Times New Roman", 12);
            }
            else if (FontComboBox.SelectedIndex == 2)
            {
                MainRichTextBox.Font = new Font("Cascadia Code", 12);
            }
            else if (FontComboBox.SelectedIndex == 3)
            {
                MainRichTextBox.Font = new Font("Segoe UI", 12);
            }
            else if (FontComboBox.SelectedIndex == 4)
            {
                MainRichTextBox.Font = new Font("Tahoma", 12);
            }
            else if (FontComboBox.SelectedIndex == 5)
            {
                MainRichTextBox.Font = new Font("Verdana", 12);
            }
        }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ColorComboBox.SelectedIndex == 0)
            {
                MainRichTextBox.ForeColor = Color.Black;
            }
            else if (ColorComboBox.SelectedIndex == 1)
            {
                MainRichTextBox.ForeColor = Color.Red;
            }
            else if (ColorComboBox.SelectedIndex == 2)
            {
                MainRichTextBox.ForeColor = Color.Green;
            }
            else if (ColorComboBox.SelectedIndex == 3)
            {
                MainRichTextBox.ForeColor = Color.Blue;
            }
            else if (ColorComboBox.SelectedIndex == 4)
            {
                MainRichTextBox.ForeColor = Color.Orange;
            }
        }

        private void FontSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            //Change the font size
            MainRichTextBox.Font = new Font(MainRichTextBox.Font.FontFamily, float.Parse(FontSizeTextBox.Text));
        }

        private void MainRichTextBox_TextChanged(object sender, EventArgs e)
        {
            //Every text changed event, Display in the StatusBar "Word Counting..." for 5 seconds and then display the word count
            StatusLabel.Text = "Word Counting...";
            Task.Delay(5000).ContinueWith(t => StatusLabel.Text = "Word Count: " + MainRichTextBox.Text.Split(' ').Length);
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            //Clear the text box and reset the font size and color to default values
            MainRichTextBox.Clear();
            MainRichTextBox.Font = new Font("Arial", 12);
            MainRichTextBox.ForeColor = Color.Black;
            FontComboBox.SelectedIndex = 0;
            ColorComboBox.SelectedIndex = 0;
            FontSizeTextBox.Text = "12";

            //Display in the StatusBar "New File Created" for 5 seconds
            StatusLabel.Text = "New File Created";
            Task.Delay(5000).ContinueWith(t => StatusLabel.Text = "");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Display in the StatusBar "File Saved" for 5 seconds
            StatusLabel.Text = "File Saved";
            Task.Delay(5000).ContinueWith(t => StatusLabel.Text = "");
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            //Display in the StatusBar "Printing..." for 5 seconds
            StatusLabel.Text = "Printing...";
            Task.Delay(5000).ContinueWith(t => StatusLabel.Text = "");
        }
    }
}
