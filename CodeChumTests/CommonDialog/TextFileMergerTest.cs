using System.Text;
namespace CodeChum.Tests
{
    public class TextFileMergerTest
    {
        TextFileMerger? form;
        Button? btnSave;
        Button? btnMerge;
        RichTextBox? TextBox;
        Label? lblFileNum;

        public TextFileMergerTest()
        {
            form = new TextFileMerger();
            form.Show();
            btnSave = (Button)TestUtils.GetControlNamed(form, "btnSave", true);
            btnMerge = (Button)TestUtils.GetControlNamed(form, "btnMerge", true);
            TextBox = (RichTextBox)TestUtils.GetControlNamed(form, "TextBox", true);
            lblFileNum = (Label)TestUtils.GetControlNamed(form, "lblFileNum", true);
        }

        public void createFiles()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string fileName1 = path + "\\sample_open.txt";
            string fileName2 = path + "\\sample_open2.txt";

            try
            {
                // Delete existing files if they exist
                if (File.Exists(fileName1))
                {
                    File.Delete(fileName1);
                }

                if (File.Exists(fileName2))
                {
                    File.Delete(fileName2);
                }

                // Create the first text file
                using (FileStream fs1 = File.Create(fileName1))
                {
                    Byte[] helloWorld1 = new UTF8Encoding(true).GetBytes("Hello World \n");
                    fs1.Write(helloWorld1, 0, helloWorld1.Length);
                }

                // Create the second text file
                using (FileStream fs2 = File.Create(fileName2))
                {
                    Byte[] helloWorld2 = new UTF8Encoding(true).GetBytes("TESTING");
                    fs2.Write(helloWorld2, 0, helloWorld2.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(btnSave);
            Assert.NotNull(btnMerge);
            Assert.NotNull(TextBox);
            Assert.NotNull(lblFileNum);
        }

        [Fact]
        public void ShouldOpenAndMergeFiles()
        {
            createFiles();
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            // Enable the Multiselect property to allow the selection of multiple files
            form.OpenFileDialog.Multiselect = true;

            // Show the dialog to select multiple files
            DialogResult result = form.OpenFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Provide the selected file paths to the merging logic
                string[] selectedFiles = { path + "\\sample_open.txt", path + "\\sample_open2.txt" };

                // Perform the merging logic (replace this with your actual merging logic)
                StringBuilder mergedContent = new StringBuilder();

                foreach (string filePath in selectedFiles)
                {
                    try
                    {
                        string fileContent = File.ReadAllText(filePath);
                        mergedContent.AppendLine(fileContent);
                    }
                    catch (IOException)
                    {
                        // Handle file read error if needed
                    }
                }

                // Assuming TextBox is the name of the TextBox control where you display the merged content
                TextBox.Text = mergedContent.ToString();
            }

            Assert.Equal("Hello World \nTESTING", TextBox.Text);
        }

        [Fact]
        public void ShouldSaveMergedFile()
        {
            createFiles();
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string expectedFileName = path + "\\sample_create.txt";

            // Enable the Multiselect property to allow the selection of multiple files
            form.OpenFileDialog.Multiselect = true;

            // Show the dialog to select multiple files
            DialogResult result = form.OpenFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Provide the selected file paths to the merging logic
                string[] selectedFiles = { path + "\\sample_open.txt", path + "\\sample_open2.txt" };

                // Perform the merging logic (replace this with your actual merging logic)
                StringBuilder mergedContent = new StringBuilder();

                foreach (string filePath in selectedFiles)
                {
                    try
                    {
                        string fileContent = File.ReadAllText(filePath);
                        mergedContent.AppendLine(fileContent);
                    }
                    catch (IOException)
                    {
                        // Handle file read error if needed
                    }
                }

                // Assuming TextBox is the name of the TextBox control where you display the merged content
                TextBox.Text = mergedContent.ToString();
            }


            // Get the file name
            form.SaveFileDialog.FileName = expectedFileName;

            btnSave.PerformClick();

            Assert.True(File.Exists(expectedFileName));

            string actualString = "";
            using (StreamReader sr = File.OpenText(expectedFileName))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    actualString += s;
                }
            }

            Assert.Equal("Hello World \nTESTING", actualString);

            File.Delete(expectedFileName);
        }
    }
}
