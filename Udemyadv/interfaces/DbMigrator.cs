using System;

namespace interface_etensibility
{
    public  class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            this._logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("migration initiated at {0}"+ DateTime.Now);
            Console.WriteLine();

            _logger.LogInfo("finished initiated at {0}" + DateTime.Now);
        }
    }
}
