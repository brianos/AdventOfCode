using System;
using System.Collections.Generic;
using System.Linq;

namespace day08
{
    public class RegisterProcessor
    {
        public static Tuple<int, int> Process(IEnumerable<string> inputData)
        {
            const int operationTarget = 0;
            const int operation = 1;
            const int operationAmount = 2;
            const int testRegister = 4;
            const int test = 5;
            const int testAmount = 6;

            int maxValueSeen = 0;
            var registers = new Dictionary<string, int>();

            foreach (var line in inputData.ToArray())
            {
                var inputSegments = line.Split(' ');
                EnsureRegisterIsInitialised(registers, inputSegments[operationTarget]);
                EnsureRegisterIsInitialised(registers, inputSegments[testRegister]);

                if (ConditionValid(registers,
                                inputSegments[testRegister],
                                inputSegments[test],
                                int.Parse(inputSegments[testAmount])))
                {
                    UpdateRegister(registers,
                                inputSegments[operationTarget],
                                inputSegments[operation],
                                int.Parse(inputSegments[operationAmount]));
                }

                maxValueSeen =
                    maxValueSeen < GetMaxValueInRegisters(registers) ? GetMaxValueInRegisters(registers) : maxValueSeen;
            }

            return new Tuple<int, int>(GetMaxValueInRegisters(registers), maxValueSeen);
        }

        private static int GetMaxValueInRegisters(Dictionary<string, int> registers)
        {
            return registers.Max(x => x.Value);
        }

        private static bool ConditionValid(Dictionary<string, int> registers, string register, string operation, int comparisonValue)
        {
            int currentRegisterValue = registers[register];

            bool returnValue = false;

            switch (operation)
            {
                case "==":
                    returnValue = currentRegisterValue == comparisonValue;
                    break;

                case ">":
                    returnValue = currentRegisterValue > comparisonValue;
                    break;

                case "<":
                    returnValue = currentRegisterValue < comparisonValue;
                    break;

                case ">=":
                    returnValue = currentRegisterValue >= comparisonValue;
                    break;

                case "<=":
                    returnValue = currentRegisterValue <= comparisonValue;
                    break;

                case "!=":
                    returnValue = currentRegisterValue != comparisonValue;
                    break;
            }
            return returnValue;
        }

        private static void UpdateRegister(Dictionary<string, int> registers, string operationTarget, string operation, int operationAmount)
        {
            if (operation == "inc")
            {
                registers[operationTarget] += operationAmount;
            }
            else
            {
                registers[operationTarget] -= operationAmount;
            }
        }

        private static void EnsureRegisterIsInitialised(Dictionary<string, int> registers, string registerName)
        {
            if (!registers.ContainsKey(registerName))
            {
                registers.Add(registerName, 0);
            }
        }
    }
}
