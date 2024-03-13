using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChum
{
    public partial class CopyPasteMenus : Form
    {
        public FontDialog FormatFontDialog { get; set; }
        public ColorDialog FormatColorDialog { get; set; }
        public CopyPasteMenus()
        {
            InitializeComponent();
            FormatColorDialog = new ColorDialog();
            FormatFontDialog = new FontDialog();
        }

        public void ChangeFontColor(Color color)
        {
            richTextBox1.ForeColor = color;
            richTextBox2.ForeColor = color;
        }

        public void ChangeFontStyle(Font font)
        {
            richTextBox1.Font = font;
            richTextBox2.Font = font;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Copy everything in richtextbox1 without using clipboard
            var text = richTextBox1.Text;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var text = richTextBox1.Text;


            //Paste everything in richtextbox2 without using clipboard
            richTextBox2.Text = text;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cut everything in richtextbox1 without using clipboard
            richTextBox2.Text = richTextBox1.Text;
            richTextBox1.Text = "";
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatColorDialog.ShowDialog();

            //Set font color of richtextbox1 to selected color
            ChangeFontColor(FormatColorDialog.Color);
        }

        private void fontStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatFontDialog.ShowDialog();

            //Set font of richtextbox1 to selected font
            ChangeFontStyle(FormatFontDialog.Font);
        }
    }
}
