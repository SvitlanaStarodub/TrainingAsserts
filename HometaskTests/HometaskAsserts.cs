using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Hometask;
using HometaskTests;
using NUnit.Framework;


namespace HometaskAsserts
{
    [TestFixture()]
    class HometaskAsserts
    {
        [TestCase("FirstNameIsMatched")]
        public void StringCompare(string firstName)
        {
            //arrange
            string actual = "Olga";
            //act
            Assert.That(actual, Is.EqualTo("Olga"), "Expected name is not matched with actual");
        }

        [TestCase("FirstNameIsNotMatched")]
        public void Name_Is_Not_Matched(string name)
        {
            string actual = "Oleg";
            Assert.That(actual, Is.Not.EqualTo("Olga"), "Expected name is matched with actual");
        }

        [TestCase(8, 9)]
        public void Employee_Age(int number1, int number2)
        {
            //arrange
            int sum = number1 + number2;

            //act
            Assert.That(sum, Is.Not.GreaterThan(17), "Employee age is less than required age");

        }

        [TestCase(18)]
        [TestCase(60)]
        public void Boundary(int age)
        {
            Assert.That(age, Is.InRange(18, 60), "Numbers are in required range.")
                ;

        }

        [TestCase(2)]
        public void Not_In_Range(int value)
        {
            Assert.That(value, Is.Not.InRange(18, 60), "Number is part of range 18-60");
        }

        [TestCase]
        public void Array_Not_Null()
        {
            string[] array = {"one", "two", "three"};
            Assert.That(array, Is.Not.Null, "An array is Null");
        }

        [TestCase]
        public void Boolean_Value()
        {
            bool value = true;
            Assert.That(value, Is.True, "Value should be true.");
        }

        [TestCase]
        public void Collection_Is_Not_Empty()
        {
            //arrange
            List<string> POM = new List<string>()
            {
                "IOF",
                "EOF",
                "AllocHedges"
            };
            //assert
            Assert.That(POM, Is.All.Not.Empty, "String value should be empty");
        }

        [TestCase]
        public void Collection_Contains_Value()
        {
            //arrange
            List<string> Candies = new List<string>()
            {
                "Twix",
                "Lolly-pop",
                "Snickers"
            };
            //assert
            Assert.That(Candies, Contains.Item("Lolly-pop"), "The collection should contains specific value");
        }

        [TestCase]
        public void Collection_Contains_Substring()
        {
            //arrange
            List<string> Candies = new List<string>()
            {
                "Twix",
                "Lolly-pop",
                "Snickers",
                "Toblerone"
            };
            //assert
            Assert.That(Candies, Has.Some.ContainsSubstring("pop"), "The collection should contains specific value");
        }

        [TestCase]
        public void Collection_Value_Starts_With()
        {
            //arrange
            List<string> Candies = new List<string>()
            {
                "Twix",
                "Lolly-pop",
                "Snickers",
                "Toblerone"
            };
            //assert
            Assert.That(Candies, Has.Exactly(2).StartWith("T"),
                "A value in the collection should contains a custom value StartWith");
        }

        [TestCase]
        public void Collection_Value_Is_Unique()
        {
            //arrange
            List<string> candies = new List<string>()
            {
                "Twix",
                "Lolly-pop",
                "Snickers",
                "Toblerone"
            };

            //assert
            Assert.That(candies, Is.Unique, "Values in the collection should be unique");
        }

        [TestCase]
        public void Collection_Value_Is_As_Expected()
        {
            //arrange
            var food = new Food();
            var expected = new[]
            {
                "Twix",
                "Lolly-pop",
                "Snickers",
                "Toblerone"
            };

            //assert
            Assert.That(food.Candies, Is.EquivalentTo(expected), "Values in the collection should match expected");
        }

        [TestCase]
        public void Collection_Value_Is_Ordered()
        {
            //arrange
            var food = new Food();
            //assert
            Assert.That(food.Candies, Is.Ordered, "Value in collection should be in alphabetical order");

        }

        [TestCase]
        public void Collection_Instance_References()
        {
            //arrange
            var food1 = new Food();
            var food2 = new Food();
            //assert
            Assert.That(food1, Is.Not.SameAs(food2), "Instances should have different references");

        }
    }
}
