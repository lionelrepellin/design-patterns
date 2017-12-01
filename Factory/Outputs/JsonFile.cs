using System;

namespace Factory.Outputs
{
    public class JsonFile : IOutput
    {
        public void Save()
        {
            Console.WriteLine("Save data into the Json file");
        }
    }
}
