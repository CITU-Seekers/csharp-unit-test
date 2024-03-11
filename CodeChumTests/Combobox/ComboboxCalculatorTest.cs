namespace CodeChum.Tests
{
    public class ComboBoxCalculatorTests
    {
        ComboBoxCalculator? form;
        TextBox? TextNumber1, TextNumber2;
        ComboBox? OperationsComboBox;
        Button? ComputeButton;
        Label? ResultLabel;

        public ComboBoxCalculatorTests()
        {
            form = new ComboBoxCalculator();
            form.Show();
            TextNumber1 = (TextBox)TestUtils.GetControlNamed(form, "TextNumber1", true);
            TextNumber2 = (TextBox)TestUtils.GetControlNamed(form, "TextNumber2", true);
            OperationsComboBox = (ComboBox)TestUtils.GetControlNamed(form, "OperationsComboBox", true);
            ComputeButton = (Button)TestUtils.GetControlNamed(form, "ComputeButton", true);
            ResultLabel = (Label)TestUtils.GetControlNamed(form, "ResultLabel", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(TextNumber1);
            Assert.NotNull(TextNumber2);
            Assert.NotNull(OperationsComboBox);
            Assert.NotNull(ComputeButton);
            Assert.NotNull(ResultLabel);
        }

        [Fact]
        public void ShouldHaveAllOperationsInstructed()
        {
            Assert.True(OperationsComboBox.Items.Contains("+"));
            Assert.True(OperationsComboBox.Items.Contains("-"));
            Assert.True(OperationsComboBox.Items.Contains("*"));
            Assert.True(OperationsComboBox.Items.Contains("/"));
        }

        [Fact]
        public void ShouldComputeCorrectlyOnAdd()
        {
            double number1 = 10;
            double number2 = 20;
            string total = (number1 + number2).ToString("F");
            TextNumber1.Text = number1.ToString();
            TextNumber2.Text = number2.ToString();
            OperationsComboBox.SelectedIndex = OperationsComboBox.Items.IndexOf("+");

            ComputeButton.PerformClick();

            Assert.Equal(total, ResultLabel.Text);
        }

        [Fact]
        public void ShouldComputeCorrectlyOnSubtract()
        {
            double number1 = 10;
            double number2 = 20;
            string total = (number1 - number2).ToString("F");
            TextNumber1.Text = number1.ToString();
            TextNumber2.Text = number2.ToString();
            OperationsComboBox.SelectedIndex = OperationsComboBox.Items.IndexOf("-");

            ComputeButton.PerformClick();

            Assert.Equal(total, ResultLabel.Text);
        }

        [Fact]
        public void ShouldComputeCorrectlyOnMultiply()
        {
            double number1 = 10;
            double number2 = 20;
            string total = (number1 * number2).ToString("F");
            TextNumber1.Text = number1.ToString();
            TextNumber2.Text = number2.ToString();
            OperationsComboBox.SelectedIndex = OperationsComboBox.Items.IndexOf("*");

            ComputeButton.PerformClick();

            Assert.Equal(total, ResultLabel.Text);
        }

        [Fact]
        public void ShouldComputeCorrectlyOnDivide()
        {
            double number1 = 10;
            double number2 = 20;
            string total = (number1 / number2).ToString("F");
            TextNumber1.Text = number1.ToString();
            TextNumber2.Text = number2.ToString();
            OperationsComboBox.SelectedIndex = OperationsComboBox.Items.IndexOf("/");

            ComputeButton.PerformClick();

            Assert.Equal(total, ResultLabel.Text);
        }
    }
}