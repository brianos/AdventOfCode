using System;
using System.Collections.Generic;

namespace day03
{
    public class SpiralMemory
    {
        public static int GetManhattanDistanceForMemoryValue(int memoryValue)
        {
            Dictionary<int, Tuple<int, int>> memory = PopulateMemory(memoryValue);
            return CalculateManhattanDistance(memoryValue, memory);
        }

        private static Dictionary<int, Tuple<int, int>> PopulateMemory(int memoryValue)
        {
            var memory = new Dictionary<int, Tuple<int, int>>();

            int cycleCounter = 1;
            PopulationDirection populationDirection = 0;
            int x = 0;
            int y = 0;

            for (int currentMemoryValue = 1; currentMemoryValue <= memoryValue; currentMemoryValue++)
            {
                memory.Add(currentMemoryValue, new Tuple<int, int>(x, y));

                switch (populationDirection)
                {
                    case PopulationDirection.Right:
                        x++;
                        if (x == cycleCounter)
                        {
                            populationDirection++;
                        }
                        break;

                    case PopulationDirection.Up:
                        y++;
                        if (y == cycleCounter)
                        {
                            populationDirection++;
                        }
                        break;

                    case PopulationDirection.Left:
                        x--;
                        if (Math.Abs(x) == cycleCounter)
                        {
                            populationDirection++;
                        }
                        break;

                    case PopulationDirection.Down:
                        y--;
                        if (Math.Abs(y) == cycleCounter)
                        {
                            populationDirection = 0;
                            cycleCounter++;
                        }
                        break;
                }
            }
            return memory;
        }

        private static int CalculateManhattanDistance(int memoryValue, Dictionary<int, Tuple<int, int>> memory)
        {
            var memoryCoordinates = memory[memoryValue];
            var x = Math.Abs(memoryCoordinates.Item1);
            var y = Math.Abs(memoryCoordinates.Item2);
            return (x + y);
        }

        private enum PopulationDirection
        {
            Right = 0,
            Up = 1,
            Left = 2,
            Down = 3
        }
    }
}
