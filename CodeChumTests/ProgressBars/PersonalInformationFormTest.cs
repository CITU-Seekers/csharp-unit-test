namespace CodeChum.Tests
{
    public class PersonalInformationFormTests
    {
        PersonalInformationForm? form;
        ProgressBar? ProgressBar;
        TextBox? NameTextBox, AddressTextBox, QuoteTextBox;
        GroupBox? ProgrammingLanguageGroupBox;
        CheckBox? ProgrammingLanguageCheckBox1, ProgrammingLanguageCheckBox2;

        public PersonalInformationFormTests()
        {
            form = new PersonalInformationForm();
            ProgressBar = (ProgressBar)TestUtils.GetControlNamed(form, "ProgressBar", true);
            NameTextBox = (TextBox)TestUtils.GetControlNamed(form, "NameTextBox", true);
            AddressTextBox = (TextBox)TestUtils.GetControlNamed(form, "AddressTextBox", true);
            QuoteTextBox = (TextBox)TestUtils.GetControlNamed(form, "QuoteTextBox", true);
            ProgrammingLanguageGroupBox = (GroupBox)TestUtils.GetControlNamed(form, "ProgrammingLanguageGroupBox", true);
            ProgrammingLanguageCheckBox1 = (CheckBox)TestUtils.GetControlNamed(form, "ProgrammingLanguageCheckBox1", true);
            ProgrammingLanguageCheckBox2 = (CheckBox)TestUtils.GetControlNamed(form, "ProgrammingLanguageCheckBox2", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(ProgressBar);
            Assert.NotNull(NameTextBox);
            Assert.NotNull(AddressTextBox);
            Assert.NotNull(QuoteTextBox);
            Assert.NotNull(ProgrammingLanguageGroupBox);
            Assert.NotNull(ProgrammingLanguageCheckBox1);
            Assert.NotNull(ProgrammingLanguageCheckBox2);
        }

        [Fact]
        public void ShouldIncreaseProgressOnTextChangeNameTextBox()
        {
            NameTextBox.Text = "Test";

            Assert.NotEqual(0, ProgressBar.Value);
        }

        [Fact]
        public void ShouldIncreaseProgressOnTextChangeAddressTextBox()
        {
            AddressTextBox.Text = "Test";

            Assert.NotEqual(0, ProgressBar.Value);
        }

        [Fact]
        public void ShouldIncreaseProgressOnTextChangeQuoteTextBox()
        {
            QuoteTextBox.Text = "Test";

            Assert.NotEqual(0, ProgressBar.Value);
        }

        [Fact]
        public void ShouldIncreaseProgressOnCheckBoxCheck()
        {
            ProgrammingLanguageCheckBox1.Checked = true;

            Assert.NotEqual(0, ProgressBar.Value);

            ProgrammingLanguageCheckBox1.Checked = false;
            ProgrammingLanguageCheckBox2.Checked = true;

            Assert.NotEqual(0, ProgressBar.Value);
        }

        [Fact]
        public void ShouldDecreaseProgressOnTextChangeNameTextBoxEmpty()
        {
            NameTextBox.Text = "Test";
            NameTextBox.Text = "";

            Assert.Equal(0, ProgressBar.Value);
        }

        [Fact]
        public void ShouldDecreaseProgressOnTextChangeAddressTextBoxEmpty()
        {
            AddressTextBox.Text = "Test";
            AddressTextBox.Text = "";

            Assert.Equal(0, ProgressBar.Value);
        }

        [Fact]
        public void ShouldDecreaseProgressOnTextChangeQuoteTextBoxEmpty()
        {
            QuoteTextBox.Text = "Test";
            QuoteTextBox.Text = "";

            Assert.Equal(0, ProgressBar.Value);
        }

        [Fact]
        public void ShouldDecreaseProgressOnCheckBoxUnselect()
        {
            ProgrammingLanguageCheckBox1.Checked = true;
            ProgrammingLanguageCheckBox1.Checked = false;

            Assert.Equal(0, ProgressBar.Value);

            ProgrammingLanguageCheckBox2.Checked = true;
            ProgrammingLanguageCheckBox2.Checked = false;

            Assert.Equal(0, ProgressBar.Value);
        }
    }
}