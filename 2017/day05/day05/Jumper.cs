using System;
using System.Linq;

namespace day05
{
    public class Jumper
    {
        public static int ProcessorForPartA(string offsets)
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
                    currentOffset++;
                    offsetArray[currentPosition] = currentOffset;
                    currentPosition = newPosition;
                }

            } while (true);

            return jumpsRequired;
        }
    }
}
