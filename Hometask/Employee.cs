
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hometask
{
    public abstract class Employee : IComparable<Employee>
    {
        const int MIN_NAME_LENGTH = 3;
        const int MIN_AGE = 18;
        const int MAX_AGE = 60;

        private string _firstName;
        private string _lastName;
        private int _age;

        public Employee(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public int CompareTo(Employee employee)
        {
            return Age.CompareTo(employee.Age);
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                VerifyName(value);
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                VerifyName(value);
                _lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > MAX_AGE || value < MIN_AGE)
                {
                    throw new ArgumentException();
                }

                _age = value;
            }
        }

        private static void VerifyName(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }

            if (value.Length < MIN_NAME_LENGTH)
            {
                throw new ArgumentException();
            }
        }

        public override string ToString()
        {
            string result = String.Format("My first name is {0}, my last name is {1}, my age is {2}",
                FirstName, LastName, Age);
            return result;
        }

        public abstract void Work();
    }
}
