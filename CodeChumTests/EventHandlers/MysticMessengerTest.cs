namespace CodeChum.Tests
{
    public class MysticMessengerTest
    {
        MysticMessenger? form;
        TextBox? messageTextBox;
        Label? messageLabel;
        Button? windButton;
        Button? moonglowButton;
        Button? twilightButton;

        public MysticMessengerTest()
        {
            form = new MysticMessenger();
            form.Visible = true;
            messageTextBox = (TextBox)TestUtils.GetControlNamed(form, "messageTextBox", true);
            messageLabel = (Label)TestUtils.GetControlNamed(form, "messageLabel", true);
            windButton = (Button)TestUtils.GetControlNamed(form, "windButton", true);
            moonglowButton = (Button)TestUtils.GetControlNamed(form, "moonglowButton", true);
            twilightButton = (Button)TestUtils.GetControlNamed(form, "twilightButton", true);
        }

        [Fact]
        // Description: Should have all controls `messageTextBox`, `messageLabel`, `windButton`, `moonglowButton`, and `twilightButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(messageTextBox);
            Assert.NotNull(messageLabel);
            Assert.NotNull(windButton);
            Assert.NotNull(moonglowButton);
            Assert.NotNull(twilightButton);
        }

        [Fact]
        // Description: Should reverse the message "Hello" in `messageTextBox` to "olleH" in `messageLabel` when `windButton` is clicked.
        public void ShouldReverseMessage()
        {
            messageTextBox.Text = "Hello";
            windButton.PerformClick();
            Assert.Equal("olleH", messageLabel.Text);
        }

        [Fact]
        // Description: Should translate the vowels in the message "Hello" in `messageTextBox` to "0ll3H" in `messageLabel` when `windButton` is clicked then `moonglowButton` is clicked.
        public void ShouldTranslateTheVowels()
        {
            messageTextBox.Text = "Hello";
            windButton.PerformClick();
            moonglowButton.PerformClick();
            Assert.Equal("0ll3H", messageLabel.Text);
        }

        [Fact]
        // Description: Should translate the message "Hello" in `messageTextBox` to "0LL3H" in `messageLabel` when `windButton`, `moonglowButton`, and `twilightButton` are clicked.
        public void ShouldTranslateToUppercaseMessage ()
        {
            messageTextBox.Text = "Hello";
            windButton.PerformClick();
            moonglowButton.PerformClick();
            twilightButton.PerformClick();
            Assert.Equal("0LL3H", messageLabel.Text);
        }

        [Fact]
        // Description: Should translate the message in `messageTextBox` properly in `messageLabel` when all buttons are clicked.
        public void ShouldTranslateProperlyWhenButtonsAreAllClicked ()
        {
            messageTextBox.Text = "test";
            windButton.PerformClick();
            moonglowButton.PerformClick();
            twilightButton.PerformClick();
            Assert.Equal("TS3T", messageLabel.Text);
        }
    }
}
