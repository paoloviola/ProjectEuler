using ProjectEuler.Common;
using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter1
{
    [ProblemSolved]
    internal class Problem3 : IProblem
    {
        public string Name => "Largest prime factor";
        public string TestResult => "29";
        public string SolveResult => "6857";

        public string Test()
        {
            return LargestPrimeFactorOf(13195).ToString();
        }

        public string Solve()
        {
            return LargestPrimeFactorOf(600851475143).ToString();
        }

        private static long LargestPrimeFactorOf(long num)
        {
            long largestPrime = 2;
            for (long i = 3; i < Math.Sqrt(num); i++)
            {
                if (i.IsPrime() && num % i == 0)
                {
                    largestPrime = i;
                }
            }
            return largestPrime;
        }
    }
}
