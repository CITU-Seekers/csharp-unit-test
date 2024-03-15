namespace CodeChum.Tests
{
    public class CommunitySurveyForOwningPetsTests
    {
        CommunitySurveyForOwningPets? form;
        Panel? respondentPanel, petDetailsPanel;
        TextBox? respondentNameTextBox, petNameTextBox, petTypeTextBox;
        RadioButton? yesRadioButton, noRadioButton;
        NumericUpDown? happyLevelsNumericControl;
        Button? submitButton;

        public CommunitySurveyForOwningPetsTests()
        {
            form = new CommunitySurveyForOwningPets();
            form.Show();
            respondentPanel = (Panel)TestUtils.GetControlNamed(form, "respondentPanel", true);
            petDetailsPanel = (Panel)TestUtils.GetControlNamed(form, "petDetailsPanel", true);
            respondentNameTextBox = (TextBox)TestUtils.GetControlNamed(respondentPanel, "respondentNameTextBox", true);
            petNameTextBox = (TextBox)TestUtils.GetControlNamed(petDetailsPanel, "petNameTextBox", true);
            petTypeTextBox = (TextBox)TestUtils.GetControlNamed(petDetailsPanel, "petTypeTextBox", true);
            yesRadioButton = (RadioButton)TestUtils.GetControlNamed(respondentPanel, "yesRadioButton", true);
            noRadioButton = (RadioButton)TestUtils.GetControlNamed(respondentPanel, "noRadioButton", true);
            happyLevelsNumericControl = (NumericUpDown)TestUtils.GetControlNamed(petDetailsPanel, "happyLevelsNumericControl", true);
            submitButton = (Button)TestUtils.GetControlNamed(form, "submitButton", true);
        }

        [Fact]
        // Description: Should have all the controls `respondentPanel`, `petDetailsPanel`, `respondentNameTextBox`, `petNameTextBox`, `petTypeTextBox`, `yesRadioButton`, `noRadioButton`, `happyLevelsNumericControl`, and `submitButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(respondentPanel);
            Assert.NotNull(petDetailsPanel);
            Assert.NotNull(respondentNameTextBox);
            Assert.NotNull(petNameTextBox);
            Assert.NotNull(petTypeTextBox);
            Assert.NotNull(yesRadioButton);
            Assert.NotNull(noRadioButton);
            Assert.NotNull(happyLevelsNumericControl);
            Assert.NotNull(submitButton);
        }

        [Fact]
        // Description: Should only show `petDetailsPanel` when option "Yes" is chosen for owning a pet.
        public void ShouldOnlyShowPetDetailsPanelOnYesRadioButton()
        {
            bool beforeState = petDetailsPanel.Visible;

            yesRadioButton.Checked = true;

            Assert.False(beforeState);
            Assert.True(petDetailsPanel.Visible);
        }

        [Fact]
        // Description: Should disable `submitButton` when pet owner name text box is empty.
        public void ShouldDisableButtonOnEmptyTextBox()
        {
            Assert.False(submitButton.Enabled, "The submit button should be disabled.");
        }

        [Fact]
        // Description: Should enable `submitButton` when pet owner name text box is filled and option "No" is chosen for owning a pet.
        public void ShouldEnableButtonOnFilledTextBoxNoPet()
        {
            string test = "Test";

            respondentNameTextBox.Text = test;
            noRadioButton.Checked = true;

            Assert.True(submitButton.Enabled, "The submit button should be enabled.");
        }

        [Fact]
        // Description: Should disable `submitButton` if at least one text box in the `PetDetailsPanel` is empty.
        public void ShouldDisableButtonOnEmptyTextBoxOnPetPanel()
        {
            string test = "Test";

            respondentNameTextBox.Text = test;
            yesRadioButton.Checked = true;

            Assert.False(submitButton.Enabled, "The submit button should be disabled.");
        }

        [Fact]
        // Description: Should have correct min and max values for `happyLevelsNumericControl`.
        public void ShouldHaveCorrectMinAndMaxHappyLevels()
        {
            Assert.Equal(1, happyLevelsNumericControl.Minimum);
            Assert.Equal(5, happyLevelsNumericControl.Maximum);
        }

        [Fact]
        // Description: Should enable `submitButton` when all text boxes in the `petDetailsPanel` are filled.
        public void ShouldEnableButtonOnFilledTextBoxYesPet()
        {
            string test = "Test";

            respondentNameTextBox.Text = test;
            yesRadioButton.Checked = true;
            petNameTextBox.Text = test;
            petTypeTextBox.Text = test;
            happyLevelsNumericControl.Value = 4;

            Assert.True(submitButton.Enabled, "The submit button should be enabled.");
        }

        [Fact]
        // Description: Should show message box when `submitButton` is clicked.
        public void ShouldShowMessageBoxOnClickSubmit()
        {
            string test = "Test";

            respondentNameTextBox.Text = test;
            noRadioButton.Checked = true;
            submitButton.PerformClick();

            Assert.True(MessageBoxWrapper.IsOpened, "The message box should be opened.");
        }
    }
}