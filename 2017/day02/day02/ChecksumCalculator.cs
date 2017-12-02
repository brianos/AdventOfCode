using System.Linq;

namespace day02
{
    public static class ChecksumCalculator
    {
        public static int GetChecksum(int[][] input)
        {
            int checksum = 0;
            foreach (int[] row in input)
            {
                int min = row.Min(x => x);
                int max = row.Max(x => x);
                int difference = max - min;
                checksum += difference;
            }
            return checksum;
        }
    }
}
