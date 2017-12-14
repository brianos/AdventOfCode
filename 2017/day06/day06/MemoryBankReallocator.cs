using System.Collections.Generic;
using System.Linq;
using System;

namespace day06
{
    public class MemoryBankReallocator
    {
        public static int Reallocate(ref int[] memoryBanks)
        {
            var knownStates = new List<string>();
            do
            {
                knownStates.Add(ConvertIntegerArrayToStringRepresentation(memoryBanks));

                var maxMemoryBankSize = memoryBanks.Max();
                var maxMemoryBankLocation = Array.IndexOf(memoryBanks, maxMemoryBankSize);

                var reallocationPointer = maxMemoryBankLocation + 1 == memoryBanks.Length ? 0 : maxMemoryBankLocation + 1;

                memoryBanks[maxMemoryBankLocation] = 0;

                for (int i = 0; i < maxMemoryBankSize; i++)
                {
                    memoryBanks[reallocationPointer++]++;
                    reallocationPointer = reallocationPointer == memoryBanks.Length ? 0 : reallocationPointer;
                }
            } while (!knownStates.Contains(ConvertIntegerArrayToStringRepresentation(memoryBanks)));

            return knownStates.Count;
        }

        public static int ReallocateTwice(int[] memoryBanks)
        {
            Reallocate(ref memoryBanks);
            return Reallocate(ref memoryBanks);
        }

        private static string ConvertIntegerArrayToStringRepresentation(int[] memoryBanks)
        {
            return String.Join("", memoryBanks);
        }
    }
}
