using Advent1.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Advent1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        string input = @"1
2
5

3
4
5

10
20
30";
        [TestMethod]
        public void TestParser()
        {
            var output = CalorieParser.Parse(input);

            Assert.IsNotNull(output);
            Assert.IsTrue(output[0][0] == 1);
            Assert.IsTrue(output[0][1] == 2);
        }

        [TestMethod]
        public void TestMinderSingle()
        {
            ElfStats stats = new ElfStats(input);
            var highest = stats.GetHighestCalories();

            Assert.IsTrue(highest == 60);

        }

        [TestMethod]
        public void TestMinderTwo()
        {
            ElfStats stats = new ElfStats(input);
            var highest = stats.GetHighestCalories(2);

            Assert.IsTrue(highest == 72);
        }
    }
}