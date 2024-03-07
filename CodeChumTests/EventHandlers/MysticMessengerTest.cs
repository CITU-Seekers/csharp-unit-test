namespace CodeChum.Tests
{
    public class MysticMessengerTest
    {
        MysticMessenger? form;
        TextBox? textBox1;
        Label? lblMessage;
        Button? button1;
        Button? button2;
        Button? button3;

        public MysticMessengerTest()
        {
            form = new MysticMessenger();
            form.Visible = true;
            textBox1 = (TextBox)TestUtils.GetControlNamed(form, "textBox1", true);
            lblMessage = (Label)TestUtils.GetControlNamed(form, "lblMessage", true);
            button1 = (Button)TestUtils.GetControlNamed(form, "button1", true);
            button2 = (Button)TestUtils.GetControlNamed(form, "button2", true);
            button3 = (Button)TestUtils.GetControlNamed(form, "button3", true);
        }

        [Fact]
        public void ShouldReverseMessage()
        {
            textBox1.Text = "Hello";
            button1.PerformClick();
            Assert.Equal("olleH", lblMessage.Text);
        }

        [Fact]
        public void ShouldTranslateTheVowels()
        {
            textBox1.Text = "Hello";
            button1.PerformClick();
            button2.PerformClick();
            Assert.Equal("0ll3H", lblMessage.Text);
        }

        [Fact]
        public void ShouldTranslateToUppercaseMessage ()
        {
            textBox1.Text = "Hello";
            button1.PerformClick();
            button2.PerformClick();
            button3.PerformClick();
            Assert.Equal("0LL3H", lblMessage.Text);
        }

        [Fact]
        public void HasTextBox()
        {
            Assert.NotNull(textBox1);
        }

        [Fact]
        public void HasLabelMessage()
        {
            Assert.NotNull(lblMessage);
        }

        [Fact]
        public void HasButton1()
        {
            Assert.NotNull(button1);
        }

        [Fact]
        public void HasButton2()
        {
            Assert.NotNull(button2);
        }

        [Fact]
        public void HasButton3()
        {
            Assert.NotNull(button3);
        }

    }
}
