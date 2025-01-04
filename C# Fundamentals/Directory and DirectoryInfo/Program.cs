namespace Directory_and_DirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\Rifatul\Test");
            var files = Directory.GetFiles(@"C:\Rifatul", "*.txt", SearchOption.AllDirectories);

            foreach (var file in files)
                Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"C:\Rifatul", "*.*", SearchOption.AllDirectories);
            foreach(var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists(@"C:\Rifatul");

            var directoryInfo = new DirectoryInfo(@"C:\Rifatul\Test");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
