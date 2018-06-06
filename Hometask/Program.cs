namespace Hometask
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();

            department.Add(new Manager("Hugh", "Ellard", 35));
            department.Add(new Manager("Alice", "Hoogan", 30));
            department.Add(new Programmer("Bob", "Marley", 40));
            department.Add(new Programmer("Jack", "Lampard", 31));

            Console.WriteLine("List of employees before sort()");
            ShowAllEmployees(department.GetAll());

            department.Sort();

            Console.WriteLine("List of employees after sort()");
            ShowAllEmployees(department.GetAll());

            Console.ReadKey();
        }

        public static void ShowAllEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i].ToString());
            }
        }
    }
}
