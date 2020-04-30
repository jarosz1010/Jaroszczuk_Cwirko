using NUnit.Framework;
using Zadanie2;
namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StaticTests()
        {
            Assert.AreEqual(Kalkulator.BasicOp('+', 4, 7), 11);
            Assert.AreEqual(Kalkulator.BasicOp('-', 15, 18), -3);
            Assert.AreEqual(Kalkulator.BasicOp('*', 5, 5), 25);
            Assert.AreEqual(Kalkulator.BasicOp('/', 49, 7), 7);
        }
    }
}