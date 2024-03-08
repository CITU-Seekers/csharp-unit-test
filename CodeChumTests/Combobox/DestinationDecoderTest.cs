namespace CodeChum.Tests
{
    public class DestinationDecoderTest
    {
        DestinationDecoder? form;
        ComboBox? cboTrait;
        Label? lblDestination;
        Button? btnReveal;

        public DestinationDecoderTest()
        {
            form = new DestinationDecoder();
            form.Visible = true;
            cboTrait = (ComboBox)TestUtils.GetControlNamed(form, "cboTrait", true);
            lblDestination = (Label)TestUtils.GetControlNamed(form, "lblDestination", true);
            btnReveal = (Button)TestUtils.GetControlNamed(form, "btnReveal", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(cboTrait);
            Assert.NotNull(lblDestination);
            Assert.NotNull(btnReveal);
        }

        [Fact]
        public void ShouldDisplayDestinationWhenRevealClicked()
        {
            cboTrait.SelectedIndex = 0;
            btnReveal.PerformClick();
            Assert.Equal("Machu Picchu, Peru", lblDestination.Text);
        }
    }
}
