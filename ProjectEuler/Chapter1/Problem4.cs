using ProjectEuler.Common.Problem;
using System.Text;

namespace ProjectEuler.Chapter1
{
    [ProblemSolved]
    internal class Problem4 : IProblem
    {
        public string Name => "Largest palindrome product";
        public string TestResult => "9009";
        public string SolveResult => "906609";

        public string Test()
        {
            return LargestPalindrome(2).ToString();
        }

        public string Solve()
        {
            return LargestPalindrome(3).ToString();
        }

        private static long LargestPalindrome(int numDigits)
        {
            long largestPalindrome = 0;
            long maxNumber = GetMaxNumberByDigits(numDigits);
            for (long i = 0; i <= maxNumber; i++)
            {
                for (long j = 0; j <= maxNumber; j++)
                {
                    if (ReadsTheSameBothWays(i * j) && largestPalindrome < i * j)
                    {
                        largestPalindrome = i * j;
                    }
                }
            }

            return largestPalindrome;
        }

        private static long GetMaxNumberByDigits(int numDigits)
        {
            var num = new StringBuilder();
            for (var i = 0; i < numDigits; i++)
            {
                num.Append('9');
            }
            return long.Parse(num.ToString());
        }

        private static bool ReadsTheSameBothWays(long num)
        {
            var reverse = new StringBuilder();
            foreach (var c in num.ToString().Reverse())
            {
                reverse.Append(c);
            }
            return num.ToString() == reverse.ToString();
        }
    }
}
