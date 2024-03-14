namespace CodeChum.Tests
{
    public class StaticWindowsFormTests
    {
        StaticWindowForm? form;
        TabControl? mainTabControl;
        TabPage? homeTabPage, registerTabPage, aboutTabPage;
        Label? companyNameLabel, sloganLabel, aboutLabel;
        TextBox? nameTextBox, emailTextBox, passwordTextBox;
        Button? registerButton;

        public StaticWindowsFormTests()
        {
            form = new StaticWindowForm();
            mainTabControl = (TabControl)TestUtils.GetControlNamed(form, "mainTabControl", true);
            homeTabPage = (TabPage)TestUtils.GetControlNamed(mainTabControl, "homeTabPage", true);
            registerTabPage = (TabPage)TestUtils.GetControlNamed(mainTabControl, "registerTabPage", true);
            aboutTabPage = (TabPage)TestUtils.GetControlNamed(mainTabControl, "aboutTabPage", true);
            companyNameLabel = (Label)TestUtils.GetControlNamed(homeTabPage, "companyNameLabel", true);
            sloganLabel = (Label)TestUtils.GetControlNamed(homeTabPage, "sloganLabel", true);
            aboutLabel = (Label)TestUtils.GetControlNamed(aboutTabPage, "aboutLabel", true);
            nameTextBox = (TextBox)TestUtils.GetControlNamed(registerTabPage, "nameTextBox", true);
            emailTextBox = (TextBox)TestUtils.GetControlNamed(registerTabPage, "emailTextBox", true);
            passwordTextBox = (TextBox)TestUtils.GetControlNamed(registerTabPage, "passwordTextBox", true);
            registerButton = (Button)TestUtils.GetControlNamed(registerTabPage, "registerButton", true);
        }

        [Fact]
        public void ShouldHaveTabControlAndAllItsPages()
        {
            Assert.NotNull(mainTabControl);
            Assert.NotNull(homeTabPage);
            Assert.NotNull(registerTabPage);
            Assert.NotNull(aboutTabPage);
        }

        [Fact]
        public void ShouldHaveAllControlsInHomeTabPage()
        {
            Assert.NotNull(companyNameLabel);
            Assert.NotNull(sloganLabel);
        }

        [Fact]
        public void ShouldHaveAllControlsInRegisterTabPage()
        {
            Assert.NotNull(nameTextBox);
            Assert.NotNull(emailTextBox);
            Assert.NotNull(passwordTextBox);
            Assert.NotNull(registerButton);
        }

        [Fact]
        public void ShouldHaveAllControlsInAboutTabPage()
        {
            Assert.NotNull(aboutLabel);
        }

        [Fact]
        public void ShouldHaveCorrectLabelContentsInHomePage()
        {
            string expectedHome = "Company X";

            Assert.Equal(expectedHome, companyNameLabel.Text);
            Assert.True(sloganLabel.Text.Length > 0, "There should be a slogan.");
        }

        [Fact]
        public void ShouldHaveCorrectLabelContentsInAboutPage()
        {
            string expectedAbout = "Company X is a company dedicated in helping " +
                "our clients be connected.";

            Assert.Equal(expectedAbout, aboutLabel.Text);
        }
    }
}