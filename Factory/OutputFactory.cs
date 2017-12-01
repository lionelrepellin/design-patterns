using Factory.Outputs;
using System;
using System.Collections.Generic;

namespace Factory
{
    public class OutputFactory
    {
        private readonly Dictionary<int, Type> _outputs;

        public OutputFactory()
        {
            _outputs = new Dictionary<int, Type>
            {
                { 1, typeof(Database) },
                { 2, typeof(XmlFile) },
                { 3, typeof(JsonFile) },
            };
        }

        public IOutput FindById(int id)
        {
            // I find it more elegant than a switch
            if (_outputs.ContainsKey(id))
            {
                return (IOutput)Activator.CreateInstance(_outputs[id]);
            }

            throw new ArgumentOutOfRangeException(nameof(id));
        }
    }
}
