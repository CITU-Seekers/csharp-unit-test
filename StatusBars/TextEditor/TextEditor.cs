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
            int index = mainRichTextBox.SelectionStart;
            int line = mainRichTextBox.GetLineFromCharIndex(index) ;
            int col = mainRichTextBox.SelectionStart - mainRichTextBox.GetFirstCharIndexFromLine(line);
            caretPositionStatusLabel.Text = "Ln: " + (line + 1).ToString() + ", Col: " + (col + 1).ToString();
        }

        private void ToStartButton_Click(object sender, EventArgs e)
        {
            mainRichTextBox.SelectionStart = 0;
            mainRichTextBox.Focus();
        }

        private void ToEndButton_Click(object sender, EventArgs e)
        {
            mainRichTextBox.SelectionStart = mainRichTextBox.Text.Length;
            mainRichTextBox.Focus();
        }

        private void MainRichTextBox_TextChanged(object sender, EventArgs e)
        {
            textLengthProgressBar.Value = mainRichTextBox.Text.Length;
        }
    }
}
