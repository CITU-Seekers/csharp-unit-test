using System.Text;

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
            // Use the file path from the save dialog
            editorSaveFileDialog.ShowDialog();
            SaveFile(editorSaveFileDialog.FileName);
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            // Use the file path from the open dialog
            editorOpenFileDialog.ShowDialog();
            OpenFile(editorOpenFileDialog.FileName);
        }

        public void SaveFile(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    using (Stream fs = new FileStream(filePath, FileMode.Create))
                    {
                        byte[] content = new UTF8Encoding(true).GetBytes(mainRichTextBox.Text);
                        fs.Write(content, 0, content.Length);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public void OpenFile(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                mainRichTextBox.Text = File.ReadAllText(filePath);
            }
        }
    }
}
