namespace CodeChum.Tests
{
    public class TextDisplayTests
    {
        TextDisplay? form;
        Label? Label;
        TextBox? TextBox;
        Button? DisplayTextButton;

        public TextDisplayTests()
        {
            form = new TextDisplay();
            form.Show();
            Label = (Label)TestUtils.GetControlNamed(form, "Label", true);
            TextBox = (TextBox)TestUtils.GetControlNamed(form, "TextBox", true);
            DisplayTextButton = (Button)TestUtils.GetControlNamed(form, "DisplayTextButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(Label);
            Assert.NotNull(TextBox);
            Assert.NotNull(DisplayTextButton);
        }

        [Fact]
        public void ShouldHaveEmptyDefaultValue()
        {
            Assert.Equal("", Label.Text);
        }

        [Fact]
        public void ShouldDisplayTextBoxTextToLabelOnClickDisplayTextButton()
        {
            string expected = "Hello World!";

            TextBox.Text = expected;
            DisplayTextButton.PerformClick();

            Assert.Equal(expected, Label.Text);
        }
    }
}