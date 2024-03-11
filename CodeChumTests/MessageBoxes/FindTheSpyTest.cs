namespace CodeChum.Tests
{
    public class FindTheSpyTests
    {
        FindTheSpy? form;
        Button? FirstButton, SecondButton, ThirdButton, FourthButton, FifthButton,
            SixthButton, SeventhButton, EighthButton, NinthButton, TenthButton;
        Button[] buttons;

        public FindTheSpyTests()
        {
            form = new FindTheSpy();
            form.Show();
            FirstButton = (Button)TestUtils.GetControlNamed(form, "FirstButton", true);
            SecondButton = (Button)TestUtils.GetControlNamed(form, "SecondButton", true);
            ThirdButton = (Button)TestUtils.GetControlNamed(form, "ThirdButton", true);
            FourthButton = (Button)TestUtils.GetControlNamed(form, "FourthButton", true);
            FifthButton = (Button)TestUtils.GetControlNamed(form, "FifthButton", true);
            SixthButton = (Button)TestUtils.GetControlNamed(form, "SixthButton", true);
            SeventhButton = (Button)TestUtils.GetControlNamed(form, "SeventhButton", true);
            EighthButton = (Button)TestUtils.GetControlNamed(form, "EighthButton", true);
            NinthButton = (Button)TestUtils.GetControlNamed(form, "NinthButton", true);
            TenthButton = (Button)TestUtils.GetControlNamed(form, "TenthButton", true);
            buttons = new Button[] {
                FirstButton, SecondButton, ThirdButton, FourthButton, FifthButton,
                SixthButton, SeventhButton, EighthButton, NinthButton, TenthButton
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