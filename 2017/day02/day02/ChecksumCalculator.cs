using System.Linq;

namespace day02
{
    public static class ChecksumCalculator
    {
        public static int GetChecksumForPartA(int[][] input)
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

        public static int GetChecksumForPartB(int[][] input)
        {
            int checksum = 0;

            foreach (int[] row in input)
                for (int i = 0; i < row.Length; i++)
                    for (int j = 0; j < row.Length; j++)
                    {
                        if (i == j)
                            continue;

                        if (row[i] % row[j] == 0)
                        {
                            checksum += row[i] / row[j];
                            i = j = row.Length + 1;
                        }
                        else if (row[j] % row[i] == 0)
                        {
                            checksum += row[j] / row[i];
                            i = j = row.Length + 1;
                        }
                    }

            return checksum;
        }
    }
}
