using System.Collections.Generic;
using System.Linq;

namespace day07.tests
{
    public static class InputDataParser
    {
        private const char inputLineDelimiter = '\n';
        private const char nameEndDelimiter = ' ';
        private const char weightStartDelimiter = '(';
        private const char weightEndDelimiter = ')';
        private const string supportingOtherNodesIndicator = "->";
        private const char supportingOtherNodesDelimiter = ',';

        public static IEnumerable<ProgramInfo> Parse(string input)
        {
            return input.Split(inputLineDelimiter).Select(x => ParseProgramInfo(x));
        }

        private static ProgramInfo ParseProgramInfo(string line)
        {
            var weightStartsAt = line.IndexOf(weightStartDelimiter) + 1;
            var weightLength = line.IndexOf(weightEndDelimiter) - weightStartsAt;

            var programInfo = new ProgramInfo
            {
                Name = line.Substring(0, line.IndexOf(nameEndDelimiter)),
                Weight = int.Parse(line.Substring(line.IndexOf(weightStartDelimiter) + 1, weightLength)),
                Supporting = ParseSupportingInfo(line)
            };
            return programInfo;
        }

        private static IList<string> ParseSupportingInfo(string line)
        {
            if (!line.Contains(supportingOtherNodesIndicator)) return null;

            return line.Substring(line.IndexOf(supportingOtherNodesIndicator) + 3)
                        .Replace(" ", "")
                        .Replace("\r", "")
                        .Split(supportingOtherNodesDelimiter)
                        .ToList();
        }
    }
}
