using NUnit.Framework;
using System;

namespace AssertExamples
{
    [TestFixture]
    public class AssertConstarintExamples
    {
        [Test]
        [Category("Assert")]
        public void AssertBoolExample()
        {
            bool actualValue = true;

            Assert.That(actualValue, Is.True);
            Assert.That(actualValue, Is.False);
        }

        [Test]
        [Category("Assert")]
        public void AssertIntExample()
        {
            int actualValue = 12;

            Assert.That(actualValue, Is.Positive.Or.GreaterThanOrEqualTo(10));
        }

        [Test]
        [Category("Assert")]
        public void AssertDoubleExample()
        {
            double actualValue = -100.000458665;

            Assert.That(actualValue, Is.EqualTo(-100).Within(0.0001).And.Negative);
        }

        [Test]
        [Category("Assert")]
        public void AssertDateExample()
        {
            DateTime expectedValue = new DateTime(2018, 4, 30);
            DateTime actualValue = DateTime.Now;

            Assert.That(actualValue, Is.EqualTo(expectedValue).Within(5).Days);
        }

        [Test]
        [Category("Assert")]
        public void AssertStringExample()
        {
            string actualValue = "Test STRING";

            Assert.That(actualValue, Is.EqualTo("test string").IgnoreCase);
            Assert.That(actualValue, Does.Contain("STRING"));
            Assert.That(actualValue, Does.StartWith("Tes"));
        }

        [Test]
        [Category("Assert")]
        public void AssertCollectionExample()
        {
            int[] collection1 = new int[] { 1, 2, 3 };
            int[] collection2 = new int[] { 2, 1, 3 };

            Assert.That(collection1, Is.Not.Empty);
            Assert.That(collection1, Is.EqualTo(collection2));
            Assert.That(collection1, Is.EquivalentTo(collection2));
            Assert.That(collection1, Does.Contain(1));
            Assert.That(collection1, Is.Ordered.Descending);
        }

        [Test]
        [Category("Assert")]
        public void AssertMultipleExample()
        {
            int[] collection1 = new int[] { 1, 2, 3 };
            int[] collection2 = new int[] { 2, 1, 3 };

            Assert.Multiple(() =>
            {
                Assert.That(collection1, Is.Empty);
                Assert.That(collection1, Is.EqualTo(collection2));
                Assert.That(collection1, Is.EquivalentTo(collection2));
                Assert.That(collection1, Does.Contain(1));
                Assert.That(collection1, Is.Ordered.Ascending);
            });
        }
    }
}
