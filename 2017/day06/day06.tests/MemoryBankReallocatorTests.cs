using NUnit.Framework;

namespace day06.tests
{
    [TestFixture]
    public class MemoryBankReallocatorTests
    {
        [Test]
        public void TestsSuppliedForPartA()
        {
            var memoryBanks = new int[4] { 0, 2, 7, 0 };

            var result = MemoryBankReallocator.Reallocate(memoryBanks);

            Assert.AreEqual(5, result);
        }

        [Test]
        public void GetProblemSolutionForPartA()
        {
            var memoryBanks =
                new int[16] { 2, 8, 8, 5, 4, 2, 3, 1, 5, 5, 1, 2, 15, 13, 5, 14 };

            var result = MemoryBankReallocator.Reallocate(memoryBanks);

            Assert.AreEqual(3156, result);
        }
    }
}
