using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChum
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        private void MainRichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            int index = MainRichTextBox.SelectionStart;
            int line = MainRichTextBox.GetLineFromCharIndex(index) ;
            int col = MainRichTextBox.SelectionStart - MainRichTextBox.GetFirstCharIndexFromLine(line);
            CaretPositionStatusLabel.Text = "Ln: " + (line + 1).ToString() + ", Col: " + (col + 1).ToString();
        }

        private void ToStartButton_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectionStart = 0;
            MainRichTextBox.Focus();
        }

        private void ToEndButton_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectionStart = MainRichTextBox.Text.Length;
            MainRichTextBox.Focus();
        }

        private void MainRichTextBox_TextChanged(object sender, EventArgs e)
        {
            TextLengthProgressBar.Value = MainRichTextBox.Text.Length;
        }
    }
}
