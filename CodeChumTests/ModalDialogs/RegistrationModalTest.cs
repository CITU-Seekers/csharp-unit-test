namespace CodeChum.Tests
{
    public class RegistrationModalTests
    {
        RegistrationFormApp? form;
        RegistrationModal? modal;
        Label? NameLabel, EmailLabel;
        TextBox? NameTextBox, EmailTextBox;
        Button? OpenRegistrationModalButton, RegisterButton, CancelButton;

        public RegistrationModalTests()
        {
            form = new RegistrationFormApp();
            form.Show();
            NameLabel = (Label)TestUtils.GetControlNamed(form, "NameLabel", true);
            EmailLabel = (Label)TestUtils.GetControlNamed(form, "EmailLabel", true);
            OpenRegistrationModalButton = (Button)TestUtils.GetControlNamed(form, "OpenRegistrationModalButton", true);
        }

        [Fact]
        public void ShouldHaveAllControlsForRegistrationFormApp()
        {
            Assert.NotNull(NameLabel);
            Assert.NotNull(EmailLabel);
            Assert.NotNull(OpenRegistrationModalButton);
            Assert.NotNull(form.RegisterModal);
        }

        [Fact]
        public void ShouldHaveAllControlsForRegistrationModal()
        {
            modal = new RegistrationModal();
            modal.Show();
            NameTextBox = (TextBox)TestUtils.GetControlNamed(modal, "NameTextBox", true);
            EmailTextBox = (TextBox)TestUtils.GetControlNamed(modal, "EmailTextBox", true);
            RegisterButton = (Button)TestUtils.GetControlNamed(modal, "RegisterButton", true);
            CancelButton = (Button)TestUtils.GetControlNamed(modal, "CancelButton", true);

            Assert.NotNull(NameTextBox);
            Assert.NotNull(EmailTextBox);
            Assert.NotNull(RegisterButton);
            Assert.NotNull(CancelButton);
        }

        [Fact]
        public void ShouldBeAbleToOpenRegisterModal()
        {
            Boolean isRegisterModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(5));
                isRegisterModalShown = form.RegisterModal.Visible;
                form.RegisterModal.Close();
            });

            OpenRegistrationModalButton.PerformClick();

            registerTask.Wait();

            Assert.True(isRegisterModalShown, "The form should be visible when Register button in the main form is clicked.");
        }

        [Fact]
        public void ShouldBeAbleToCloseRegisterModal()
        {
            Boolean isRegisterModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(5));
                CancelButton = (Button)TestUtils.GetControlNamed(form.RegisterModal, "CancelButton", true);

                CancelButton.PerformClick();
                await Task.Delay(TimeSpan.FromSeconds(3));

                isRegisterModalShown = form.RegisterModal.Visible;
            });

            OpenRegistrationModalButton.PerformClick();

            registerTask.Wait();

            Assert.False(isRegisterModalShown, "The form should be closed when Cancel button in the modal form is clicked.");
        }

        [Fact]
        public void ShouldBeAbleToRegisterInModalOnRegisterClick()
        {
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(5));
                NameTextBox = (TextBox)TestUtils.GetControlNamed(form.RegisterModal, "NameTextBox", true);
                EmailTextBox = (TextBox)TestUtils.GetControlNamed(form.RegisterModal, "EmailTextBox", true);
                RegisterButton = (Button)TestUtils.GetControlNamed(form.RegisterModal, "RegisterButton", true);

                NameTextBox.Text = "John Doe";
                EmailTextBox.Text = "johndoe@email.com";
                RegisterButton.PerformClick();
            });

            OpenRegistrationModalButton.PerformClick();

            registerTask.Wait();

            Assert.Equal(NameTextBox.Text, NameLabel.Text);
            Assert.Equal(EmailTextBox.Text, EmailLabel.Text);
        }
    }
}