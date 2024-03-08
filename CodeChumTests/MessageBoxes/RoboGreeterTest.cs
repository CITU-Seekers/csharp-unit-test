namespace CodeChum.Tests
{
    public class RoboGreeterTest
    {
        RoboGreeter? form;
        TextBox? greeterName;
        Button? btnGreet;
        Button? btnFarewell;

        public RoboGreeterTest()
        {
            form = new RoboGreeter();
            form.Show();
            greeterName = (TextBox)TestUtils.GetControlNamed(form, "GreeterName", true);
            btnGreet = (Button)TestUtils.GetControlNamed(form, "btnGreet", true);
            btnFarewell = (Button)TestUtils.GetControlNamed(form, "btnFarewell", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(greeterName);
            Assert.NotNull(btnGreet);
            Assert.NotNull(btnFarewell);
        }

        [Fact]
        public void ShouldDisplayMessageWhenGreetButtonClick()
        {
            btnGreet.PerformClick();

            Assert.True(form.isMessageBoxClosed);
        }
        
        [Fact]
        public void ShouldDisplayMessageWhenFarewellButtonClick()
        {
            btnFarewell.PerformClick();

            Assert.True(form.isMessageBoxClosed);
        }
    }
}
