namespace CodeChum.Tests
{
    public class RegistrationFormTests
    {
        RegistrationForm? form;
        TextBox? nameTextBox, emailTextBox, addressTextBox;
        DateTimePicker? birthDatePicker;
        Label? registrationLabel;
        Button? registerButton;

        public RegistrationFormTests()
        {
            form = new RegistrationForm();
            form.Show();
            nameTextBox = (TextBox)TestUtils.GetControlNamed(form, "nameTextBox", true);
            emailTextBox = (TextBox)TestUtils.GetControlNamed(form, "emailTextBox", true);
            addressTextBox = (TextBox)TestUtils.GetControlNamed(form, "addressTextBox", true);
            birthDatePicker = (DateTimePicker)TestUtils.GetControlNamed(form, "birthDatePicker", true);
            registrationLabel = (Label)TestUtils.GetControlNamed(form, "registrationLabel", true);
            registerButton = (Button)TestUtils.GetControlNamed(form, "registerButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(nameTextBox);
            Assert.NotNull(emailTextBox);
            Assert.NotNull(addressTextBox);
            Assert.NotNull(birthDatePicker);
            Assert.NotNull(registrationLabel);
            Assert.NotNull(registerButton);
        }

        [Fact]
        public void ShouldNotRegisterWhenTextBoxesAreEmpty()
        {
            registerButton.PerformClick();

            Assert.Empty(registrationLabel.Text);
        }

        [Fact]
        public void ShouldNotRegisterWhenTextBoxesAreNotComplete()
        {
            string test = "TestString";
            nameTextBox.Text = test;

            registerButton.PerformClick();

            Assert.Empty(registrationLabel.Text);
        }

        [Fact]
        public void ShouldRegisterWhenTextBoxesAreComplete()
        {
            string testName = "TestName";
            string testEmail = "testEmail@test.com";
            string testAddress = "140 Test Test";
            string testBirthDate = DateTime.Now.ToString("MMMM dd, yyyy");
            nameTextBox.Text = testName;
            emailTextBox.Text = testEmail;
            addressTextBox.Text = testAddress;
            birthDatePicker.Value = DateTime.Now;
            string testAge = ((int)(DateTime.Now - birthDatePicker.Value).TotalDays / 365).ToString();
            string expectedText = $"Name: {testName}\nEmail: {testEmail}\nAddress: {testAddress}\n" +
                    $"Birth Date: {testBirthDate}\nAge: {testAge}";

            registerButton.PerformClick();

            Assert.Equal(expectedText, registrationLabel.Text);
        }
    }
}