namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Rifatul";
            var lastName = "Islam";
            var name = firstName + lastName;

            var myFullName = string.Format("My name is {0} {1}",firstName,lastName);
            Console.WriteLine(myFullName);
            Console.WriteLine(name);


            var numbers = new int[] { 1, 2, 3 };
            var list = string.Join(", ", numbers);
            Console.WriteLine(list);

            var city = "Bangladesh";
            var c = city[0];
            Console.WriteLine(c);


            string path = @"Hi Rifat
c:project1\folder1
c:project1\forder2";
            Console.WriteLine(path);

        }
    }
}
