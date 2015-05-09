namespace Strategy
{
    // the Load() and Save() methods will be used
    // regardless of the strategy
    public interface IBackupStrategy
    {
        object Load();

        void Save();
    }
}