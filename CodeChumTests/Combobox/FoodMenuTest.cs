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
        Label? lblOrderSummary;
        Button? btnAdd;

        public FoodMenuTest()
        {
            form = new FoodMenu();
            form.Visible = true;
            comboBox1 = (ComboBox)TestUtils.GetControlNamed(form, "comboBox1", true);
            radioButton1 = (RadioButton)TestUtils.GetControlNamed(form, "radioButton1", true);
            radioButton2 = (RadioButton)TestUtils.GetControlNamed(form, "radioButton2", true);
            radioButton3 = (RadioButton)TestUtils.GetControlNamed(form, "radioButton3", true);
            textBox1 = (TextBox)TestUtils.GetControlNamed(form, "textBox1", true);
            lblOrderSummary = (Label)TestUtils.GetControlNamed(form, "lblOrderSummary", true);
            btnAdd = (Button)TestUtils.GetControlNamed(form, "btnAdd", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(comboBox1);
            Assert.NotNull(radioButton1);
            Assert.NotNull(radioButton2);
            Assert.NotNull(radioButton3);
            Assert.NotNull(textBox1);
            Assert.NotNull(lblOrderSummary);
            Assert.NotNull(btnAdd);
        }

        [Fact]
        public void ShouldHaveComboBoxItems()
        {
            Assert.Equal(2, comboBox1.Items.Count);
            Assert.Equal("Food", comboBox1.Items[0]);
            Assert.Equal("Drinks", comboBox1.Items[1]);
        }

        [Fact]
        public void ShouldHaveCorrectFoodItems()
        {
            comboBox1.SelectedIndex = 0;
            Assert.Equal("Food", comboBox1.Text);
            Assert.Equal("Burger", radioButton1.Text);
            Assert.Equal("Salad", radioButton2.Text);
            Assert.Equal("Pizza", radioButton3.Text);
        }

        [Fact]
        public void ShouldHaveCorrectDrinkItems()
        {
            comboBox1.SelectedIndex = 1;
            Assert.Equal("Drinks", comboBox1.Text);
            Assert.Equal("Soda", radioButton1.Text);
            Assert.Equal("Juice", radioButton2.Text);
            Assert.Equal("Water", radioButton3.Text);
        }

        [Fact]
        public void ShouldAddFoodItem()
        {
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = true;
            textBox1.Text = "2";
            btnAdd.PerformClick();
            Assert.Equal("Burger x 2", lblOrderSummary.Text);
        }

        [Fact]
        public void ShouldAddDrinkItem()
        {
            comboBox1.SelectedIndex = 1;
            radioButton2.Checked = true;
            textBox1.Text = "3";
            btnAdd.PerformClick();
            Assert.Equal("Juice x 3", lblOrderSummary.Text);
        }

        [Fact]
        public void ShouldAddMultipleItems()
        {
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = true;
            textBox1.Text = "2";
            btnAdd.PerformClick();
            radioButton2.Checked = true;
            textBox1.Text = "3";
            btnAdd.PerformClick();
            Assert.Equal("Burger x 2" + Environment.NewLine + "Salad x 3", lblOrderSummary.Text);
        }
    }
}
