class TypeConversion
{
    static void Main(string[] args)
    {
        int number1 = 5;
        float number2 = (float)5;
        Console.WriteLine(number2);

        float x = 9.4f;
        int k = (int)x;
        Console.WriteLine(k);


        string s1 = "5";
        int s2 = Convert.ToInt32(s1);
        Console.WriteLine(s2);

        string s3 = "6";
        int s4 = int.Parse(s3);
        Console.WriteLine(s4);

        //can't convert
        //int i = 1;
        //byte b = i;
        //Console.WriteLine(b); 


        //missing the data
        int i = 2000;
        byte b = (byte)i;
        Console.WriteLine(b);



    }
}