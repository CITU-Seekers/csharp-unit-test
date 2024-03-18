namespace CodeChum.Tests
{
    public class PetDetectiveAgencyTest
    {
        PetDetectiveAgency? form;
        TextBox? petNameTextBox, petTypeTextBox, cluesTextBox, statementsTextBox;
        Button? createButton;
        TabControl? mainTabControl;

        public PetDetectiveAgencyTest()
        {
            form = new PetDetectiveAgency();
            form.Show();
            petNameTextBox = (TextBox)TestUtils.GetControlNamed(form, "petNameTextBox", true);
            petTypeTextBox = (TextBox)TestUtils.GetControlNamed(form, "petTypeTextBox", true);
            cluesTextBox = (TextBox)TestUtils.GetControlNamed(form, "cluesTextBox", true);
            statementsTextBox = (TextBox)TestUtils.GetControlNamed(form, "statementsTextBox", true);
            createButton = (Button)TestUtils.GetControlNamed(form, "createButton", true);
            mainTabControl = (TabControl)TestUtils.GetControlNamed(form, "mainTabControl", true);
        }

        [Fact]
        // Description: Should have all the controls `petNameTextBox`, `petTypeTextBox`, `cluesTextBox`, `statementsTextBox`, `createButton`, and `mainTabControl`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(petNameTextBox);
            Assert.NotNull(petTypeTextBox);
            Assert.NotNull(cluesTextBox);
            Assert.NotNull(statementsTextBox);
            Assert.NotNull(createButton);
            Assert.NotNull(mainTabControl);
        }

        [Fact]
        // Description: Should create a new tab with all the information when the `createButton` is clicked.
        public void ShouldCreateNewTabWithAllInformation()
        {
            petNameTextBox.Text = "Test";
            petTypeTextBox.Text = "Test";
            cluesTextBox.Text = "Test";
            statementsTextBox.Text = "Test";
            createButton.PerformClick();

            Assert.Equal(2, mainTabControl.TabCount);
            Assert.Equal("Test", mainTabControl.TabPages[1].Text);
            Assert.NotNull((Label)TestUtils.GetControlNamed(mainTabControl.TabPages[1], "petNameLabel", true));
            Assert.NotNull((Label)TestUtils.GetControlNamed(mainTabControl.TabPages[1], "petTypeLabel", true));
            Assert.NotNull((Label)TestUtils.GetControlNamed(mainTabControl.TabPages[1], "cluesLabel", true));
            Assert.NotNull((Label)TestUtils.GetControlNamed(mainTabControl.TabPages[1], "statementsLabel", true));
        }

        [Fact]
        // Description: Should close the tab when the `caseSolvedButton` is clicked.
        public void ShouldCloseTabUsingCaseSolvedButton()
        {
            petNameTextBox.Text = "Test";
            petTypeTextBox.Text = "Test";
            cluesTextBox.Text = "Test";
            statementsTextBox.Text = "Test";
            createButton.PerformClick();

            Assert.Equal(2, mainTabControl.TabCount);
            Assert.Equal("Test", mainTabControl.TabPages[1].Text);

            //Navigate to the new tab
            mainTabControl.SelectedIndex = 1;
            Button caseSolvedButton = (Button)TestUtils.GetControlNamed(mainTabControl.TabPages[1], "caseSolvedButton", true);
            caseSolvedButton.PerformClick();

            Task.Delay(TimeSpan.FromSeconds(3)).Wait();
            Assert.Equal(1, mainTabControl.TabCount);
        }


    }
}
