using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Hometask;
using NUnit.Framework;

namespace HometaskTests
{
    [TestFixture]
    class EmployeeAssert
    {
        [TestCase("Name", "LastName", 18)]
        public void Age_Negative(string firstName, string lastName, int age)
        {
            //arrange
            var employee = new Manager(firstName, lastName, age);
            //act, assert

            Assert.Throws<ArgumentException>(() => { employee.Age = 16; }, "Age is less than required");
        }

        [TestCase("Name", "LastName", 18)]
        public void Age_Positive(string firstName, string lastName, int age)
        {
            //arrange
            var employee = new Manager(firstName, lastName, age);
            //act
            employee.Age = 32;
            //assert
            Assert.That(employee.Age, Is.InRange(17, 60), "Age should be in range.");
            Assert.That(employee.Age, Is.EqualTo(32), "Age should be updated correctly.");
        }
    }
}
