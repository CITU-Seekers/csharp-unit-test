namespace CodeChum
{
    public class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public float Rating { get; set; }
        public DateTime DatePublished { get; set; }

        public Book(string isbn, string title, string author, string genre, float rating, DateTime datePublished)
        {
            Isbn = isbn;
            Title = title;
            Author = author;
            Genre = genre;
            Rating = rating;
            DatePublished = datePublished;
        }
        public Book(string isbn, string title, string author)
        {
            Isbn = isbn;
            Title = title;
            Author = author;
            Genre = "Action";
            Rating = 5.0F;
        }
    }
}
