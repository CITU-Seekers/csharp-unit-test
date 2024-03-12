namespace CodeChum.Tests
{
    public class PersonalInformationFormTests
    {
        PersonalInformationForm? form;
        ProgressBar? formProgressBar;
        TextBox? nameTextBox, addressTextBox, quoteTextBox;
        GroupBox? programmingLanguageGroupBox;
        CheckBox? programmingLanguageCheckBox1, programmingLanguageCheckBox2;

        public PersonalInformationFormTests()
        {
            form = new PersonalInformationForm();
            formProgressBar = (ProgressBar)TestUtils.GetControlNamed(form, "formProgressBar", true);
            nameTextBox = (TextBox)TestUtils.GetControlNamed(form, "nameTextBox", true);
            addressTextBox = (TextBox)TestUtils.GetControlNamed(form, "addressTextBox", true);
            quoteTextBox = (TextBox)TestUtils.GetControlNamed(form, "quoteTextBox", true);
            programmingLanguageGroupBox = (GroupBox)TestUtils.GetControlNamed(form, "programmingLanguageGroupBox", true);
            programmingLanguageCheckBox1 = (CheckBox)TestUtils.GetControlNamed(form, "programmingLanguageCheckBox1", true);
            programmingLanguageCheckBox2 = (CheckBox)TestUtils.GetControlNamed(form, "programmingLanguageCheckBox2", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(formProgressBar);
            Assert.NotNull(nameTextBox);
            Assert.NotNull(addressTextBox);
            Assert.NotNull(quoteTextBox);
            Assert.NotNull(programmingLanguageGroupBox);
            Assert.NotNull(programmingLanguageCheckBox1);
            Assert.NotNull(programmingLanguageCheckBox2);
        }

        [Fact]
        public void ShouldIncreaseProgressOnTextChangeNameTextBox()
        {
            nameTextBox.Text = "Test";

            Assert.NotEqual(0, formProgressBar.Value);
        }

        [Fact]
        public void ShouldIncreaseProgressOnTextChangeAddressTextBox()
        {
            addressTextBox.Text = "Test";

            Assert.NotEqual(0, formProgressBar.Value);
        }

        [Fact]
        public void ShouldIncreaseProgressOnTextChangeQuoteTextBox()
        {
            quoteTextBox.Text = "Test";

            Assert.NotEqual(0, formProgressBar.Value);
        }

        [Fact]
        public void ShouldIncreaseProgressOnCheckBoxCheck()
        {
            programmingLanguageCheckBox1.Checked = true;

            Assert.NotEqual(0, formProgressBar.Value);

            programmingLanguageCheckBox1.Checked = false;
            programmingLanguageCheckBox2.Checked = true;

            Assert.NotEqual(0, formProgressBar.Value);
        }

        [Fact]
        public void ShouldDecreaseProgressOnTextChangeNameTextBoxEmpty()
        {
            nameTextBox.Text = "Test";
            nameTextBox.Text = "";

            Assert.Equal(0, formProgressBar.Value);
        }

        [Fact]
        public void ShouldDecreaseProgressOnTextChangeAddressTextBoxEmpty()
        {
            addressTextBox.Text = "Test";
            addressTextBox.Text = "";

            Assert.Equal(0, formProgressBar.Value);
        }

        [Fact]
        public void ShouldDecreaseProgressOnTextChangeQuoteTextBoxEmpty()
        {
            quoteTextBox.Text = "Test";
            quoteTextBox.Text = "";

            Assert.Equal(0, formProgressBar.Value);
        }

        [Fact]
        public void ShouldDecreaseProgressOnCheckBoxUnselect()
        {
            programmingLanguageCheckBox1.Checked = true;
            programmingLanguageCheckBox1.Checked = false;

            Assert.Equal(0, formProgressBar.Value);

            programmingLanguageCheckBox2.Checked = true;
            programmingLanguageCheckBox2.Checked = false;

            Assert.Equal(0, formProgressBar.Value);
        }
    }
}