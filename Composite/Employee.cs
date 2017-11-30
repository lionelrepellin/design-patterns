namespace Composite
{
    public abstract class Employee
    {
        private readonly string _name;
        private readonly int _hierarchyLevel;

        protected Employee(string name, int level)
        {
            _name = name;
            _hierarchyLevel = level;
        }

        public virtual string Display()
        {
            var result = string.Format($"{_name} ({GetType().Name})");
            return result.PadLeft(3 * _hierarchyLevel + result.Length);
        }
    }
}