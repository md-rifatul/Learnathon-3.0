namespace File_and_FileInfo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Rifatul/test.txt";

            File.Copy(@"C:\Rifatul\test.txt", @"C:\Roki\test.txt", true);
            File.Delete(path);
            if(File.Exists(path))
            {
                Console.WriteLine("File is exists");
            }
            var content = File.ReadAllText(path);




            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(@"C:\Roki\test.txt", true);
            fileInfo.Delete();
            if(fileInfo.Exists)
            {
                Console.WriteLine(
                    "File is exists");
            }

        }
    }
}
