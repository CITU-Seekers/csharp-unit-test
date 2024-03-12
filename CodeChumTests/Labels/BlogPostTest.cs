using System.Drawing;

namespace CodeChum.Tests
{
    public class BlogPostTest
    {
        BlogPost? form;
        Label? titleLabel;
        Label? authorLabel;
        Label? contentLabel;

        public BlogPostTest()
        {
            form = new BlogPost();
            form.Show();
            titleLabel = (Label)TestUtils.GetControlNamed(form, "titleLabel", true);
            authorLabel = (Label)TestUtils.GetControlNamed(form, "authorLabel", true);
            contentLabel = (Label)TestUtils.GetControlNamed(form, "contentLabel", true);   
        }

        [Fact]
        // Description: Should have all controls `titleLabel`, `authorLabel`, and `contentLabel`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(titleLabel);
            Assert.NotNull(authorLabel);
            Assert.NotNull(contentLabel);
        }

        [Fact]
        // Description: Should have `titleLabel` with text "Title" and style bold and dark blue color.
        public void ShouldStyleTitleLabel()
        {
            Label titleLabel = (Label)TestUtils.GetControlNamed(form, "titleLabel", true);
            Assert.NotNull(titleLabel);
            Assert.Equal("Title", titleLabel.Text);
            Assert.Equal(new Font(titleLabel.Font, FontStyle.Bold), titleLabel.Font);
            Assert.Equal(new Font(titleLabel.Font.FontFamily, 18, FontStyle.Bold), titleLabel.Font);
            Assert.Equal(Color.DarkBlue, titleLabel.ForeColor);
        }

        [Fact]
        // Description: Should have `authorLabel` with text "Author" and style italic and gray color.
        public void ShouldStyleAuthorLabel()
        {
            Label authorLabel = (Label)TestUtils.GetControlNamed(form, "authorLabel", true);
            Assert.NotNull(authorLabel);
            Assert.Equal("Author", authorLabel.Text);
            Assert.Equal(new Font(authorLabel.Font, FontStyle.Italic), authorLabel.Font);
            Assert.Equal(Color.Gray, authorLabel.ForeColor);
        }

        [Fact]
        // Description: Should have `contentLabel` with text "Content" and style font size 14.
        public void ShouldStyleContentLabel()
        {
            Label contentLabel = (Label)TestUtils.GetControlNamed(form, "contentLabel", true);
            Assert.NotNull(contentLabel);
            Assert.Equal("Content", contentLabel.Text);
            Assert.Equal(new Font(contentLabel.Font.FontFamily, 14), contentLabel.Font);
        }
    }
}
