namespace CodeChum.Tests
{
    public class RegistrationModalTests
    {
        RegistrationFormApp? form;
        RegistrationModal? modal;
        Label? nameLabel, emailLabel;
        TextBox? nameTextBox, emailTextBox;
        Button? openRegistrationModalButton, registerButton, cancelButton;

        public RegistrationModalTests()
        {
            form = new RegistrationFormApp();
            form.Show();
            nameLabel = (Label)TestUtils.GetControlNamed(form, "nameLabel", true);
            emailLabel = (Label)TestUtils.GetControlNamed(form, "emailLabel", true);
            openRegistrationModalButton = (Button)TestUtils.GetControlNamed(form, "openRegistrationModalButton", true);
        }

        [Fact]
        // Description: Should have all the controls for the main form app `nameLabel`, `emailLabel`, `openRegistrationModalButton`, and `form.RegisterModal`.
        public void ShouldHaveAllControlsForRegistrationFormApp()
        {
            Assert.NotNull(nameLabel);
            Assert.NotNull(emailLabel);
            Assert.NotNull(openRegistrationModalButton);
            Assert.NotNull(form.RegisterModal);
        }

        [Fact]
        // Description: Should have all the controls for the register modal `nameTextBox`, `emailTextBox`, `registerButton`, and `cancelButton`.
        public void ShouldHaveAllControlsForRegistrationModal()
        {
            modal = new RegistrationModal();
            modal.Show();
            nameTextBox = (TextBox)TestUtils.GetControlNamed(modal, "nameTextBox", true);
            emailTextBox = (TextBox)TestUtils.GetControlNamed(modal, "emailTextBox", true);
            registerButton = (Button)TestUtils.GetControlNamed(modal, "registerButton", true);
            cancelButton = (Button)TestUtils.GetControlNamed(modal, "cancelButton", true);

            Assert.NotNull(nameTextBox);
            Assert.NotNull(emailTextBox);
            Assert.NotNull(registerButton);
            Assert.NotNull(cancelButton);
        }

        [Fact]
        // Description: Should open the register modal when the `openRegistrationModalButton` is clicked.
        public void ShouldBeAbleToOpenRegisterModal()
        {
            Boolean isRegisterModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(5));
                isRegisterModalShown = form.RegisterModal.Visible;
                form.RegisterModal.Close();
            });

            openRegistrationModalButton.PerformClick();

            registerTask.Wait();

            Assert.True(isRegisterModalShown, "The form should be visible when Register button in the main form is clicked.");
        }

        [Fact]
        // Description: Should close the register modal when the `cancelButton` is clicked.
        public void ShouldBeAbleToCloseRegisterModal()
        {
            Boolean isRegisterModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(5));
                cancelButton = (Button)TestUtils.GetControlNamed(form.RegisterModal, "cancelButton", true);

                cancelButton.PerformClick();
                await Task.Delay(TimeSpan.FromSeconds(3));

                isRegisterModalShown = form.RegisterModal.Visible;
            });

            openRegistrationModalButton.PerformClick();

            registerTask.Wait();

            Assert.False(isRegisterModalShown, "The form should be closed when Cancel button in the modal form is clicked.");
        }

        [Fact]
        // Description: Should display the name and email from the regsiter modal in `nameLabel` and `emailLabel` of the main form when the `registerButton` is clicked.
        public void ShouldBeAbleToRegisterInModalOnRegisterClick()
        {
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(5));
                nameTextBox = (TextBox)TestUtils.GetControlNamed(form.RegisterModal, "nameTextBox", true);
                emailTextBox = (TextBox)TestUtils.GetControlNamed(form.RegisterModal, "emailTextBox", true);
                registerButton = (Button)TestUtils.GetControlNamed(form.RegisterModal, "registerButton", true);

                nameTextBox.Text = "John Doe";
                emailTextBox.Text = "johndoe@email.com";
                registerButton.PerformClick();
            });

            openRegistrationModalButton.PerformClick();

            registerTask.Wait();

            Assert.Equal(nameTextBox.Text, nameLabel.Text);
            Assert.Equal(emailTextBox.Text, emailLabel.Text);
        }
    }
}