using System;

namespace Factory.Outputs
{
    public class Database : IOutput
    {
        public void Save()
        {
            Console.WriteLine("Save data into the database");
        }
    }
}
