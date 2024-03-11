namespace CodeChum.Tests
{
    public class RegistrationWithStatusFormTests
    {
        RegistrationWithStatusForm? form;
        TextBox? NameTextBox, EmailTextBox, AddressTextBox;
        DateTimePicker? BirthDatePicker;
        Label? RegistrationLabel;
        ToolStripStatusLabel RegistrationStatusLabel;
        Button? RegisterButton;
        StatusStrip? RegistrationStatusStrip;

        public RegistrationWithStatusFormTests()
        {
            form = new RegistrationWithStatusForm();
            form.Show();
            NameTextBox = (TextBox)TestUtils.GetControlNamed(form, "NameTextBox", true);
            EmailTextBox = (TextBox)TestUtils.GetControlNamed(form, "EmailTextBox", true);
            AddressTextBox = (TextBox)TestUtils.GetControlNamed(form, "AddressTextBox", true);
            BirthDatePicker = (DateTimePicker)TestUtils.GetControlNamed(form, "BirthDatePicker", true);
            RegistrationLabel = (Label)TestUtils.GetControlNamed(form, "RegistrationLabel", true);
            RegisterButton = (Button)TestUtils.GetControlNamed(form, "RegisterButton", true);
            RegistrationStatusStrip = (StatusStrip)TestUtils.GetControlNamed(form, "RegistrationStatusStrip", true);
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
        public void ShouldHaveStatusStripAlongWithItsLabel()
        {
            Assert.NotNull(RegistrationStatusStrip);

            RegistrationStatusLabel = RegistrationStatusStrip.Items["RegistrationStatusLabel"] as ToolStripStatusLabel;
            Assert.NotNull(RegistrationStatusLabel);
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

        [Fact]
        public void ShouldUpdateStatusWhenNameIsUpdated()
        {
            string inputValue = "TestName";
            NameTextBox.Text = inputValue;

            RegistrationStatusLabel = RegistrationStatusStrip.Items["RegistrationStatusLabel"] as ToolStripStatusLabel;
            String statusText = RegistrationStatusLabel.Text.ToLower();

            Assert.True(statusText.Length > 0, "The proper status text for name text box should be displayed.");
            Assert.True(statusText.Contains("name"), "The status text should contain the word 'name'");
        }

        [Fact]
        public void ShouldUpdateStatusWhenEmailIsUpdated()
        {
            string inputValue = "TestEmail@email.com";
            EmailTextBox.Text = inputValue;

            RegistrationStatusLabel = RegistrationStatusStrip.Items["RegistrationStatusLabel"] as ToolStripStatusLabel;
            String statusText = RegistrationStatusLabel.Text.ToLower();

            Assert.True(statusText.Length > 0, "The proper status text for email text box should be displayed.");
            Assert.True(statusText.Contains("email"), "The status text should contain the word 'email'");
        }

        [Fact]
        public void ShouldUpdateStatusWhenAddressIsUpdated()
        {
            string inputValue = "somewhere";
            AddressTextBox.Text = inputValue;

            RegistrationStatusLabel = RegistrationStatusStrip.Items["RegistrationStatusLabel"] as ToolStripStatusLabel;
            String statusText = RegistrationStatusLabel.Text.ToLower();

            Assert.True(statusText.Length > 0, "The proper status text for email text box should be displayed.");
            Assert.True(statusText.Contains("address"), "The status text should contain the word 'address'");
        }

        [Fact]
        public void ShouldUpdateStatusWhenDatePickerIsUpdated()
        {
            BirthDatePicker.Value = DateTime.Now;

            RegistrationStatusLabel = RegistrationStatusStrip.Items["RegistrationStatusLabel"] as ToolStripStatusLabel;
            String statusText = RegistrationStatusLabel.Text.ToLower();

            Assert.True(statusText.Length > 0, "The proper status text for email text box should be displayed.");
            Assert.True(statusText.Contains("birth date"), "The status text should contain the word 'birth date'");
        }
    }
}