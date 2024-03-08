namespace CodeChum.Tests
{
    public class VendingMachineAppTest
    {
        VendingMachineApp? form;
        Panel? Panel1, Panel2, Panel3Cash, Panel3Card, Panel4;
        Button? ToPanel2Button, ToPanel4Button1, ToPanel4Button2, ToPanel3Button, ExitButton;
        Button? BackToPanel1Button, BackToPanel2Button1, BackToPanel2Button2;
        RadioButton? FoodRadioButton, BevRadioButton, CashRadioButton, CardRadioButton;
        ListBox? ItemList;
        NumericUpDown? QuantityUpDown;
        Label? TotalLabel, ErrorLabel;
        TextBox? CashTextBox, txtCardNum, txtExpiryDate, txtCVC;

        public VendingMachineAppTest()
        {
            form = new VendingMachineApp();
            form.Show();
            Panel1 = (Panel)TestUtils.GetControlNamed(form, "Panel1", true);
            Panel2 = (Panel)TestUtils.GetControlNamed(form, "Panel2", true);
            Panel3Cash = (Panel)TestUtils.GetControlNamed(form, "Panel3Cash", true);
            Panel3Card = (Panel)TestUtils.GetControlNamed(form, "Panel3Card", true);
            Panel4 = (Panel)TestUtils.GetControlNamed(form, "Panel4", true);
            ToPanel2Button = (Button)TestUtils.GetControlNamed(form, "ToPanel2Button", true);
            ToPanel4Button1 = (Button)TestUtils.GetControlNamed(form, "ToPanel4Button1", true);
            ToPanel4Button2 = (Button)TestUtils.GetControlNamed(form, "ToPanel4Button2", true);
            ToPanel3Button = (Button)TestUtils.GetControlNamed(form, "ToPanel3Button", true);
            ExitButton = (Button)TestUtils.GetControlNamed(form, "ExitButton", true);
            BackToPanel1Button = (Button)TestUtils.GetControlNamed(form, "BackToPanel1Button", true);
            BackToPanel2Button1 = (Button)TestUtils.GetControlNamed(form, "BackToPanel2Button1", true);
            BackToPanel2Button2 = (Button)TestUtils.GetControlNamed(form, "BackToPanel2Button2", true);
            FoodRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "FoodRadioButton", true);
            BevRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "BevRadioButton", true);
            CashRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "CashRadioButton", true);
            CardRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "CardRadioButton", true);
            ItemList = (ListBox)TestUtils.GetControlNamed(form, "ItemList", true);
            QuantityUpDown = (NumericUpDown)TestUtils.GetControlNamed(form, "QuantityUpDown", true);
            TotalLabel = (Label)TestUtils.GetControlNamed(form, "TotalLabel", true);
            ErrorLabel = (Label)TestUtils.GetControlNamed(form, "ErrorLabel", true);
            CashTextBox = (TextBox)TestUtils.GetControlNamed(form, "CashTextBox", true);
            txtCardNum = (TextBox)TestUtils.GetControlNamed(form, "txtCardNum", true);
            txtExpiryDate = (TextBox)TestUtils.GetControlNamed(form, "txtExpiryDate", true);
            txtCVC = (TextBox)TestUtils.GetControlNamed(form, "txtCVC", true);
        }

        [Fact]
        public void ShouldHaveProperStartingVisibility()
        {
            Assert.True(Panel1.Visible);
            Assert.False(Panel2.Visible);
            Assert.False(Panel3Cash.Visible);
            Assert.False(Panel3Card.Visible);
            Assert.False(Panel4.Visible);
        }

        [Fact]
        public void ShouldHaveProperVisibilityOfControlsPerPanel()
        {
            Assert.True(Panel1.Visible);
            Assert.True(ToPanel2Button.Visible);
            Assert.True(FoodRadioButton.Visible);
            Assert.True(BevRadioButton.Visible);
            Assert.True(ItemList.Visible);
            Assert.True(QuantityUpDown.Visible);
            Assert.True(TotalLabel.Visible);

            ToPanel2Button.PerformClick();
            Assert.False(Panel1.Visible);
            Assert.True(Panel2.Visible);
            Assert.True(ToPanel3Button.Visible);
            Assert.True(BackToPanel1Button.Visible);
            Assert.True(CashRadioButton.Visible);
            Assert.True(CardRadioButton.Visible);

            CashRadioButton.Checked = true;
            ToPanel3Button.PerformClick();
            Assert.False(Panel2.Visible);
            Assert.False(Panel1.Visible);
            Assert.False(Panel3Card.Visible);
            Assert.True(Panel3Cash.Visible);
            Assert.True(ToPanel4Button1.Visible);
            Assert.True(BackToPanel2Button1.Visible);
            Assert.True(CashTextBox.Visible);
            Assert.True(ErrorLabel.Visible);

            BackToPanel2Button1.PerformClick();
            CardRadioButton.Checked = true;
            ToPanel3Button.PerformClick();
            Assert.False(Panel2.Visible);
            Assert.False(Panel1.Visible);
            Assert.False(Panel3Cash.Visible);
            Assert.True(Panel3Card.Visible);
            Assert.True(ToPanel4Button2.Visible);
            Assert.True(BackToPanel2Button2.Visible);
            Assert.True(txtCardNum.Visible);
            Assert.True(txtExpiryDate.Visible);
            Assert.True(txtCVC.Visible);

            ToPanel4Button2.PerformClick();
            Assert.False(Panel2.Visible);
            Assert.False(Panel1.Visible);
            Assert.False(Panel3Cash.Visible);
            Assert.False(Panel3Card.Visible);
            Assert.True(Panel4.Visible);
            Assert.True(ExitButton.Visible);
        }

        [Fact]
        public void ShouldCalculateTotalPriceForFood()
        {
            FoodRadioButton.Checked = true;
            ItemList.SelectedIndex = 0;
            QuantityUpDown.Value = 1;
            
            Assert.Equal("Total: $1.50", TotalLabel.Text);
        }

        [Fact]
        public void ShouldCalculateTotalPriceForBeverage()
        {
            BevRadioButton.Checked = true;
            ItemList.SelectedIndex = 0;
            QuantityUpDown.Value = 1;

            Assert.Equal("Total: $1.25", TotalLabel.Text);
        }

        [Fact]
        public void ShouldShowErrorWhenInsufficientFunds()
        {
            FoodRadioButton.Checked = true;
            ItemList.SelectedIndex = 0;
            QuantityUpDown.Value = 1;
            ToPanel2Button.PerformClick();
            CashRadioButton.Checked = true;
            ToPanel3Button.PerformClick();
            CashTextBox.Text = "1.00";
            ToPanel4Button1.PerformClick();

            Assert.Equal("Insufficient funds!", ErrorLabel.Text);
        }
    }
}
