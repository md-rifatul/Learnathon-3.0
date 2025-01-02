
public class Information
{
    public string name;
    public int age;

    public void About()
    {
        Console.WriteLine("Name = "+name);
        Console.WriteLine("Name = "+age);
    }
}

class BasicClass
{
    static void Main(string[] args)
    {
        var Rifat = new Information();
        Rifat.name = "Rifatul Islam";
        Rifat.age = 22;
        Rifat.About();
    }
}