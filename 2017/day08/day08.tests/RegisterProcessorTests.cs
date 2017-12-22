using NUnit.Framework;

namespace day08.tests
{
    [TestFixture]
    public class RegisterProcessorTests
    {
        [Test]
        public void TestsSuppliedForPartA()
        {
            var inputData = EmbeddedResourceReader.Read("day08.tests.input.TestSuppliedInputFromAdventOfCode.txt");
            var parsedInputData = InputDataParser.Parse(inputData);
            var result = RegisterProcessor.Process(parsedInputData);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetProblemSolutionForPartA()
        {
            var inputData = EmbeddedResourceReader.Read("day08.tests.input.ProblemInputFromAdventOfCode.txt");
            var parsedInputData = InputDataParser.Parse(inputData);
            var result = RegisterProcessor.Process(parsedInputData);
            Assert.AreEqual(4832, result);
        }
    }
}
