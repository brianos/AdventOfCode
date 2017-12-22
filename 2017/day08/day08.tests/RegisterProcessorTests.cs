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
            Assert.AreEqual(1, result.Item1);
        }

        [Test]
        public void GetProblemSolutionForPartA()
        {
            var inputData = EmbeddedResourceReader.Read("day08.tests.input.ProblemInputFromAdventOfCode.txt");
            var parsedInputData = InputDataParser.Parse(inputData);
            var result = RegisterProcessor.Process(parsedInputData);
            Assert.AreEqual(4832, result.Item1);
        }

        [Test]
        public void TestsSuppliedForPartB()
        {
            var inputData = EmbeddedResourceReader.Read("day08.tests.input.TestSuppliedInputFromAdventOfCode.txt");
            var parsedInputData = InputDataParser.Parse(inputData);
            var result = RegisterProcessor.Process(parsedInputData);
            Assert.AreEqual(10, result.Item2);
        }

        [Test]
        public void GetProblemSolutionForPartB()
        {
            var inputData = EmbeddedResourceReader.Read("day08.tests.input.ProblemInputFromAdventOfCode.txt");
            var parsedInputData = InputDataParser.Parse(inputData);
            var result = RegisterProcessor.Process(parsedInputData);
            Assert.AreEqual(5443, result.Item2);
        }
    }
}
