namespace Nullable_Types
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string name = null;
            DateTime? dateTime = null;

            Console.WriteLine(dateTime.GetValueOrDefault());
            Console.WriteLine(dateTime.HasValue);
            //Console.WriteLine(dateTime.Value);

            DateTime? dateTime1 = new DateTime(2015, 5, 15);
            DateTime dateTime2 = dateTime1.GetValueOrDefault();
            Console.WriteLine(dateTime2);


            DateTime? dateTime4 = null;
            DateTime dateTime5;

            if(dateTime4 != null)
                dateTime5 = dateTime4.GetValueOrDefault();
            else
                dateTime5 = DateTime.Today;

            Console.WriteLine(dateTime5);


            DateTime? date = null;
            DateTime date2 = date ?? DateTime.Today;
            Console.WriteLine(date2);


            Console.WriteLine();
            DateTime date3 = (date != null) ? dateTime1.GetValueOrDefault() : DateTime.Today;
            Console.WriteLine(date3);

        }
    }
}
