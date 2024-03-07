namespace CodeChum.Tests
{
    public class OrchestraTest
    {
        Orchestra? form;
        Label? lblMessage;
        Button? btnViolins;
        Button? btnCellos;
        Button? btnTrumpets;
        Button? btnDrums;

        public OrchestraTest()
        {
            form = new Orchestra();
            form.Visible = true;
            lblMessage = (Label) TestUtils.GetControlNamed(form, "lblMessage", true);
            btnViolins = (Button) TestUtils.GetControlNamed(form, "btnViolins", true);
            btnCellos = (Button) TestUtils.GetControlNamed(form, "btnCellos", true);
            btnTrumpets = (Button) TestUtils.GetControlNamed(form, "btnTrumpets", true);
            btnDrums = (Button) TestUtils.GetControlNamed(form, "btnDrums", true);
        }

        [Fact]
        public void HasLabelMessage()
        {
            Assert.NotNull(lblMessage);
        }

        [Fact]
        public void HasButtonViolins()
        {
            Assert.NotNull(btnViolins);
        }

        [Fact]
        public void HasButtonCellos()
        {
            Assert.NotNull(btnCellos);
        }

        [Fact]
        public void HasButtonTrumpets()
        {
            Assert.NotNull(btnTrumpets);
        }

        [Fact]
        public void HasButtonDrums()
        {
            Assert.NotNull(btnDrums);
        }

        [Fact]
        public void ShouldDisplayMessageWhenViolinsButtonIsClicked()
        {
            btnViolins.PerformClick();
            Assert.Equal("Violins are playing!", lblMessage.Text);
        }

        [Fact]
        public void ShouldDisplayMessageWhenCellosButtonIsClicked()
        {
            btnCellos.PerformClick();
            Assert.Equal("Cellos are playing!", lblMessage.Text);
        }

        [Fact]
        public void ShouldDisplayMessageWhenTrumpetsButtonIsClicked()
        {
            btnTrumpets.PerformClick();
            Assert.Equal("Trumpets are playing!", lblMessage.Text);
        }

        [Fact]
        public void ShouldDisplayMessageWhenDrumsButtonIsClicked()
        {
            btnDrums.PerformClick();
            Assert.Equal("Drums are playing!", lblMessage.Text);
        }

        [Fact]
        public void ShouldDisplayOnlyOneYellowButton()
        {
            btnViolins.PerformClick();
            btnCellos.PerformClick();
            btnTrumpets.PerformClick();
            btnDrums.PerformClick();

            int yellowCount = 0;
            if (btnViolins.BackColor == System.Drawing.Color.Yellow)
            {
                yellowCount++;
            }
            if (btnCellos.BackColor == System.Drawing.Color.Yellow)
            {
                yellowCount++;
            }
            if (btnTrumpets.BackColor == System.Drawing.Color.Yellow)
            {
                yellowCount++;
            }
            if (btnDrums.BackColor == System.Drawing.Color.Yellow)
            {
                yellowCount++;
            }

            Assert.Equal(1, yellowCount);
        }
    }
}
