using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace FizzBuzz.Library.NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var path = Path.Combine(TestContext.CurrentContext.TestDirectory, "FizzBuzz.txt");

            Console.WriteLine(path);
            // Arrange 
            IEnumerable<string> expectedValues = File.ReadLines(path);

            // Act
            var service = new FizzBuzzService();
            var output = service.GetFizzBuzz(1, 100);
            // Assert
            Assert.AreEqual(expectedValues, output);
        }
    }
}