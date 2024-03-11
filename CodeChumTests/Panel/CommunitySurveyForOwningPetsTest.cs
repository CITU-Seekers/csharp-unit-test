namespace CodeChum.Tests
{
    public class CommunitySurveyForOwningPetsTests
    {
        CommunitySurveyForOwningPets? form;
        Panel? RespondentPanel, PetDetailsPanel;
        TextBox? RespondentNameTextBox, PetNameTextBox, PetTypeTextBox;
        RadioButton? YesRadioButton, NoRadioButton;
        NumericUpDown? HappyLevelsNumericControl;
        Button? SubmitButton;

        public CommunitySurveyForOwningPetsTests()
        {
            form = new CommunitySurveyForOwningPets();
            form.Show();
            RespondentPanel = (Panel)TestUtils.GetControlNamed(form, "RespondentPanel", true);
            PetDetailsPanel = (Panel)TestUtils.GetControlNamed(form, "PetDetailsPanel", true);
            RespondentNameTextBox = (TextBox)TestUtils.GetControlNamed(RespondentPanel, "RespondentNameTextBox", true);
            PetNameTextBox = (TextBox)TestUtils.GetControlNamed(PetDetailsPanel, "PetNameTextBox", true);
            PetTypeTextBox = (TextBox)TestUtils.GetControlNamed(PetDetailsPanel, "PetTypeTextBox", true);
            YesRadioButton = (RadioButton)TestUtils.GetControlNamed(RespondentPanel, "YesRadioButton", true);
            NoRadioButton = (RadioButton)TestUtils.GetControlNamed(RespondentPanel, "NoRadioButton", true);
            HappyLevelsNumericControl = (NumericUpDown)TestUtils.GetControlNamed(PetDetailsPanel, "HappyLevelsNumericControl", true);
            SubmitButton = (Button)TestUtils.GetControlNamed(form, "SubmitButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(RespondentPanel);
            Assert.NotNull(PetDetailsPanel);
            Assert.NotNull(RespondentNameTextBox);
            Assert.NotNull(PetNameTextBox);
            Assert.NotNull(PetTypeTextBox);
            Assert.NotNull(YesRadioButton);
            Assert.NotNull(NoRadioButton);
            Assert.NotNull(HappyLevelsNumericControl);
            Assert.NotNull(SubmitButton);
        }

        [Fact]
        public void ShouldOnlyShowPetDetailsPanelOnYesRadioButton()
        {
            bool beforeState = PetDetailsPanel.Visible;

            YesRadioButton.Checked = true;

            Assert.False(beforeState);
            Assert.True(PetDetailsPanel.Visible);
        }

        [Fact]
        public void ShouldDisableButtonOnEmptyTextBox()
        {
            Assert.False(SubmitButton.Enabled, "The submit button should be disabled.");
        }

        [Fact]
        public void ShouldEnableButtonOnFilledTextBoxNoPet()
        {
            string test = "Test";

            RespondentNameTextBox.Text = test;
            NoRadioButton.Checked = true;

            Assert.True(SubmitButton.Enabled, "The submit button should be enabled.");
        }

        [Fact]
        public void ShouldDisableButtonOnEmptyTextBoxOnPetPanel()
        {
            string test = "Test";

            RespondentNameTextBox.Text = test;
            YesRadioButton.Checked = true;

            Assert.False(SubmitButton.Enabled, "The submit button should be disabled.");
        }

        [Fact]
        public void ShouldHaveCorrectMinAndMaxHappyLevels()
        {
            Assert.Equal(1, HappyLevelsNumericControl.Minimum);
            Assert.Equal(5, HappyLevelsNumericControl.Maximum);
        }

        [Fact]
        public void ShouldEnableButtonOnFilledTextBoxYesPet()
        {
            string test = "Test";

            RespondentNameTextBox.Text = test;
            YesRadioButton.Checked = true;
            PetNameTextBox.Text = test;
            PetTypeTextBox.Text = test;
            HappyLevelsNumericControl.Value = 4;

            Assert.True(SubmitButton.Enabled, "The submit button should be enabled.");
        }

        [Fact]
        public void ShouldShowMessageBoxOnClickSubmit()
        {
            string test = "Test";

            RespondentNameTextBox.Text = test;
            NoRadioButton.Checked = true;
            SubmitButton.PerformClick();

            Assert.True(MessageBoxWrapper.IsOpened, "The message box should be opened.");
        }
    }
}