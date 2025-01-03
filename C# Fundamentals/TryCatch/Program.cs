
class TryCatch
{
   static void Main(string[] args)
    {
        try
        {
            var number = 50;
            var ans = number / 0;
            Console.WriteLine(ans);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Not divide by 0");
        }
    }
}