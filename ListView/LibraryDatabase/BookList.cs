namespace CodeChum
{
    public class BookList
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(string isbn)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Isbn.Equals(isbn))
                {
                    books.RemoveAt(i);
                    return;
                }
            }
        }
        public void UpdateBook(Book book)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Isbn.Equals(book.Isbn))
                {
                    books[i] = book;
                    return;
                }
            }
        }
        public Book RetrieveBook(string isbn)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Isbn.Equals(isbn))
                {
                    return books[i];
                }
            }
            return null;
        }
    }
}
