using NUnit.Framework;

namespace day03.tests
{
    [TestFixture]
    public class SpiralMemoryTests
    {
        [TestCase(1, ExpectedResult = 0)]
        [TestCase(12, ExpectedResult = 3)]
        [TestCase(23, ExpectedResult = 2)]
        [TestCase(1024, ExpectedResult = 31)]
        public int TestsSuppliedForPartA(int memoryValue)
        {
            return SpiralMemory.GetManhattanDistanceForMemoryValue(memoryValue);
        }

        [Test]
        public void GetProblemSolutionForPartA()
        {
            var result = SpiralMemory.GetManhattanDistanceForMemoryValue(312051);

            Assert.AreEqual(430, result);
        }
    }
}
