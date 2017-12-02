namespace day01
{
    public static class Processor
    {
        public static int Process(string input)
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
    }
}
