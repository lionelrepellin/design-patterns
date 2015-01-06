using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Manager : Employee
    {
        private List<Employee> employees;        

        public Manager(string name, int level)
            : base(name, level)
        {
            this.employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            this.employees.Add(employee);
        }

        public void AddEmployees(List<Employee> employees)
        {
            this.employees.AddRange(employees);
        }

        public override string Display()
        {
            var sb = new StringBuilder(base.Display());

            if (this.employees.Any())
            {
                sb.AppendLine();
            }

            foreach (var employee in this.employees)
            {
                sb.AppendLine(employee.Display());
            }
            
            return sb.ToString();
        }
    }
}
