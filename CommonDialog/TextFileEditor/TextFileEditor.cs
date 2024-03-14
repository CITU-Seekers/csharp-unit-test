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
            EditorOpenFileDialog = new OpenFileDialog();
            EditorSaveFileDialog = new SaveFileDialog();
        }

        public OpenFileDialog EditorOpenFileDialog { get; set; }
        public SaveFileDialog EditorSaveFileDialog { get; set; }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            /*Task.Run(() =>
            {
                EditorSaveFileDialog.ShowDialog();
            });*/
            EditorSaveFileDialog.ShowDialog();

            if (EditorSaveFileDialog.FileName.Length > 0)
            {
                try
                {
                    using (Stream fs = EditorSaveFileDialog.OpenFile())
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
            // Task.Run(() => EditorOpenFileDialog.ShowDialog());
            EditorOpenFileDialog.ShowDialog();

            if (EditorOpenFileDialog.FileName.Length > 0)
            {
                String fileName = EditorOpenFileDialog.FileName;
                mainRichTextBox.Text = System.IO.File.ReadAllText(fileName);
            }
        }
    }
}
