using System;
using System.Collections;
using System.Collections.Generic;
using Hometask;
using NUnit.Framework;


namespace HometaskTests
{
    [TestFixture]
    public class HometaskTests
    {
       

        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("Start test");
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Finish test");
        }

        [Test]
        [TestCase("Olga","Simonova", 18)]
        [TestCase("Ema","Sop", 60)]
        public void Add_Employee_List(string firstName, string lastName, int age)
        {
            //arrange
            var employee = new Programmer(firstName, lastName, age);
            var departament = new Department();
            //act
            departament.Add(employee);
            //assert
            Assert.True(departament.GetAll().Contains(employee), "Employee should be added.");

        }

        [Test]
        public void Verify_Employee_Null()
        {
            //arrange
            var departament = new Department();
           
            //act, assert
            Assert.Throws<NullReferenceException>(() => departament.Add(null),"Employee should not be Null.");
            }

       [Test]
        public void Verify_Employee_GetAll()
        {
            //arrange
            List<Employee> employee = new List<Employee>();
            employee.Add(new Manager("Max", "Kirov", 42));
            employee.Add(new Manager("Lisa", "Fomenko", 32));
            var departament = new Department();
            //act
            departament.GetAll();
            
            //assert
            Assert.AreEqual(2, employee.Count, "Not all employees from the List are back.");
        }


    }
}
