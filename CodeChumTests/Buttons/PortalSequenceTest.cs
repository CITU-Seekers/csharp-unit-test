namespace CodeChum.Tests
{
    public class PortalSequenceTest
    {
        PortalSequence? form;
        Label? labelMessage;
        Button? button1;
        Button? button2;
        Button? button3;

        public PortalSequenceTest()
        {
            form = new PortalSequence();
            form.Visible = true;
            labelMessage = (Label) TestUtils.GetControlNamed(form, "label4", true);
            button1 = (Button) TestUtils.GetControlNamed(form, "button1", true);
            button2 = (Button) TestUtils.GetControlNamed(form, "button2", true);
            button3 = (Button) TestUtils.GetControlNamed(form, "button3", true);
        }

        [Fact]
        public void HasLabelMessage()
        {
            Assert.NotNull(labelMessage);
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

        [Fact]
        public void ShouldDisplaySuccessMessageWhenAllStepsAreCompleted()
        {
            button2.PerformClick();
            button1.PerformClick();
            button3.PerformClick();
            Assert.Equal("Congratulations! The portal is now open!", labelMessage.Text);
        }

        [Fact]
        public void ShouldDisplayProgressMessageWhenStepsAreCompleted()
        {
            button2.PerformClick();
            Assert.Equal("Step 1 of 3 completed. Keep going!", labelMessage.Text);
            button1.PerformClick();
            Assert.Equal("Step 2 of 3 completed. Keep going!", labelMessage.Text);
        }
    }
}
