using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Manager : Employee
    {
        private List<Employee> _employees;        

        public Manager(string name, int level)
            : base(name, level)
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void AddEmployees(List<Employee> employees)
        {
            _employees.AddRange(employees);
        }

        public override string Display()
        {
            var sb = new StringBuilder(base.Display());

            if (_employees.Any())
            {
                sb.AppendLine();
            }

            foreach (var employee in _employees)
            {
                sb.AppendLine(employee.Display());
            }
            
            return sb.ToString();
        }
    }
}
