using System;

namespace Factory.Outputs
{
    public class XmlFile : IOutput
    {
        public void Save()
        {
            Console.WriteLine("Save data into the Xml file");
        }
    }
}
