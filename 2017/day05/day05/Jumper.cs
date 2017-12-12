using System;
using System.Linq;

namespace day05
{
    public class Jumper
    {
        public static int Process(string offsets, Func<int, int> incrementStrategy)
        {
            int[] offsetArray = offsets.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

            int jumpsRequired = 0;
            int currentPosition = 0;

            do
            {
                jumpsRequired++;

                int currentOffset = offsetArray[currentPosition];

                int newPosition = currentPosition + currentOffset;

                if (newPosition >= offsetArray.Length)
                {
                    break;
                }
                else
                {
                    offsetArray[currentPosition] = incrementStrategy(currentOffset);
                    currentPosition = newPosition;
                }

            } while (true);

            return jumpsRequired;
        }

        public static int IncrementStrategyForPartA(int currentOffset)
        {
            return ++currentOffset;
        }

        public static int IncrementStrategyForPartB(int currentOffset)
        {
            if (currentOffset >= 3)
            {
                currentOffset--;
            }
            else
            {
                currentOffset++;
            }
            return currentOffset;
        }
    }
}
