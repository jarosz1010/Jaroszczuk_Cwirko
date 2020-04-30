
using NUnit.Framework;
using System.Collections.Generic;
using Fizzer;
namespace FizzBuzzTester
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FizzBuzzTest()
        {
            List<int> numbers = new List<int>() { 15, 532, 350 };
            List<string> expectedResults = new List<string>() { "FizzBuzz", "FizzBuzz", "FizzBuzz" };
            var actualResluts = FizzBuzz.MillNumbers(numbers);
            Assert.AreEqual(expectedResults[0], actualResluts[0]);
        }

        [Test]
        public void BuzzTest()
        {
            List<int> numbers = new List<int>() { 1, 5, 10, 51 };
            List<string> expectedResults = new List<string>() { "1", "Buzz", "Buzz", "Buzz" };
            var actualResluts = FizzBuzz.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults, actualResluts);
        }
        [Test]
        public void BuzzingaTest()
        {
            List<int> numbers = new List<int>() { 7, 21, 70 };
            List<string> expectedResults = new List<string>() { "Buzzinga", "Buzzinga", "Buzzinga" };
            var actualResluts = FizzBuzz.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults, actualResluts);
        }
        [Test]
        public void FizzTest()
        {
            List<int> numbers = new List<int>() { 3, 6, 9, 12 };
            List<string> expectedResults = new List<string>() { "Fizz", "Fizz", "Fizz", "Fizz" };
            var actualResluts = FizzBuzz.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults, actualResluts);
        }

        [Test]
        public void MoreRealisticTest()
        {
            List<int> numbers = new List<int>() {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<string> expectedResults = new List<string>() {
                "1","2","Fizz","4","Buzz","Fizz","Buzzinga","8","Fizz","Buzz",
                 "11","Fizz","13","Buzzinga","FizzBuzz","16","17","Fizz","19","Buzz"};
            var actualResluts = FizzBuzz.MillNumbers(numbers);
            CollectionAssert.AreEqual(expectedResults, actualResluts);
        }
    }
}