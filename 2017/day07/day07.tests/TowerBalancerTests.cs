using NUnit.Framework;

namespace day07.tests
{
    [TestFixture]
    public class TowerBalancerTests
    {
        [Test]
        public void TestsSuppliedForPartB()
        {
            var inputData = EmbeddedResourceReader.Read("day07.tests.input.TestSuppliedInputFromAdventOfCode.txt");
            var parsedInputData = InputDataParser.Parse(inputData);
            var result = TowerBalancer.GetBalancedWeight(parsedInputData);
            Assert.AreEqual(60, result);
        }

        [Test]
        public void GetProblemSolutionForPartB()
        {
            var inputData = EmbeddedResourceReader.Read("day07.tests.input.ProblemInputFromAdventOfCode.txt");
            var parsedInputData = InputDataParser.Parse(inputData);
            var result = TowerBalancer.GetBalancedWeight(parsedInputData);
            Assert.AreEqual(-1000000, result);
        }
    }
}
