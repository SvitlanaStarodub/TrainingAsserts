using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hometask
{
    public class Department
    {
        List<Employee> employees = new List<Employee>();
        
        public Department()
        {

        }

        public void Add(Employee employee)
        {
            EmployevalidateEmployee(employee);
            employees.Add(employee);
        }

        public void Sort()
        {
            employees.Sort();
        }

        public List<Employee> GetAll()
        {
            return employees;
        }

        private void EmployevalidateEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new NullReferenceException();
            }
        }
    }
}
