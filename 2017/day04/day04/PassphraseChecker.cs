using System.Linq;

namespace day04
{
    public static class PassphraseChecker
    {
        public static int PassphrasesValidPartA(string[] passphrases)
        {
            int countOfValidPassphrases = 0;

            foreach (var passphrase in passphrases)
            {
                if (!passphrase.Split(' ').GroupBy(x => x.GetHashCode()).Any(g => g.Count() > 1))
                {
                    countOfValidPassphrases++;
                }
            }

            return countOfValidPassphrases;
        }
    }
}
