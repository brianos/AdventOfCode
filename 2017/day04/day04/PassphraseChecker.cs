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

        public static int PassphrasesValidPartB(string[] passphrases)
        {
            int countOfValidPassphrases = 0;

            foreach (string passphrase in passphrases)
            {
                if (!passphrase.Split(' ')
                    .Select(p => new string(p.OrderBy(c => c).ToArray()))
                    .GroupBy(x => x.GetHashCode()).Any(g => g.Count() > 1))
                {
                    countOfValidPassphrases++;
                }
            }

            return countOfValidPassphrases;
        }
    }
}
