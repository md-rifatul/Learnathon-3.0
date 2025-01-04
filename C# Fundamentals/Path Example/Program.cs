namespace Path_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Rifatul\Test\Content.txt";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);
            Console.WriteLine("Extension : " +extension);

            Console.WriteLine("Extension : "+Path.GetExtension(path));
            Console.WriteLine("File Name : "+Path.GetFileName(path));
            Console.WriteLine("File Name Without Extension : "+Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name : "+Path.GetDirectoryName(path));

        }
    }
}
