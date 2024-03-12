namespace CodeChum.Tests
{
    public class TextFileMergerTest : IDisposable
    {
        private TextFileMerger form;
        private Button saveButton;
        private Button mergeButton;
        private RichTextBox resultRichTextBox;
        private Label fileMergedCounterLabel;

        public TextFileMergerTest()
        {
            form = new TextFileMerger();
            form.Show();
            saveButton = (Button)TestUtils.GetControlNamed(form, "saveButton", true);
            mergeButton = (Button)TestUtils.GetControlNamed(form, "mergeButton", true);
            resultRichTextBox = (RichTextBox)TestUtils.GetControlNamed(form, "resultRichTextBox", true);
            fileMergedCounterLabel = (Label)TestUtils.GetControlNamed(form, "fileMergedCounterLabel", true);
        }

        private void CreateTextFile(string filePath, string content)
        {
            using (var sw = new StreamWriter(filePath))
            {
                sw.Write(content);
            }
        }

        [Fact]
        // Description: Should have all controls `saveButton`, `mergeButton`, `resultRichTextBox`, and `fileMergedCounterLabel`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(saveButton);
            Assert.NotNull(mergeButton);
            Assert.NotNull(resultRichTextBox);
            Assert.NotNull(fileMergedCounterLabel);
        }

        [Fact]
        // Description: Should merge files "file1.txt", "file2.txt", and "file3.txt" and display the result "file1file2file3" in `resultRichTextBox`.
        public void ShouldMergeFiles()
        {
            // Arrange
            var file1 = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "file1.txt");
            var file2 = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "file2.txt");
            var file3 = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "file3.txt");
            CreateTextFile(file1, "file1");
            CreateTextFile(file2, "file2");
            CreateTextFile(file3, "file3");

            // Act
            form.MergeFiles(new string[] { file1, file2, file3 });

            // Assert
            Assert.Equal("file1file2file3", resultRichTextBox.Text);
        }   

        public void Dispose()
        {
            var file1 = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "file1.txt");
            var file2 = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "file2.txt");
            var file3 = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "file3.txt");

            File.Delete(file1);
            File.Delete(file2);
            File.Delete(file3);
        }
    }
}
