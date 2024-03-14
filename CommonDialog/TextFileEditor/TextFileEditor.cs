using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CodeChum
{
    public partial class TextFileEditor : Form
    {
        public TextFileEditor()
        {
            InitializeComponent();
            editorOpenFileDialog = new OpenFileDialog();
            editorSaveFileDialog = new SaveFileDialog();
        }

        public OpenFileDialog editorOpenFileDialog { get; set; }
        public SaveFileDialog editorSaveFileDialog { get; set; }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            /*Task.Run(() =>
            {
                editorSaveFileDialog.ShowDialog();
            });*/
            editorSaveFileDialog.ShowDialog();

            if (editorSaveFileDialog.FileName.Length > 0)
            {
                try
                {
                    using (Stream fs = editorSaveFileDialog.OpenFile())
                    {
                        Byte[] helloWorld = new UTF8Encoding(true).GetBytes(mainRichTextBox.Text);
                        fs.Write(helloWorld, 0, helloWorld.Length);
                    }
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.ToString());
                }
            }
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            // Task.Run(() => editorOpenFileDialog.ShowDialog());
            editorOpenFileDialog.ShowDialog();

            if (editorOpenFileDialog.FileName.Length > 0)
            {
                String fileName = editorOpenFileDialog.FileName;
                mainRichTextBox.Text = System.IO.File.ReadAllText(fileName);
            }
        }
    }
}
