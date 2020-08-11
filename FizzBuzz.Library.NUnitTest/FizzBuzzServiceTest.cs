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
            // Arrange 
            IEnumerable<string> expectedValues = File.ReadLines("FizzBuzz.txt");

            // Act
            IFizzBuzzService fizzBuzzService = new FizzBuzzService();
            var output = fizzBuzzService.GetFizzBuzz(100);

            // Assert
            Assert.AreEqual(expectedValues, output);
        }
    }
}