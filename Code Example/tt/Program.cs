
class Check
{
    static void Main(string[] args)
    {
        checked
        {
            byte number = 255;
            number += 1;
            Console.WriteLine(number);
        }
    }
}
