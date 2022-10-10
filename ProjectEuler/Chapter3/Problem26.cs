using ProjectEuler.Common;
using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter3
{
    [ProblemSolved]
    internal class Problem26 : IProblem
    {
        public string Name => "Reciprocal cycles";
        public string TestResult => "7";
        public string SolveResult => "983";

        public string Test()
        {
            return FindLongestReccuringCycle(11).ToString();
        }

        public string Solve()
        {
            return FindLongestReccuringCycle(1000).ToString();
        }

        private static int GCD(int n0, int n1)
        {
            // Calculate the greatest common divider with euklids algorithm
            // CR: https://studyflix.de/mathematik/groesster-gemeinsamer-teiler-ggt-2642
            return n1 == 0 ? n0 : GCD(n1, n0 % n1);
        }

        private static int MultiplicativeOrder(int g, int z)
        {
            // Implementation of: https://www.youtube.com/watch?v=1PPsziS1D_k

            int product = 1;
            for(int i = 1; true; i++)
            {
                product = (product * g) % z;
                if(product == 1)
                {
                    return i;
                }
            }
        }

        private static int FindLongestReccuringCycle(int limit)
        {
            // https://euler.beerbaronbill.com/en/latest/solutions/26.html
            int longestDivisor = 0;
            int longestReccuring = 0;
            for(int i = 2; i < limit; i++)
            {
                if(!i.IsPrime() || i == 2 || i == 5)
                {
                    continue;
                }

                int reccuring = MultiplicativeOrder(10, i);
                if(longestReccuring < reccuring)
                {
                    longestReccuring = reccuring;
                    longestDivisor = i;
                }
            }
            return longestDivisor;
        }
    }
}
