﻿using System.Drawing;

namespace CodeChum.Tests
{
    public class ToolStripTextEditor2Tests
    {
        ToolStripTextEditor2? form;
        RichTextBox? mainRichTextBox;
        ToolStrip? editorToolStrip, colorToolStrip;
        ToolStripComboBox? fontComboBox, fontSizeComboBox;
        ToolStripButton? replaceAllButton, openColorsToolStripButton;
        ToolStripTextBox? replaceAllTextBox, findTextBox;

        public ToolStripTextEditor2Tests()
        {
            form = new ToolStripTextEditor2();
            form.Show();

            editorToolStrip = (ToolStrip)TestUtils.GetControlNamed(form, "editorToolStrip", true);
            colorToolStrip = (ToolStrip)TestUtils.GetControlNamed(form, "colorToolStrip", true);
            mainRichTextBox = (RichTextBox)TestUtils.GetControlNamed(form, "mainRichTextBox", true);
        }

        [Fact]
        // Description: Should have all the controls `editorToolStrip`, `colorToolStrip`, and `mainRichTextBox`.
        public void ShouldHaveAllControls()
        {
           Assert.NotNull(editorToolStrip);
           Assert.NotNull(colorToolStrip);
           Assert.NotNull(mainRichTextBox);
        }

        [Fact]
        // Description: Should have all the controls `fontComboBox`, `fontSizeComboBox`, `findTextBox`, `replaceAllTextBox`, `replaceAllButton`, and `openColorsToolStripButton` in `editorToolStrip`.
        public void ShouldHaveAllToolStripControlsForEditorToolStrip()
        {
            fontComboBox = editorToolStrip.Items["fontComboBox"] as ToolStripComboBox;
            fontSizeComboBox = editorToolStrip.Items["fontSizeComboBox"] as ToolStripComboBox;
            findTextBox = editorToolStrip.Items["findTextBox"] as ToolStripTextBox;
            replaceAllTextBox = editorToolStrip.Items["replaceAllTextBox"] as ToolStripTextBox;
            replaceAllButton = editorToolStrip.Items["replaceAllButton"] as ToolStripButton;
            openColorsToolStripButton = editorToolStrip.Items["openColorsToolStripButton"] as ToolStripButton;

           Assert.NotNull(fontComboBox);
           Assert.NotNull(fontSizeComboBox);
           Assert.NotNull(findTextBox);
           Assert.NotNull(replaceAllTextBox);
           Assert.NotNull(replaceAllButton);
           Assert.NotNull(openColorsToolStripButton);
        }

        [Fact]
        // Description: Should not show `colorToolStrip` by default.
        public void ShouldNotShowColorToolStripByDefault()
        {
            Assert.False(colorToolStrip.Visible, "The colorToolStrip should not be visible by default.");
        }

        [Fact]
        // Description: Should have all the controls `blackButton`, `blueButton`, `greenButton`, `redButton`, and `yellowButton` in `colorToolStrip`.
        public void ShouldHaveAllToolStripControlsForColorToolStrip()
        {
            String[] colorButtons = {
                "blackButton",
                "blueButton",
                "greenButton",
                "redButton",
                "yellowButton",
            };

            foreach (string colorButton in colorButtons)
            {
                ToolStripButton button = colorToolStrip.Items[colorButton] as ToolStripButton;

               Assert.NotNull(button);
            }
        }

        [Fact]
        // Description: Should open `colorToolStrip` when it is closed on `openColorsToolStripButton` click. Otherwise, the tool strip should be closed.
        public void ShouldOpenOrCloseColorToolStripOnColorButtonClick()
        {
            openColorsToolStripButton = editorToolStrip.Items["openColorsToolStripButton"] as ToolStripButton;

            Assert.False(colorToolStrip.Visible, "The colorToolStrip should not be visible by default.");

            openColorsToolStripButton.PerformClick();
            Assert.True(colorToolStrip.Visible, "The colorToolStrip should show on button click when it is not visible.");

            openColorsToolStripButton.PerformClick();
            Assert.False(colorToolStrip.Visible, "The colorToolStrip should close on button click when it is visible.");
        }

        [Fact]
        // Description: Should change font family of `mainRichTextBox` when selected item in the `fontComboBox` changes.
        public void ShouldBeAbleToChangeFontFamily()
        {
            fontComboBox = editorToolStrip.Items["fontComboBox"] as ToolStripComboBox;
            String[] fontFamilies = {
                "Arial",
                "Cascadia Code",
                "Segoe UI",
                "Tahoma",
                "Verdana",
            };

            foreach (string fontFamily in fontFamilies)
            {
                fontComboBox.SelectedIndex = fontComboBox.Items.IndexOf(fontFamily);
                Assert.Equal(fontFamily, mainRichTextBox.Font.FontFamily.Name);
            }
        }

        [Fact]
        // Description: Should change font size of `mainRichTextBox` when selected item in the `fontSizeComboBox` changes.
        public void ShouldBeAbleToChangeFontSize()
        {
            fontSizeComboBox = editorToolStrip.Items["fontSizeComboBox"] as ToolStripComboBox;
            String[] fontSizes = {
                "8",
                "10",
                "12",
                "14",
                "16",
            };

            foreach (string fontSize in fontSizes)
            {
                fontSizeComboBox.SelectedIndex = fontSizeComboBox.Items.IndexOf(fontSize);
                Assert.Equal(int.Parse(fontSize), mainRichTextBox.Font.Size);
            }
        }

        [Fact]
        // Description: Should replace all text in `mainRichTextBox` based on the text in `findTextBox` and `replaceAllTextBox` when `replaceAllButton` is clicked.
        public void ShouldBeAbleToReplaceAllTextInTextBox()
        {
            findTextBox = editorToolStrip.Items["findTextBox"] as ToolStripTextBox;
            replaceAllTextBox = editorToolStrip.Items["replaceAllTextBox"] as ToolStripTextBox;
            replaceAllButton = editorToolStrip.Items["replaceAllButton"] as ToolStripButton;

            String expectedText = "Hello world, goodbye world, goodbye world\ngoodbye world, Hello world";
            mainRichTextBox.Text = "Hello world, hello world, hello world\nhello world, Hello world";
            findTextBox.Text = "hello";
            replaceAllTextBox.Text = "goodbye";

            replaceAllButton.PerformClick();

            Assert.Equal(expectedText, mainRichTextBox.Text);
        }

        [Fact]
        // Description: Should change fore color of `mainRichTextBox` based on the color button clicked in `colorToolStrip`.
        public void ShouldBeAbleToChangeForeColorOfTextBox()
        {
            String[] colorButtons = {
                "blackButton",
                "blueButton",
                "greenButton",
                "redButton",
                "yellowButton",
            };

            Color[] colors = {
                Color.Black,
                Color.Blue,
                Color.Green,
                Color.Red,
                Color.Yellow,
            };

            for (int i = 0; i < colorButtons.Length; i++)
            {
                ToolStripButton button = colorToolStrip.Items[colorButtons[i]] as ToolStripButton;

                button.PerformClick();

                Assert.Equal(colors[i], mainRichTextBox.ForeColor);
            }
        }
    }
}