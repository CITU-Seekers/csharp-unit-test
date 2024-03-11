using System.Text;

namespace CodeChum.Tests
{
    public class TextFileEditorTests
    {
        TextFileEditor? form;
        RichTextBox? MainRichTextBox;
        Button? OpenFileButton, SaveFileButton;

        public TextFileEditorTests()
        {
            form = new TextFileEditor();
            form.Show();
            MainRichTextBox = (RichTextBox)TestUtils.GetControlNamed(form, "MainRichTextBox", true);
            OpenFileButton = (Button)TestUtils.GetControlNamed(form, "OpenFileButton", true);
            SaveFileButton = (Button)TestUtils.GetControlNamed(form, "SaveFileButton", true);
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
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(MainRichTextBox);
            Assert.NotNull(OpenFileButton);
            Assert.NotNull(SaveFileButton);
        }

        [Fact]
        public void ShouldSaveFileOnSaveFileButtonClick()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string expectedFileName = path + "\\sample_create.txt";

            form.EditorSaveFileDialog.FileName = expectedFileName;
            MainRichTextBox.Text = "Hello World";

            SaveFileButton.PerformClick();

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
        public void ShouldOpenFileOnOpenFileButtonClick()
        {
            createFile();
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            form.EditorOpenFileDialog.FileName = path + "\\sample_open.txt";

            OpenFileButton.PerformClick();

            Assert.Equal("Hello World", MainRichTextBox.Text);

            File.Delete(form.EditorOpenFileDialog.FileName);
        }
    }
}