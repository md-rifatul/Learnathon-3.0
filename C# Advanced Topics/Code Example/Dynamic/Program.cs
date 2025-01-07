namespace Dynamic
{
    public class Program
    {
        static void Main(string[] args)
        {
            //object obj = "rifatul";

            //var methodInfo = obj.GetType().GetMethod("GetHashCode");
            //methodInfo.Invoke(null, null);

            //dynamic excelObject = "rifatul";
            //excelObject.Optimize();

            object name = "Rifatul";
            name = 10;
            Console.WriteLine(name);

            dynamic a = 10;
            dynamic b = 20;
            var c = a + b;
            Console.WriteLine(c);
        }
    }
}
