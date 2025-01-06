namespace InterfaceAndExtensibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\Roki\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
