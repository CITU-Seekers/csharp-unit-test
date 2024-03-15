namespace CodeChum.Tests
{
    public class RegistrationWithStatusFormTests
    {
        RegistrationWithStatusForm? form;
        TextBox? nameTextBox, emailTextBox, addressTextBox;
        DateTimePicker? birthDatePicker;
        Label? registrationLabel;
        ToolStripStatusLabel registrationStatusLabel;
        Button? registerButton;
        StatusStrip? registrationStatusStrip;

        public RegistrationWithStatusFormTests()
        {
            form = new RegistrationWithStatusForm();
            form.Show();
            nameTextBox = (TextBox)TestUtils.GetControlNamed(form, "nameTextBox", true);
            emailTextBox = (TextBox)TestUtils.GetControlNamed(form, "emailTextBox", true);
            addressTextBox = (TextBox)TestUtils.GetControlNamed(form, "addressTextBox", true);
            birthDatePicker = (DateTimePicker)TestUtils.GetControlNamed(form, "birthDatePicker", true);
            registrationLabel = (Label)TestUtils.GetControlNamed(form, "registrationLabel", true);
            registerButton = (Button)TestUtils.GetControlNamed(form, "registerButton", true);
            registrationStatusStrip = (StatusStrip)TestUtils.GetControlNamed(form, "registrationStatusStrip", true);
        }

        [Fact]
        // Description: Should have all the controls `nameTextBox`, `emailTextBox`, `addressTextBox`, `birthDatePicker`, `registrationLabel`, and `registerButton`.
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
        // Description: Should have the `registrationStatusStrip` along with its label `registrationStatusLabel`.
        public void ShouldHaveStatusStripAlongWithItsLabel()
        {
            Assert.NotNull(registrationStatusStrip);

            registrationStatusLabel = registrationStatusStrip.Items["registrationStatusLabel"] as ToolStripStatusLabel;
            Assert.NotNull(registrationStatusLabel);
        }

        [Fact]
        // Description: Should not register when text boxes are empty on `registerButton` click.
        public void ShouldNotRegisterWhenTextBoxesAreEmpty()
        {
            registerButton.PerformClick();

            Assert.Empty(registrationLabel.Text);
        }

        [Fact]
        // Description: Should not register when at least one text box is empty on `registerButton` click.
        public void ShouldNotRegisterWhenTextBoxesAreNotComplete()
        {
            string test = "TestString";
            nameTextBox.Text = test;

            registerButton.PerformClick();

            Assert.Empty(registrationLabel.Text);
        }

        [Fact]
        // Description : Should register when text boxes are complete and display the details in `registrationLabel` on `registerButton` click.
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

        [Fact]
        // Description: Should display the correct status message in `registrationStatusLabel` when `nameTextBox` is updated.
        public void ShouldUpdateStatusWhenNameIsUpdated()
        {
            string inputValue = "TestName";
            nameTextBox.Text = inputValue;

            registrationStatusLabel = registrationStatusStrip.Items["registrationStatusLabel"] as ToolStripStatusLabel;
            String statusText = registrationStatusLabel.Text.ToLower();

            Assert.True(statusText.Length > 0, "The proper status text for name text box should be displayed.");
            Assert.True(statusText.Contains("name"), "The status text should contain the word 'name'");
        }

        [Fact]
        // Description: Should display the correct status message in `registrationStatusLabel` when `emailTextBox` is updated.
        public void ShouldUpdateStatusWhenEmailIsUpdated()
        {
            string inputValue = "TestEmail@email.com";
            emailTextBox.Text = inputValue;

            registrationStatusLabel = registrationStatusStrip.Items["registrationStatusLabel"] as ToolStripStatusLabel;
            String statusText = registrationStatusLabel.Text.ToLower();

            Assert.True(statusText.Length > 0, "The proper status text for email text box should be displayed.");
            Assert.True(statusText.Contains("email"), "The status text should contain the word 'email'");
        }

        [Fact]
        // Description: Should display the correct status message in `registrationStatusLabel` when `addressTextBox` is updated.
        public void ShouldUpdateStatusWhenAddressIsUpdated()
        {
            string inputValue = "somewhere";
            addressTextBox.Text = inputValue;

            registrationStatusLabel = registrationStatusStrip.Items["registrationStatusLabel"] as ToolStripStatusLabel;
            String statusText = registrationStatusLabel.Text.ToLower();

            Assert.True(statusText.Length > 0, "The proper status text for email text box should be displayed.");
            Assert.True(statusText.Contains("address"), "The status text should contain the word 'address'");
        }

        [Fact]
        // Description: Should display the correct status message in `registrationStatusLabel` when `birthDatePicker` is updated.
        public void ShouldUpdateStatusWhenDatePickerIsUpdated()
        {
            birthDatePicker.Value = DateTime.Now;

            registrationStatusLabel = registrationStatusStrip.Items["registrationStatusLabel"] as ToolStripStatusLabel;
            String statusText = registrationStatusLabel.Text.ToLower();

            Assert.True(statusText.Length > 0, "The proper status text for email text box should be displayed.");
            Assert.True(statusText.Contains("birth date"), "The status text should contain the word 'birth date'");
        }
    }
}