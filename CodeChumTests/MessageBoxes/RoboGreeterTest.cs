namespace CodeChum.Tests
{
    public class RoboGreeterTest
    {
        RoboGreeter? form;
        TextBox? greeterNameTextBox;
        Button? greetButton;
        Button? farewellButton;

        public RoboGreeterTest()
        {
            form = new RoboGreeter();
            form.Show();
            greeterNameTextBox = (TextBox)TestUtils.GetControlNamed(form, "greeterNameTextBox", true);
            greetButton = (Button)TestUtils.GetControlNamed(form, "greetButton", true);
            farewellButton = (Button)TestUtils.GetControlNamed(form, "farewellButton", true);
        }

        [Fact]
        // Description: Should have all controls `greeterNameTextBox`, `greetButton`, and `farewellButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(greeterNameTextBox);
            Assert.NotNull(greetButton);
            Assert.NotNull(farewellButton);
        }

        [Fact]
        // Description: Should display message "Hello, Robo! Welcome to CodeVille!" in a message box when greeterNameTextBox is "Robo" and `greetButton` is clicked.
        public void ShouldDisplayMessageWhenGreetButtonClick()
        {
            greeterNameTextBox.Text = "Robo";

            greetButton.PerformClick();
            MessageBoxWrapper.CloseMessageBox();

            Assert.True(MessageBoxWrapper.IsOpened);
            Assert.Equal("Hello, Robo! Welcome to CodeVille!", MessageBoxWrapper.Message);
        }
        
        [Fact]
        // Description: Should display message "Goodbye! Come back soon to CodeVille." in a message box when `farewellButton` is clicked.
        public void ShouldDisplayMessageWhenFarewellButtonClick()
        {
            farewellButton.PerformClick();
            MessageBoxWrapper.CloseMessageBox();

            Assert.Equal("Goodbye! Come back soon to CodeVille.", MessageBoxWrapper.Message);
        }
    }
}
