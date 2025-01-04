namespace Ref_Modifier
{
    public class Program
    {
        static void Main(string[] args)
        {
           var geometry = new Geometry();
            int m = 5;
            geometry.Calculate(ref m);
            Console.WriteLine(m);
        }
    }
}
