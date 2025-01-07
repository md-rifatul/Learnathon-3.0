namespace Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            
            

            //foreach (var book in books)
            //    Console.WriteLine(book.Title);



            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if(book.Price < 10)
            //        cheapBooks.Add(book);
            //}
            //foreach (var book in cheapBooks)
            //    Console.WriteLine(book.Title+ " "+ book.Price);


            //LINQ Query Operators   (Alltime finished with select)
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Price
                               select b.Title;


            //Linq extension method
            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            foreach (var cheapBook in cheapBooks)
                Console.WriteLine(cheapBook);
            //Console.WriteLine(cheapBook.Title+ ' '+cheapBook.Price);


            //For only one object   (It's good for use)
            var book = books.SingleOrDefault(b => b.Title == "ADO.Net MVC");
            //Console.WriteLine(book == null);
            Console.WriteLine(book.Title);

            //For outpur first one
            var book1 = books.First(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book1.Title+' '+book1.Price);

            //For output last one
            var book2 = books.LastOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book2.Title +' '+book2.Price);


            //Skip and Take
            Console.WriteLine("Efect of Skip and Take:");
            var book3 = books.Skip(2).Take(3);
            foreach(var b in book3)
                Console.WriteLine(b.Title+' '+b.Price);

            //Count the book
            Console.WriteLine("Effect of count: ");
            var count = books.Count();
            Console.WriteLine(count);

            //Max method
            Console.WriteLine("Effect of max: ");
           var maxPrice = books.Max(b => b.Price);
            Console.WriteLine(maxPrice);

            //Min method
            Console.WriteLine("Effect of min: ");
            var minPrice = books.Min(b => b.Price);
            Console.WriteLine(minPrice);

            //Sum method
            Console.WriteLine("Effect of Sum: ");
            var sumPrice = books.Sum(b => b.Price);
            Console.WriteLine(sumPrice);


        }
    }
}
