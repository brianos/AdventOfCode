using System;
using System.Collections.Generic;
using System.Linq;

namespace day07
{
    public class TowerBalancer
    {
        public static int GetBalancedWeight(IEnumerable<ProgramInfo> input)
        {
            ProgramInfo rootElement = GetRootElement(input);

            var firstLevelChildrenWithSupportingWeight = rootElement
                                                        .Supporting
                                                        .Select(x => new
                                                            Tuple<string, int>(x, GetTowerWeight(input, x)));

            var weightAggregate = firstLevelChildrenWithSupportingWeight
                                .GroupBy(x => x.Item2)
                                .Select(group => new
                                {
                                    Weight = group.Key,
                                    Count = group.Count()
                                }).ToArray();


            var firstLevelChildWithDifferentWeightName = firstLevelChildrenWithSupportingWeight
                                            .Where(x => x.Item2 == weightAggregate.Where(y => y.Count == 1).First().Weight)
                                            .First();

            var firstLevelChildWithDifferentWeight = GetElement(input, firstLevelChildWithDifferentWeightName.Item1);

            var weightDifference = Math.Abs(weightAggregate[0].Weight - weightAggregate[1].Weight);

            return Math.Abs(firstLevelChildWithDifferentWeight.Weight - weightDifference);
        }

        private static int GetTowerWeight(IEnumerable<ProgramInfo> input, string elementName)
        {
            var element = GetElement(input, elementName);

            int weight = 0;

            if (element.Supporting != null)
            {
                foreach (var item in element.Supporting)
                {
                    weight += GetTowerWeight(input, item);
                }
            }

            return element.Weight + weight;
        }

        private static ProgramInfo GetRootElement(IEnumerable<ProgramInfo> input)
        {
            var rootElementName = RootElementLocator.GetRootElement(input);
            return GetElement(input, rootElementName);
        }

        private static ProgramInfo GetElement(IEnumerable<ProgramInfo> input, string elementName)
        {
            return input.Where(x => x.Name == elementName).First();
        }
    }
}
