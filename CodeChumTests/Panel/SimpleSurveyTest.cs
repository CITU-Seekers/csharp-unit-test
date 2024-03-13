namespace CodeChum.Tests
{
    public class SimpleSurveyTest
    {
        SimpleSurvey? form;
        Panel? panel1, panel2, panel3, panel4;
        Button? startButton, toPanel3Button, toPanel4Button, backToPanel1Button, backToPanel2Button, exitButton;
        RadioButton? radioButton1, radioButton2, radioButton3, radioButton4, radioButton5;
        TrackBar? trackBar1;

        public SimpleSurveyTest()
        {
            form = new SimpleSurvey();
            form.Show();

            panel1 = (Panel)TestUtils.GetControlNamed(form, "panel1", true);
            panel2 = (Panel)TestUtils.GetControlNamed(form, "panel2", true);
            panel3 = (Panel)TestUtils.GetControlNamed(form, "panel3", true);
            panel4 = (Panel)TestUtils.GetControlNamed(form, "panel4", true);
            startButton = (Button)TestUtils.GetControlNamed(form, "startButton", true);
            toPanel3Button = (Button)TestUtils.GetControlNamed(form, "toPanel3Button", true);
            toPanel4Button = (Button)TestUtils.GetControlNamed(form, "toPanel4Button", true);
            backToPanel1Button = (Button)TestUtils.GetControlNamed(form, "backToPanel1Button", true);
            backToPanel2Button = (Button)TestUtils.GetControlNamed(form, "backToPanel2Button", true);
            exitButton = (Button)TestUtils.GetControlNamed(form, "exitButton", true);   
            radioButton1 = (RadioButton)TestUtils.GetControlNamed(form, "radioButton1", true);
            radioButton2 = (RadioButton)TestUtils.GetControlNamed(form, "radioButton2", true);
            radioButton3 = (RadioButton)TestUtils.GetControlNamed(form, "radioButton3", true);
            radioButton4 = (RadioButton)TestUtils.GetControlNamed(form, "radioButton4", true);
            radioButton5 = (RadioButton)TestUtils.GetControlNamed(form, "radioButton5", true);
            trackBar1 = (TrackBar)TestUtils.GetControlNamed(form, "trackBar1", true);
        }

        [Fact]
        // Description: Should have all the controls `panel1`, `panel2`, `panel3`, `panel4`, `startButton`, `toPanel3Button`, `toPanel4Button`, `backToPanel1Button`, `backToPanel2Button`, and `exitButton`.

        public void ShouldHaveAllControls()
        {
            Assert.NotNull(panel1);
            Assert.NotNull(panel2);
            Assert.NotNull(panel3);
            Assert.NotNull(panel4);
            Assert.NotNull(startButton);
            Assert.NotNull(toPanel3Button);
            Assert.NotNull(toPanel4Button);
            Assert.NotNull(backToPanel1Button);
            Assert.NotNull(backToPanel2Button);
            Assert.NotNull(exitButton);
        }

        [Fact]
        // Description: Should have proper starting visibility of `panel1`, `panel2`, `panel3`, and `panel4`.
        public void ShouldHaveProperStartingVisibility()
        {
            Assert.True(panel1.Visible);
            Assert.False(panel2.Visible);
            Assert.False(panel3.Visible);
            Assert.False(panel4.Visible);
        }

        [Fact]
        // Description: Should have proper visibility of controls `radioButton1`, `radioButton2`, `radioButton3`, `radioButton4`, `radioButton5`, `toPanel3Button`, and `backToPanel1Button` when `startButton` is clicked.
        public void ShouldHaveProperVisibilityOfControlsStartButtonClick()
        {
            startButton.PerformClick();
            Assert.False(panel1.Visible);
            Assert.True(panel2.Visible);
            Assert.True(radioButton1.Visible);
            Assert.True(radioButton2.Visible);
            Assert.True(radioButton3.Visible);
            Assert.True(radioButton4.Visible);
            Assert.True(radioButton5.Visible);
            Assert.True(toPanel3Button.Visible);
            Assert.True(backToPanel1Button.Visible);
            Assert.False(panel3.Visible);
            Assert.False(trackBar1.Visible);
        }

        [Fact]
        // Description: Should have proper visibility of controls `panel1`, `panel2`, `panel3`, and `panel4` when `startButton` is clicked then `backToPanel1Button` is clicked.
        public void ShouldHaveProperVisiblityOfControlsBackToPanel1ButtonClick()
        {
            startButton.PerformClick();
            backToPanel1Button.PerformClick();
            Assert.True(panel1.Visible);
            Assert.False(panel2.Visible);
            Assert.False(panel3.Visible);
            Assert.False(panel4.Visible);
        }

        [Fact]
        // Description: Should have proper visibility of controls `panel1`, `panel2`, `panel3`, `trackBar1`, `toPanel4Button`, and `backToPanel2Button` when `startButton` is clicked then `toPanel3Button` is clicked.
        public void ShouldHaveProperVisiblityOfControlsToPanel3ButtonClick()
        {
            startButton.PerformClick();
            toPanel3Button.PerformClick();
            Assert.False(panel1.Visible);
            Assert.False(panel2.Visible);
            Assert.True(panel3.Visible);
            Assert.True(trackBar1.Visible);
            Assert.True(toPanel4Button.Visible);
            Assert.True(backToPanel2Button.Visible);
            Assert.False(panel4.Visible);
            Assert.False(exitButton.Visible);
        }

        [Fact]
        // Description: Should have proper visibility of controls `panel1`, `panel2`, `panel3`, and `panel4` when `startButton` is clicked then `toPanel3Button` is clicked then `backToPanel2Button` is clicked.
        public void ShouldHaveProperVisiblityOfControlsBackToPanel2ButtonClick()
        {
            startButton.PerformClick();
            toPanel3Button.PerformClick();
            backToPanel2Button.PerformClick();
            Assert.False(panel1.Visible);
            Assert.True(panel2.Visible);
            Assert.False(panel3.Visible);
            Assert.False(panel4.Visible);
        }

        [Fact]
        // Description: Should have proper visibility of controls `panel1`, `panel2`, `panel3`, and `panel4` when `startButton` is clicked then `toPanel3Button` is clicked then `toPanel4Button` is clicked.
        public void ShouldHaveProperVisiblityOfControlsToPanel4ButtonClick()
        {
            startButton.PerformClick();
            toPanel3Button.PerformClick();
            toPanel4Button.PerformClick();
            Assert.False(panel1.Visible);
            Assert.False(panel2.Visible);
            Assert.False(panel3.Visible);
            Assert.True(panel4.Visible);
            Assert.True(exitButton.Visible);
        }

        [Fact]
        // Description: Should have proper visibility of controls `panel1`, `panel2`, `panel3`, and `panel4` when `startButton` is clicked then `toPanel3Button` is clicked then `toPanel4Button` is clicked then `exitButton` is clicked.
        public void ShouldHaveProperVisiblityOfControlsExitButtonClick()
        {
            startButton.PerformClick();
            toPanel3Button.PerformClick();
            toPanel4Button.PerformClick();
            exitButton.PerformClick();
            
            Assert.False(form.Visible);
        }
    }
}
