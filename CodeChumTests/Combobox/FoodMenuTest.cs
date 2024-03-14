namespace CodeChum.Tests
{
    public class FoodMenuTest
    {
        FoodMenu? form;
        ComboBox? comboBox1;
        RadioButton? radioButton1;
        RadioButton? radioButton2;
        RadioButton? radioButton3;
        TextBox? textBox1;
        Label? orderSummaryLabel;
        Button? addButton;

        public FoodMenuTest()
        {
            form = new FoodMenu();
            form.Show();
            comboBox1 = (ComboBox)TestUtils.GetControlNamed(form, "comboBox1", true);
            radioButton1 = (RadioButton)TestUtils.GetControlNamed(form, "radioButton1", true);
            radioButton2 = (RadioButton)TestUtils.GetControlNamed(form, "radioButton2", true);
            radioButton3 = (RadioButton)TestUtils.GetControlNamed(form, "radioButton3", true);
            textBox1 = (TextBox)TestUtils.GetControlNamed(form, "textBox1", true);
            orderSummaryLabel = (Label)TestUtils.GetControlNamed(form, "orderSummaryLabel", true);
            addButton = (Button)TestUtils.GetControlNamed(form, "addButton", true);
        }

        [Fact]
        // Description: Should have all controls `comboBox1`, `radioButton1`, `radioButton2`, `radioButton3`, `textBox1`, `orderSummaryLabel`, and `addButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(comboBox1);
            Assert.NotNull(radioButton1);
            Assert.NotNull(radioButton2);
            Assert.NotNull(radioButton3);
            Assert.NotNull(textBox1);
            Assert.NotNull(orderSummaryLabel);
            Assert.NotNull(addButton);
        }

        [Fact]
        // Description: Should have 2 items in `comboBox1` and the items should be "Food" and "Drinks".
        public void ShouldHaveComboBoxItems()
        {
            Assert.Equal(2, comboBox1.Items.Count);
            Assert.Equal("Food", comboBox1.Items[0]);
            Assert.Equal("Drinks", comboBox1.Items[1]);
        }

        [Fact]
        // Description: Should have food items "Burger", "Salad", and "Pizza" when `comboBox1` is set to "Food".
        public void ShouldHaveCorrectFoodItems()
        {
            comboBox1.SelectedIndex = 0;
            Assert.Equal("Food", comboBox1.Text);
            Assert.Equal("Burger", radioButton1.Text);
            Assert.Equal("Salad", radioButton2.Text);
            Assert.Equal("Pizza", radioButton3.Text);
        }

        [Fact]
        // Description: Should have drink items "Soda", "Juice", and "Water" when `comboBox1` is set to "Drinks".
        public void ShouldHaveCorrectDrinkItems()
        {
            comboBox1.SelectedIndex = 1;
            Assert.Equal("Drinks", comboBox1.Text);
            Assert.Equal("Soda", radioButton1.Text);
            Assert.Equal("Juice", radioButton2.Text);
            Assert.Equal("Water", radioButton3.Text);
        }

        [Fact]
        // Description: Should display "Burger x 2" in `orderSummaryLabel` when "Burger" is selected and "2" is entered in `textBox1` and `addButton` is clicked.
        public void ShouldAddFoodItem()
        {
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = true;
            textBox1.Text = "2";
            addButton.PerformClick();
            Assert.Equal("Burger x 2", orderSummaryLabel.Text);
        }

        [Fact]
        // Description: Should display "Juice x 3" in `orderSummaryLabel` when "Juice" is selected and "3" is entered in `textBox1` and `addButton` is clicked.
        public void ShouldAddDrinkItem()
        {
            comboBox1.SelectedIndex = 1;
            radioButton2.Checked = true;
            textBox1.Text = "3";
            addButton.PerformClick();
            Assert.Equal("Juice x 3", orderSummaryLabel.Text);
        }

        [Fact]
        // Description: Should display "Burger x 2" and "Salad x 3" in `orderSummaryLabel` when "Burger" is selected and "2" is entered in `textBox1`, `addButton` is clicked, "Salad" is selected and "3" is entered in `textBox1`, and `addButton` is clicked.
        public void ShouldAddMultipleItems()
        {
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = true;
            textBox1.Text = "2";
            addButton.PerformClick();
            radioButton2.Checked = true;
            textBox1.Text = "3";
            addButton.PerformClick();
            Assert.Equal("Burger x 2" + Environment.NewLine + "Salad x 3", orderSummaryLabel.Text);
        }
    }
}
