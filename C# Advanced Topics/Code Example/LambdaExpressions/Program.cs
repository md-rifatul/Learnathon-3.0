namespace LambdaExpressions
{
    public class Program
    {
        static void Main(string[] args)
        {
            //args => expression
            //() => ...      (if no argument)
            //x => ...       (if one argument)
            //(x,y,z) => ...    (if multiple argument)


            //Func<int, int> squre = number => number * number ;
            //Console.WriteLine(squre(5));

            //const int factor = 10;
            //Func<int,int> multiplier = n => n * factor ;
            //var result = multiplier(5) ;
            //Console.WriteLine(result);


            var books = new BookRepositories().GetBooks();
            var cheapBooks = books.FindAll(book => book.Price < 10);
            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
