using System.Drawing;

namespace CodeChum.Tests
{
    public class BlogPostTest
    {
        BlogPost? form;
        Label? lblTitle;
        Label? lblAuthor;
        Label? lblContent;

        public BlogPostTest()
        {
            form = new BlogPost();
            form.Show();
            lblTitle = (Label)TestUtils.GetControlNamed(form, "lblTitle", true);
            lblAuthor = (Label)TestUtils.GetControlNamed(form, "lblAuthor", true);
            lblContent = (Label)TestUtils.GetControlNamed(form, "lblContent", true);   
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(lblTitle);
            Assert.NotNull(lblAuthor);
            Assert.NotNull(lblContent);
        }

        [Fact]
        public void ShouldStyleTitleLabel()
        {
            Label lblTitle = (Label)TestUtils.GetControlNamed(form, "lblTitle", true);
            Assert.NotNull(lblTitle);
            Assert.Equal("Title", lblTitle.Text);
            Assert.Equal(new Font(lblTitle.Font, FontStyle.Bold), lblTitle.Font);
            Assert.Equal(new Font(lblTitle.Font.FontFamily, 18, FontStyle.Bold), lblTitle.Font);
            Assert.Equal(Color.DarkBlue, lblTitle.ForeColor);
        }

        [Fact]
        public void ShouldStyleAuthorLabel()
        {
            Label lblAuthor = (Label)TestUtils.GetControlNamed(form, "lblAuthor", true);
            Assert.NotNull(lblAuthor);
            Assert.Equal("Author", lblAuthor.Text);
            Assert.Equal(new Font(lblAuthor.Font, FontStyle.Italic), lblAuthor.Font);
            Assert.Equal(Color.Gray, lblAuthor.ForeColor);
        }

        [Fact]
        public void ShouldStyleContentLabel()
        {
            Label lblContent = (Label)TestUtils.GetControlNamed(form, "lblContent", true);
            Assert.NotNull(lblContent);
            Assert.Equal("Content", lblContent.Text);
            Assert.Equal(new Font(lblContent.Font.FontFamily, 14), lblContent.Font);
        }
    }
}
