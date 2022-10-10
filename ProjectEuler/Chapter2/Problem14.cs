using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter2
{
    [ProblemSolved]
    internal class Problem14 : IProblem
    {
        public string Name => "Longest Collatz sequence";
        public string TestResult => "10";
        public string SolveResult => "837799";

        public string Test()
        {
            return CountSequence(13).ToString();
        }

        public string Solve()
        {
            return FindNumberOfLongestSequenceUnder(1000000).ToString();
        }

        private static int FindNumberOfLongestSequenceUnder(int num)
        {
            int longestNumber = 0;
            long longestSequence = 0;
            for (int i = 1; i < num; i++)
            {
                int currentSequence = CountSequence(i);
                if (longestSequence < currentSequence)
                {
                    longestSequence = currentSequence;
                    longestNumber = i;
                }
            }
            return longestNumber;
        }

        private static int CountSequence(long num)
        {
            for (int i = 1; ; i++)
            {
                num = num % 2 == 0 ? num / 2 : 3 * num + 1;
                if (num == 1)
                {
                    return i + 1;
                }
            }
        }
    }
}
