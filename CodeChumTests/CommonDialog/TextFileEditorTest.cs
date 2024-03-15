using System.Text;

namespace CodeChum.Tests
{
    public class TextFileEditorTests
    {
        TextFileEditor? form;
        RichTextBox? mainRichTextBox;
        Button? openFileButton, saveFileButton;

        public TextFileEditorTests()
        {
            form = new TextFileEditor();
            form.Show();
            mainRichTextBox = (RichTextBox)TestUtils.GetControlNamed(form, "mainRichTextBox", true);
            openFileButton = (Button)TestUtils.GetControlNamed(form, "openFileButton", true);
            saveFileButton = (Button)TestUtils.GetControlNamed(form, "saveFileButton", true);
        }

        public void createFile()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string fileName = path + "\\sample_open.txt";

            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                using (FileStream fs = File.Create(fileName))
                {
                    Byte[] helloWorld = new UTF8Encoding(true).GetBytes("Hello World");
                    fs.Write(helloWorld, 0, helloWorld.Length);
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        [Fact]
        // Description: Should have all the controls `mainRichTextBox`, `openFileButton`, and `saveFileButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(mainRichTextBox);
            Assert.NotNull(openFileButton);
            Assert.NotNull(saveFileButton);
        }

        [Fact]
        // Description: Should save the text in the `mainRichTextBox` to a file when the `saveFileButton` is clicked.
        public void ShouldSaveFileOnSaveFileButtonClick()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string expectedFileName = path + "\\sample_create.txt";

            form.editorSaveFileDialog.FileName = expectedFileName;
            mainRichTextBox.Text = "Hello World";

            saveFileButton.PerformClick();

            Assert.True(File.Exists(expectedFileName), "The file named `sample_create.txt` should be created at the root folder.");

            string actualString = "";
            using (StreamReader sr = File.OpenText(expectedFileName))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    actualString += s;
                }
            }

            Assert.Equal("Hello World", actualString);

            File.Delete(expectedFileName);
        }

        [Fact]
        // Description: Should open a file and display its content in the `mainRichTextBox` when the `openFileButton` is clicked.
        public void ShouldOpenFileOnOpenFileButtonClick()
        {
            createFile();
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            form.editorOpenFileDialog.FileName = path + "\\sample_open.txt";

            openFileButton.PerformClick();

            Assert.Equal("Hello World", mainRichTextBox.Text);

            File.Delete(form.editorOpenFileDialog.FileName);
        }
    }
}