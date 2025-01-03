namespace Reference_Type
{
    public class Program
    {
        static void Main(string[] args)
        {
            var array1 =new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 5;

            Console.WriteLine(array1[0]);
            Console.WriteLine(array2[0]);
        }
    }
}
