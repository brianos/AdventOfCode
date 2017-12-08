using System.Linq;
using System;

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
                var passphraseSegments = passphrase.Split(' ');

                for (int i = 0; i < passphraseSegments.Length; i++)
                {
                    char[] passphraseSegmentCharacters = passphraseSegments[i].ToCharArray();
                    Array.Sort(passphraseSegmentCharacters);
                    passphraseSegments[i] = new string(passphraseSegmentCharacters);
                }

                if (!passphraseSegments.GroupBy(x => x.GetHashCode()).Any(g => g.Count() > 1))
                {
                    countOfValidPassphrases++;
                }
            }

            return countOfValidPassphrases;
        }
    }
}
