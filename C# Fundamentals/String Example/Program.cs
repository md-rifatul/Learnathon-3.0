namespace String_Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Rifatul Islam   ";
            Console.WriteLine("Trim : '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper : '{0}'",fullName.Trim().ToUpper());
            Console.WriteLine("ToLower : '{0}'",fullName.Trim().ToLower());

            //Substring
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName : "+ firstName);
            Console.WriteLine("LastName : "+ lastName);

            //Split
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName : " + names[0]);
            Console.WriteLine("LastName : " + names[1]);

            //Replace
            var newName = fullName.Replace("Rifatul", "Roki");
            Console.WriteLine(newName);


            //IsNullOrWhiteSpace
            if(String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            //String to int
            var str = "1234";
            var number = Convert.ToInt32(str);
            Console.WriteLine(number);

            //int to string
            var number1 = 1234.9;
            Console.WriteLine(number1.ToString("C0"));

        }
    }
}
