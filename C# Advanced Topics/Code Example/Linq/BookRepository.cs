namespace Linq
{
    public class BookRepository
    {
        public IEnumerable<Book>GetBooks()
        {
            return new List<Book>()
                {
                    new Book() {Title = "English",Price = 5},
                    new Book() {Title = "ADO.Net MVC",Price = 9.99f},
                    new Book() {Title = "ADO.Net Web API",Price = 10},
                    new Book() {Title = "C# Advanced Topics",Price = 9},
                    new Book() {Title = "C# Advanced Topics",Price = 8}

                };
        }
    }
}
