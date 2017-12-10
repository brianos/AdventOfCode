namespace day01
{
    public static class CaptchaChecker
    {
        public static int PartA(string input)
        {
            string inputWrapAround = input + input[0];

            int result = 0;
            int lastNumber = -1;
            foreach (char charNumber in inputWrapAround)
            {
                int currentNumber = int.Parse(charNumber.ToString());
                if (currentNumber == lastNumber)
                {
                    result += currentNumber;
                }
                lastNumber = currentNumber;
            }
            return result;
        }

        public static int PartB(string input)
        {
            string inputCircular = input + input;
            int charactersToProcess = input.Length;

            int result = 0;
            for (int i = 0; i < charactersToProcess; i++)
            {
                int numberToCompareIndex = i + (charactersToProcess / 2);
                int numberToCompare = int.Parse(inputCircular[numberToCompareIndex].ToString());

                int currentNumber = int.Parse(inputCircular[i].ToString());

                if (currentNumber == numberToCompare)
                {
                    result += currentNumber;
                }
            }
            return result;
        }
    }
}
