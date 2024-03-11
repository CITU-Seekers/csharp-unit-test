namespace CodeChum.Tests
{
    public class StaticWindowsFormTests
    {
        StaticWindowForm? form;
        TabControl? TabControl;
        TabPage? HomeTabPage, RegisterTabPage, AboutTabPage;
        Label? CompanyNameLabel, SloganLabel, AboutLabel;
        TextBox? NameTextBox, EmailTextBox, PasswordTextBox;
        Button? RegisterButton;

        public StaticWindowsFormTests()
        {
            form = new StaticWindowForm();
            TabControl = (TabControl)TestUtils.GetControlNamed(form, "TabControl", true);
            HomeTabPage = (TabPage)TestUtils.GetControlNamed(TabControl, "HomeTabPage", true);
            RegisterTabPage = (TabPage)TestUtils.GetControlNamed(TabControl, "RegisterTabPage", true);
            AboutTabPage = (TabPage)TestUtils.GetControlNamed(TabControl, "AboutTabPage", true);
            CompanyNameLabel = (Label)TestUtils.GetControlNamed(HomeTabPage, "CompanyNameLabel", true);
            SloganLabel = (Label)TestUtils.GetControlNamed(HomeTabPage, "SloganLabel", true);
            AboutLabel = (Label)TestUtils.GetControlNamed(AboutTabPage, "AboutLabel", true);
            NameTextBox = (TextBox)TestUtils.GetControlNamed(RegisterTabPage, "NameTextBox", true);
            EmailTextBox = (TextBox)TestUtils.GetControlNamed(RegisterTabPage, "EmailTextBox", true);
            PasswordTextBox = (TextBox)TestUtils.GetControlNamed(RegisterTabPage, "PasswordTextBox", true);
            RegisterButton = (Button)TestUtils.GetControlNamed(RegisterTabPage, "RegisterButton", true);
        }

        [Fact]
        public void ShouldHaveTabControlAndAllItsPages()
        {
            Assert.NotNull(TabControl);
            Assert.NotNull(HomeTabPage);
            Assert.NotNull(RegisterTabPage);
            Assert.NotNull(AboutTabPage);
        }

        [Fact]
        public void ShouldHaveAllControlsInHomeTabPage()
        {
            Assert.NotNull(CompanyNameLabel);
            Assert.NotNull(SloganLabel);
        }

        [Fact]
        public void ShouldHaveAllControlsInRegisterTabPage()
        {
            Assert.NotNull(NameTextBox);
            Assert.NotNull(EmailTextBox);
            Assert.NotNull(PasswordTextBox);
            Assert.NotNull(RegisterButton);
        }

        [Fact]
        public void ShouldHaveAllControlsInAboutTabPage()
        {
            Assert.NotNull(AboutLabel);
        }

        [Fact]
        public void ShouldHaveCorrectLabelContentsInHomePage()
        {
            string expectedHome = "Company X";

            Assert.Equal(expectedHome, CompanyNameLabel.Text);
            Assert.True(SloganLabel.Text.Length > 0, "There should be a slogan.");
        }

        [Fact]
        public void ShouldHaveCorrectLabelContentsInAboutPage()
        {
            string expectedAbout = "Company X is a company dedicated in helping " +
                "our clients be connected.";

            Assert.Equal(expectedAbout, AboutLabel.Text);
        }
    }
}