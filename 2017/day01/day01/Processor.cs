namespace day01
{
    public static class Processor
    {
        public static int PartA(string input)
        {
            string inputWithFirstCharacterAppendedToEnd = input + input[0];

            int result = 0;
            int lastNumber = -1;
            foreach (char charNumber in inputWithFirstCharacterAppendedToEnd)
            {
                int number = int.Parse(charNumber.ToString());
                if (number == lastNumber)
                {
                    result += number;
                }
                lastNumber = number;
            }
            return result;
        }

        public static int PartB(string input)
        {
            string inputDuplicated = input + input;
            int charactersToProcess = input.Length;

            int result = 0;
            for (int i = 0; i < charactersToProcess; i++)
            {
                int numberToCompareIndex = i + (charactersToProcess / 2);
                int numberToCompare = int.Parse(inputDuplicated[numberToCompareIndex].ToString());

                int number = int.Parse(inputDuplicated[i].ToString());

                if (number == numberToCompare)
                {
                    result += number;
                }
            }
            return result;
        }
    }
}
