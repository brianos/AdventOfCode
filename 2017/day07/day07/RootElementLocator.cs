using System.Collections.Generic;
using System.Linq;

namespace day07
{
    public class RootElementLocator
    {
        public static string GetRootElement(IEnumerable<ProgramInfo> input)
        {
            var elementsSupportingOtherItems = input.Where(x => x.Supporting?.Count > 0);

            var knownSupportedItems = elementsSupportingOtherItems.SelectMany(x => x.Supporting).ToList();

            return elementsSupportingOtherItems
                    .Where(x => x.Supporting?.Count > 0)
                    .Where(x => knownSupportedItems.Contains(x.Name) == false)
                    .First().Name;
        }
    }
}
