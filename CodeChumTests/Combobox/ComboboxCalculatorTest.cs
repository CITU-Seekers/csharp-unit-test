namespace CodeChum.Tests
{
    public class ComboBoxCalculatorTests
    {
        ComboBoxCalculator? form;
        TextBox? number1TextBox, number2TextBox;
        ComboBox? operationsComboBox;
        Button? computeButton;
        Label? resultLabel;

        public ComboBoxCalculatorTests()
        {
            form = new ComboBoxCalculator();
            form.Show();
            number1TextBox = (TextBox)TestUtils.GetControlNamed(form, "number1TextBox", true);
            number2TextBox = (TextBox)TestUtils.GetControlNamed(form, "number2TextBox", true);
            operationsComboBox = (ComboBox)TestUtils.GetControlNamed(form, "operationsComboBox", true);
            computeButton = (Button)TestUtils.GetControlNamed(form, "computeButton", true);
            resultLabel = (Label)TestUtils.GetControlNamed(form, "resultLabel", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(number1TextBox);
            Assert.NotNull(number2TextBox);
            Assert.NotNull(operationsComboBox);
            Assert.NotNull(computeButton);
            Assert.NotNull(resultLabel);
        }

        [Fact]
        public void ShouldHaveAllOperationsInstructed()
        {
            Assert.True(operationsComboBox.Items.Contains("+"));
            Assert.True(operationsComboBox.Items.Contains("-"));
            Assert.True(operationsComboBox.Items.Contains("*"));
            Assert.True(operationsComboBox.Items.Contains("/"));
        }

        [Fact]
        public void ShouldComputeCorrectlyOnAdd()
        {
            double number1 = 10;
            double number2 = 20;
            string total = (number1 + number2).ToString("F");
            number1TextBox.Text = number1.ToString();
            number2TextBox.Text = number2.ToString();
            operationsComboBox.SelectedIndex = operationsComboBox.Items.IndexOf("+");

            computeButton.PerformClick();

            Assert.Equal(total, resultLabel.Text);
        }

        [Fact]
        public void ShouldComputeCorrectlyOnSubtract()
        {
            double number1 = 10;
            double number2 = 20;
            string total = (number1 - number2).ToString("F");
            number1TextBox.Text = number1.ToString();
            number2TextBox.Text = number2.ToString();
            operationsComboBox.SelectedIndex = operationsComboBox.Items.IndexOf("-");

            computeButton.PerformClick();

            Assert.Equal(total, resultLabel.Text);
        }

        [Fact]
        public void ShouldComputeCorrectlyOnMultiply()
        {
            double number1 = 10;
            double number2 = 20;
            string total = (number1 * number2).ToString("F");
            number1TextBox.Text = number1.ToString();
            number2TextBox.Text = number2.ToString();
            operationsComboBox.SelectedIndex = operationsComboBox.Items.IndexOf("*");

            computeButton.PerformClick();

            Assert.Equal(total, resultLabel.Text);
        }

        [Fact]
        public void ShouldComputeCorrectlyOnDivide()
        {
            double number1 = 10;
            double number2 = 20;
            string total = (number1 / number2).ToString("F");
            number1TextBox.Text = number1.ToString();
            number2TextBox.Text = number2.ToString();
            operationsComboBox.SelectedIndex = operationsComboBox.Items.IndexOf("/");

            computeButton.PerformClick();

            Assert.Equal(total, resultLabel.Text);
        }
    }
}