namespace CodeChum.Tests
{
    public class MessageDecoderTest
    {
        MessageDecoder? form;
        TextBox? encodeTextBox;
        Label? displayMessageLabel;
        Button? decodeButton;

        public MessageDecoderTest()
        {
            form = new MessageDecoder();
            form.Show();

            encodeTextBox = (TextBox) TestUtils.GetControlNamed(form, "encodeTextBox", true);
            displayMessageLabel = (Label) TestUtils.GetControlNamed(form, "displayMessageLabel", true);
            decodeButton = (Button) TestUtils.GetControlNamed(form, "decodeButton", true);
        }

        [Fact]
        // Description: Should have all the controls `encodeTextBox`, `displayMessageLabel`, and `decodeButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(encodeTextBox);
            Assert.NotNull(displayMessageLabel);
            Assert.NotNull(decodeButton);
        }

        [Fact]
        // Description: Should reverse text in `encodeTextBox` and display it in `displayMessageLabel` when the `decodeButton` is clicked.
        public void ShouldReverseText()
        {
            encodeTextBox.Text = "dlrow";
            decodeButton.PerformClick();
            Assert.Equal("world", displayMessageLabel.Text);
        }

        [Fact]
        // Description: Should reverse text with spaces in `encodeTextBox` and display it in `displayMessageLabel` when the `decodeButton` is clicked.
        public void ShouldReverseTextWithSpaces()
        {
            encodeTextBox.Text = "dlrow olleh";
            decodeButton.PerformClick();
            Assert.Equal("hello world", displayMessageLabel.Text);
        }
    }
}
