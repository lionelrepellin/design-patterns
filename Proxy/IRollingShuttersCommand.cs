namespace Proxy
{
    public interface IRollingShuttersCommand
    {
        void Up();

        void Down();
    }
}