namespace Strategy
{
    // the behaviour depends of the strategy used
    public class BackupService
    {
        private readonly IBackupStrategy _strategy;

        public BackupService(IBackupStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Save()
        {
            _strategy.Save();
        }

        public object Load()
        {
            return _strategy.Load();
        }
    }
}