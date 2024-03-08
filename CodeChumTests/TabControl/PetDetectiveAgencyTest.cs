namespace CodeChum.Tests
{
    public class PetDetectiveAgencyTest
    {
        PetDetectiveAgency? form;
        TextBox? txtPetName, txtPetType, txtClues, txtStatements;
        Button? CreateButton;
        TabControl? MainTabControl;

        public PetDetectiveAgencyTest()
        {
            form = new PetDetectiveAgency();
            form.Show();
            txtPetName = (TextBox)TestUtils.GetControlNamed(form, "txtPetName", true);
            txtPetType = (TextBox)TestUtils.GetControlNamed(form, "txtPetType", true);
            txtClues = (TextBox)TestUtils.GetControlNamed(form, "txtClues", true);
            txtStatements = (TextBox)TestUtils.GetControlNamed(form, "txtStatements", true);
            CreateButton = (Button)TestUtils.GetControlNamed(form, "CreateButton", true);
            MainTabControl = (TabControl)TestUtils.GetControlNamed(form, "MainTabControl", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(txtPetName);
            Assert.NotNull(txtPetType);
            Assert.NotNull(txtClues);
            Assert.NotNull(txtStatements);
            Assert.NotNull(CreateButton);
            Assert.NotNull(MainTabControl);
        }

        [Fact]
        public void ShouldCreateNewTabWithAllInformation()
        {
            txtPetName.Text = "Test";
            txtPetType.Text = "Test";
            txtClues.Text = "Test";
            txtStatements.Text = "Test";
            CreateButton.PerformClick();

            Assert.Equal(2, MainTabControl.TabCount);
            Assert.Equal("Test", MainTabControl.TabPages[1].Text);
            Assert.NotNull((Label)TestUtils.GetControlNamed(MainTabControl.TabPages[1], "PetNameLabel", true));
            Assert.NotNull((Label)TestUtils.GetControlNamed(MainTabControl.TabPages[1], "PetTypeLabel", true));
            Assert.NotNull((Label)TestUtils.GetControlNamed(MainTabControl.TabPages[1], "CluesLabel", true));
            Assert.NotNull((Label)TestUtils.GetControlNamed(MainTabControl.TabPages[1], "StatementsLabel", true));
        }

        [Fact]
        public void ShouldCloseTabUsingCaseSolvedButton()
        {
            txtPetName.Text = "Test";
            txtPetType.Text = "Test";
            txtClues.Text = "Test";
            txtStatements.Text = "Test";
            CreateButton.PerformClick();

            Assert.Equal(2, MainTabControl.TabCount);
            Assert.Equal("Test", MainTabControl.TabPages[1].Text);

            //Navigate to the new tab
            MainTabControl.SelectedIndex = 1;
            Button CaseSolvedButton = (Button)TestUtils.GetControlNamed(MainTabControl.TabPages[1], "CaseSolvedButton", true);
            CaseSolvedButton.PerformClick();

            Task.Delay(TimeSpan.FromSeconds(3)).Wait();
            Assert.Equal(1, MainTabControl.TabCount);
        }


    }
}
