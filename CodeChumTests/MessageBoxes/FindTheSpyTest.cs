namespace CodeChum.Tests
{
    public class FindTheSpyTests
    {
        FindTheSpy? form;
        Button? firstButton, secondButton, thirdButton, fourthButton, fifthButton,
            sixthButton, seventhButton, eighthButton, ninthButton, tenthButton;
        Button[] buttons;

        public FindTheSpyTests()
        {
            form = new FindTheSpy();
            form.Show();
            firstButton = (Button)TestUtils.GetControlNamed(form, "firstButton", true);
            secondButton = (Button)TestUtils.GetControlNamed(form, "secondButton", true);
            thirdButton = (Button)TestUtils.GetControlNamed(form, "thirdButton", true);
            fourthButton = (Button)TestUtils.GetControlNamed(form, "fourthButton", true);
            fifthButton = (Button)TestUtils.GetControlNamed(form, "fifthButton", true);
            sixthButton = (Button)TestUtils.GetControlNamed(form, "sixthButton", true);
            seventhButton = (Button)TestUtils.GetControlNamed(form, "seventhButton", true);
            eighthButton = (Button)TestUtils.GetControlNamed(form, "eighthButton", true);
            ninthButton = (Button)TestUtils.GetControlNamed(form, "ninthButton", true);
            tenthButton = (Button)TestUtils.GetControlNamed(form, "tenthButton", true);
            buttons = new Button[] {
                firstButton, secondButton, thirdButton, fourthButton, fifthButton,
                sixthButton, seventhButton, eighthButton, ninthButton, tenthButton
            };
        }

        public bool IsSpyNumber(int number)
        {
            int sum = 0;
            int product = 1;

            while (number != 0)
            {
                sum += number % 10;
                product *= number % 10;
                number /= 10;
            }

            return sum == product;
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            foreach (Button btn in buttons)
            {
                Assert.NotNull(btn);
            }
        }

        [Fact]
        public async void ShouldShowMessageDialogOnSpy()
        {
            foreach (Button btn in buttons)
            {
                btn.PerformClick();

                if (IsSpyNumber(Convert.ToInt32(btn.Text)))
                {
                    Assert.True(MessageBoxWrapper.IsOpened, $"The Message Box should open on button with text of {btn.Text}.");
                    Assert.Equal("Spy found!", MessageBoxWrapper.Message);
                }
                else
                {
                    Assert.False(MessageBoxWrapper.IsOpened, $"The Message Box should not open on button with text of {btn.Text}.");
                }

                MessageBoxWrapper.IsOpened = false;
            }
        }
    }
}