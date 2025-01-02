class Operators
{
    static void Main(string[] args)
    {
        var number1 = 10;
        var number2 = 20;

        Console.WriteLine(number1 + number2);
        Console.WriteLine(number2 - number1);
        Console.WriteLine(number1 * number2);
        Console.WriteLine(number2 / number1);
        Console.WriteLine(number2 % number1);

        var a = 10;
        var b = ++a;
        var c = a++;
        Console.WriteLine(b);
        Console.WriteLine(c);

        var name1 = "rifatul";
        var name2 = "rifatul";
        if (name1 == name2)
            Console.WriteLine("Two are same");
        else
            Console.WriteLine("Not same");


        Console.WriteLine(10 | 7);
        Console.WriteLine(10 & 7);

        if(10 > 5 && name1 == name2)
        {
            Console.WriteLine("Done");
        }
        else
        {
            Console.WriteLine("Not Done");
        }
        

    }
}