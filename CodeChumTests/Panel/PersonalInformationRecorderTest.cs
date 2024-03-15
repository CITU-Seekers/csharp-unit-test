namespace CodeChum.Tests
{
    public class MultipagePersonalInformationRecorderTests
    {
        PersonalInformationRecorder? form;
        Panel? firstPanel, secondPanel, thirdPanel;
        TextBox? nameTextBox, ageTextBox;
        Label? nameLabel, ageLabel;
        RichTextBox? quoteRichTextBox, quoteDisplayRichTextBox;
        Button? prevButton, nextButton;

        public MultipagePersonalInformationRecorderTests()
        {
            form = new PersonalInformationRecorder();
            form.Show();
            firstPanel = (Panel)TestUtils.GetControlNamed(form, "firstPanel", true);
            secondPanel = (Panel)TestUtils.GetControlNamed(form, "secondPanel", true);
            thirdPanel = (Panel)TestUtils.GetControlNamed(form, "thirdPanel", true);
            nameTextBox = (TextBox)TestUtils.GetControlNamed(firstPanel, "nameTextBox", true);
            ageTextBox = (TextBox)TestUtils.GetControlNamed(firstPanel, "ageTextBox", true);
            nameLabel = (Label)TestUtils.GetControlNamed(thirdPanel, "nameLabel", true);
            ageLabel = (Label)TestUtils.GetControlNamed(thirdPanel, "ageLabel", true);
            quoteRichTextBox = (RichTextBox)TestUtils.GetControlNamed(secondPanel, "quoteRichTextBox", true);
            quoteDisplayRichTextBox = (RichTextBox)TestUtils.GetControlNamed(thirdPanel, "quoteDisplayRichTextBox", true);
            prevButton = (Button)TestUtils.GetControlNamed(form, "prevButton", true);
            nextButton = (Button)TestUtils.GetControlNamed(form, "nextButton", true);
        }

        [Fact]
        // Description: Should have all the controls `firstPanel`, `secondPanel`, `thirdPanel`, `nameTextBox`, `ageTextBox`, `nameLabel`, `ageLabel`, `quoteRichTextBox`, `quoteDisplayRichTextBox`, `prevButton`, and `nextButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(firstPanel);
            Assert.NotNull(secondPanel);
            Assert.NotNull(thirdPanel);
            Assert.NotNull(nameTextBox);
            Assert.NotNull(ageTextBox);
            Assert.NotNull(nameLabel);
            Assert.NotNull(ageLabel);
            Assert.NotNull(quoteRichTextBox);
            Assert.NotNull(quoteDisplayRichTextBox);
            Assert.NotNull(prevButton);
            Assert.NotNull(nextButton);
        }

        [Fact]
        // Description: Should have proper starting visibilities for panels and enabled states for buttons.
        public void ShouldHaveProperStartingVisibilityPanelsAndEnabledButtons()
        {
            Assert.True(firstPanel.Visible);
            Assert.False(secondPanel.Visible);
            Assert.False(thirdPanel.Visible);
            Assert.False(prevButton.Enabled);
        }

        [Fact]
        // Description: Should enable/disable buttons and display panels according to `prevButton` and `nextButton` clicks.
        public void ShouldProperlyEnableDisableButtonsAndDisplayPanels()
        {
            nextButton.PerformClick();
            Assert.True(prevButton.Enabled);
            Assert.True(nextButton.Enabled);
            Assert.True(secondPanel.Visible);
            Assert.False(firstPanel.Visible);
            Assert.False(thirdPanel.Visible);

            nextButton.PerformClick();
            Assert.True(prevButton.Enabled);
            Assert.False(nextButton.Enabled);
            Assert.True(thirdPanel.Visible);
            Assert.False(firstPanel.Visible);
            Assert.False(secondPanel.Visible);

            prevButton.PerformClick();
            Assert.True(prevButton.Enabled);
            Assert.True(nextButton.Enabled);
            Assert.True(secondPanel.Visible);
            Assert.False(firstPanel.Visible);
            Assert.False(thirdPanel.Visible);

            prevButton.PerformClick();
            Assert.False(prevButton.Enabled);
            Assert.True(nextButton.Enabled);
            Assert.True(firstPanel.Visible);
            Assert.False(secondPanel.Visible);
            Assert.False(thirdPanel.Visible);
        }

        [Fact]
        // Description: Should show input values from first and second page to the last page.
        public void ShouldShowTextOnLastPanel()
        {
            nameTextBox.Text = "Test";
            ageTextBox.Text = "Test";
            nextButton.PerformClick();
            quoteRichTextBox.Text = "Test";

            nextButton.PerformClick();

            Assert.Equal(nameTextBox.Text, nameLabel.Text);
            Assert.Equal(ageTextBox.Text, ageLabel.Text);
            Assert.Equal(quoteRichTextBox.Text, quoteDisplayRichTextBox.Text);
        }
    }
}