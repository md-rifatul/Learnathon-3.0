namespace InterfaceAndExtensibility
{

    public class DbMigrator
    {
        private readonly Ilogger _logger;

        public DbMigrator(Ilogger logger)
        {
            this._logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo($"Migration started at : {DateTime.Now}");

            _logger.LogInfo($"Migration finished at : {DateTime.Now}");
        }
    }
}
