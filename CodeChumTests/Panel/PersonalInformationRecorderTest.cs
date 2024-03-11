namespace CodeChum.Tests
{
    public class MultipagePersonalInformationRecorderTests
    {
        PersonalInformationRecorder? form;
        Panel? FirstPanel, SecondPanel, ThirdPanel;
        TextBox? NameTextBox, AgeTextBox;
        Label? NameLabel, AgeLabel;
        RichTextBox? QuoteRichTextBox, QuoteDisplayRichTextBox;
        Button? PrevButton, NextButton;

        public MultipagePersonalInformationRecorderTests()
        {
            form = new PersonalInformationRecorder();
            form.Show();
            FirstPanel = (Panel)TestUtils.GetControlNamed(form, "FirstPanel", true);
            SecondPanel = (Panel)TestUtils.GetControlNamed(form, "SecondPanel", true);
            ThirdPanel = (Panel)TestUtils.GetControlNamed(form, "ThirdPanel", true);
            NameTextBox = (TextBox)TestUtils.GetControlNamed(FirstPanel, "NameTextBox", true);
            AgeTextBox = (TextBox)TestUtils.GetControlNamed(FirstPanel, "AgeTextBox", true);
            NameLabel = (Label)TestUtils.GetControlNamed(ThirdPanel, "NameLabel", true);
            AgeLabel = (Label)TestUtils.GetControlNamed(ThirdPanel, "AgeLabel", true);
            QuoteRichTextBox = (RichTextBox)TestUtils.GetControlNamed(SecondPanel, "QuoteRichTextBox", true);
            QuoteDisplayRichTextBox = (RichTextBox)TestUtils.GetControlNamed(ThirdPanel, "QuoteDisplayRichTextBox", true);
            PrevButton = (Button)TestUtils.GetControlNamed(form, "PrevButton", true);
            NextButton = (Button)TestUtils.GetControlNamed(form, "NextButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(FirstPanel);
            Assert.NotNull(SecondPanel);
            Assert.NotNull(ThirdPanel);
            Assert.NotNull(NameTextBox);
            Assert.NotNull(AgeTextBox);
            Assert.NotNull(NameLabel);
            Assert.NotNull(AgeLabel);
            Assert.NotNull(QuoteRichTextBox);
            Assert.NotNull(QuoteDisplayRichTextBox);
            Assert.NotNull(PrevButton);
            Assert.NotNull(NextButton);
        }

        [Fact]
        public void ShouldHaveProperStartingVisibilityPanelsAndEnabledButtons()
        {
            Assert.True(FirstPanel.Visible);
            Assert.False(SecondPanel.Visible);
            Assert.False(ThirdPanel.Visible);
            Assert.False(PrevButton.Enabled);
        }

        [Fact]
        public void ShouldProperlyEnableDisableButtonsAndDisplayPanels()
        {
            NextButton.PerformClick();
            Assert.True(PrevButton.Enabled);
            Assert.True(NextButton.Enabled);
            Assert.True(SecondPanel.Visible);
            Assert.False(FirstPanel.Visible);
            Assert.False(ThirdPanel.Visible);

            NextButton.PerformClick();
            Assert.True(PrevButton.Enabled);
            Assert.False(NextButton.Enabled);
            Assert.True(ThirdPanel.Visible);
            Assert.False(FirstPanel.Visible);
            Assert.False(SecondPanel.Visible);

            PrevButton.PerformClick();
            Assert.True(PrevButton.Enabled);
            Assert.True(NextButton.Enabled);
            Assert.True(SecondPanel.Visible);
            Assert.False(FirstPanel.Visible);
            Assert.False(ThirdPanel.Visible);

            PrevButton.PerformClick();
            Assert.False(PrevButton.Enabled);
            Assert.True(NextButton.Enabled);
            Assert.True(FirstPanel.Visible);
            Assert.False(SecondPanel.Visible);
            Assert.False(ThirdPanel.Visible);
        }

        [Fact]
        public void ShouldShowTextOnLastPanel()
        {
            NameTextBox.Text = "Test";
            AgeTextBox.Text = "Test";
            NextButton.PerformClick();
            QuoteRichTextBox.Text = "Test";

            NextButton.PerformClick();

            Assert.Equal(NameTextBox.Text, NameLabel.Text);
            Assert.Equal(AgeTextBox.Text, AgeLabel.Text);
            Assert.Equal(QuoteRichTextBox.Text, QuoteDisplayRichTextBox.Text);
        }
    }
}