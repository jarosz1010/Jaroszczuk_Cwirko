using NUnit.Framework;
using Zadanie1;
using System;
namespace Tests
{

    

    public class boolToWordTest
    {

        [Test]
        public void boolToWordReturned1()
        {
            Assert.AreEqual("Yes", Kata.boolToWord(true));
            Console.WriteLine("Expected Yes");
        }

        [Test]
        public void boolToWordReturned2()
        {
            Assert.AreEqual("No", Kata.boolToWord(false));
            Console.WriteLine("Expected No");
        }

        [Test]
        public void boolToWordReturned3()
        {
            Assert.AreEqual("Yes", Kata.boolToWord(true));
            Console.WriteLine("Expected Yes");
        }
    }
}