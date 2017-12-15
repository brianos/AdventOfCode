using NUnit.Framework;

namespace day07.tests
{
    [TestFixture]
    public class RootElementLocatorTests
    {
        [Test]
        public void TestsSuppliedForPartA()
        {
            var inputData = EmbeddedResourceReader.Read("day07.tests.input.TestSuppliedInputFromAdventOfCode.txt");
            var parsedInputData = InputDataParser.Parse(inputData);
            var result = RootElementLocator.GetRootElement(parsedInputData);
            Assert.AreEqual("tknk", result);
        }

        [Test]
        public void GetProblemSolutionForPartA()
        {
            var inputData = EmbeddedResourceReader.Read("day07.tests.input.ProblemInputFromAdventOfCode.txt");
            var parsedInputData = InputDataParser.Parse(inputData);
            var result = RootElementLocator.GetRootElement(parsedInputData);
            Assert.AreEqual("hmvwl", result);
        }
    }
}
