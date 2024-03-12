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
    public partial class TextFileMerger : Form
    {
        public OpenFileDialog OpenFileDialog { get; set; }
        public SaveFileDialog SaveFileDialog { get; set; }
        public TextFileMerger()
        {
            InitializeComponent();
            OpenFileDialog = new OpenFileDialog();
            SaveFileDialog = new SaveFileDialog();
        }

        public void MergeFiles(string[] fileNames)
        {
            //Create a string to hold the contents of the files
            string contents = "";

            //Loop through the file names
            foreach (string fileName in fileNames)
            {
                //Open the file
                System.IO.StreamReader sr = new System.IO.StreamReader(fileName);
                //Read the contents
                contents += sr.ReadToEnd();
                //Close the file
                sr.Close();
            }

            //Display the contents in the text box
            resultRichTextBox.Text = contents;
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            MergeFiles(OpenFileDialog.FileNames);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save the file
            SaveFileDialog.ShowDialog();

            //Get the file name
            string fileName = SaveFileDialog.FileName;

            //Create a stream writer
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fileName);

            //Write the contents of the text box to the file
            sw.Write(resultRichTextBox.Text);

            //Close the file
            sw.Close();
        }
    }
}
