namespace CodeChum.Tests
{
    public class RegistrationFormTests
    {
        RegistrationForm? form;
        TextBox? NameTextBox, EmailTextBox, AddressTextBox;
        DateTimePicker? BirthDatePicker;
        Label? RegistrationLabel;
        Button? RegisterButton;

        public RegistrationFormTests()
        {
            form = new RegistrationForm();
            form.Show();
            NameTextBox = (TextBox)TestUtils.GetControlNamed(form, "NameTextBox", true);
            EmailTextBox = (TextBox)TestUtils.GetControlNamed(form, "EmailTextBox", true);
            AddressTextBox = (TextBox)TestUtils.GetControlNamed(form, "AddressTextBox", true);
            BirthDatePicker = (DateTimePicker)TestUtils.GetControlNamed(form, "BirthDatePicker", true);
            RegistrationLabel = (Label)TestUtils.GetControlNamed(form, "RegistrationLabel", true);
            RegisterButton = (Button)TestUtils.GetControlNamed(form, "RegisterButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(NameTextBox);
            Assert.NotNull(EmailTextBox);
            Assert.NotNull(AddressTextBox);
            Assert.NotNull(BirthDatePicker);
            Assert.NotNull(RegistrationLabel);
            Assert.NotNull(RegisterButton);
        }

        [Fact]
        public void ShouldNotRegisterWhenTextBoxesAreEmpty()
        {
            RegisterButton.PerformClick();

            Assert.Empty(RegistrationLabel.Text);
        }

        [Fact]
        public void ShouldNotRegisterWhenTextBoxesAreNotComplete()
        {
            string test = "TestString";
            NameTextBox.Text = test;

            RegisterButton.PerformClick();

            Assert.Empty(RegistrationLabel.Text);
        }

        [Fact]
        public void ShouldRegisterWhenTextBoxesAreComplete()
        {
            string testName = "TestName";
            string testEmail = "testEmail@test.com";
            string testAddress = "140 Test Test";
            string testBirthDate = DateTime.Now.ToString("MMMM dd, yyyy");
            NameTextBox.Text = testName;
            EmailTextBox.Text = testEmail;
            AddressTextBox.Text = testAddress;
            BirthDatePicker.Value = DateTime.Now;
            string testAge = ((int)(DateTime.Now - BirthDatePicker.Value).TotalDays / 365).ToString();
            string expectedText = $"Name: {testName}\nEmail: {testEmail}\nAddress: {testAddress}\n" +
                    $"Birth Date: {testBirthDate}\nAge: {testAge}";

            RegisterButton.PerformClick();

            Assert.Equal(expectedText, RegistrationLabel.Text);
        }
    }
}