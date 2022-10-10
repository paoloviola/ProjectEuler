using ProjectEuler.Common;
using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter1
{
    [ProblemSolved]
    internal class Problem7 : IProblem
    {
        public string Name => "10001st prime";
        public string TestResult => "13";
        public string SolveResult => "104743";

        public string Test()
        {
            return GetPrimeNumberOf(6).ToString();
        }

        public string Solve()
        {
            return GetPrimeNumberOf(10001).ToString();
        }

        private static long GetPrimeNumberOf(int num)
        {
            long lastPrime = 0;
            long primesFound = 0;
            for (int i = 0; primesFound < num; i++)
            {
                if (i.IsPrime())
                {
                    primesFound++;
                    lastPrime = i;
                }
            }
            return lastPrime;
        }
    }
}
