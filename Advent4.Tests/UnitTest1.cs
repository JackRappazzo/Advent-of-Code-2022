using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Advent4.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsRedundant_SmallIntoBig()
        {
            Order small = new Order() { Start = 5, End = 10 };
            Order big = new Order() { Start = 3, End = 15 };
            Order[] orders = new Order[] { small, big };
            Pair pair = new Pair(orders);

            Assert.IsTrue(pair.IsRedundant());
        }

        [TestMethod]
        public void TestIsRedundant_SameStart()
        {
            Order small = new Order() { Start = 3, End = 10 };
            Order big = new Order() { Start = 3, End = 15 };
            Order[] orders = new Order[] { small, big };
            Pair pair = new Pair(orders);

            Assert.IsTrue(pair.IsRedundant());
        }

        [TestMethod]
        public void TestIsOverlap()
        {
            Order small = new Order() { Start = 5, End = 10 };
            Order big = new Order() { Start = 7, End = 15 };
            Order[] orders = new Order[] { small, big };
            Pair pair = new Pair(orders);

            Assert.IsTrue(pair.IsOverlapping());
        }

        [TestMethod]
        public void TestIsOverlap_SameStart()
        {
            Order small = new Order() { Start = 3, End = 10 };
            Order big = new Order() { Start = 3, End = 15 };
            Order[] orders = new Order[] { small, big };
            Pair pair = new Pair(orders);

            Assert.IsTrue(pair.IsOverlapping());
        }
    }
}