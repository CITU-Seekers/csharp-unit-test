namespace CodeChum.Tests
{
    public class DecoderTest
    {
        MessageDecoder? form;
        TextBox? textBox1;
        Label? DisplayMessage;
        Button? decoder;

        public DecoderTest()
        {
            form = new MessageDecoder();
            form.Visible = true;
            textBox1 = (TextBox) TestUtils.GetControlNamed(form, "textBox1", true);
            DisplayMessage = (Label) TestUtils.GetControlNamed(form, "DisplayMessage", true);
            decoder = (Button) TestUtils.GetControlNamed(form, "btnDecode", true);
        }

        [Fact]
        public void ShouldReverseText()
        {
            textBox1.Text = "dlrow";
            decoder.PerformClick();
            Assert.Equal("world", DisplayMessage.Text);
        }

        [Fact]
        public void ShouldReverseTextWithSpaces()
        {
            textBox1.Text = "dlrow olleh";
            decoder.PerformClick();
            Assert.Equal("hello world", DisplayMessage.Text);
        }

        [Fact]
        public void HasDecodeButton()
        {
            Assert.NotNull(decoder);
        }

        [Fact]
        public void HasTextBox()
        {
            Assert.NotNull(textBox1);
        }

        [Fact]
        public void HasDisplayMessage()
        {
            Assert.NotNull(DisplayMessage);
        }
    }
}
