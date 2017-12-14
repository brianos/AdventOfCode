using NUnit.Framework;

namespace day06.tests
{
    [TestFixture]
    public class MemoryBankReallocatorTests
    {
        private int[] testSuppliedInputFromAdventOfCode = new int[4] { 0, 2, 7, 0 };

        private int[] problemInputFromAdventOfCode = new int[16] { 2, 8, 8, 5, 4, 2, 3, 1, 5, 5, 1, 2, 15, 13, 5, 14 };

        [Test]
        public void TestsSuppliedForPartA()
        {
            var result = MemoryBankReallocator.Reallocate(ref testSuppliedInputFromAdventOfCode);

            Assert.AreEqual(5, result);
        }

        [Test]
        public void GetProblemSolutionForPartA()
        {
            var result = MemoryBankReallocator.Reallocate(ref problemInputFromAdventOfCode);

            Assert.AreEqual(3156, result);
        }

        [Test]
        public void TestsSuppliedForPartB()
        {
            var result = MemoryBankReallocator.ReallocateTwice(testSuppliedInputFromAdventOfCode);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void GetProblemSolutionForPartB()
        {
            var result = MemoryBankReallocator.ReallocateTwice(problemInputFromAdventOfCode);

            Assert.AreEqual(1610, result);
        }
    }
}
