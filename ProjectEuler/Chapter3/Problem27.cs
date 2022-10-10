using ProjectEuler.Common;
using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter3
{
    [ProblemSolved]
    internal class Problem27 : IProblem
    {
        public string Name => "Quadratic primes";
        public string TestResult => "";
        public string SolveResult => "-59231";

        public string Test()
        {
            return "";
        }

        public string Solve()
        {
            return ProductOfMaximumAB(1000, 1001).ToString();
        }

        private static int CountPrimes(int a, int b)
        {
            int count = 0;
            for(int n = 0; ; n++)
            {
                int prime = n * n + a * n + b;
                if (!prime.IsPrime())
                {
                    return count;
                }
                count++;
            }
        }

        private static int ProductOfMaximumAB(int maxA, int maxB)
        {
            int maximumA = 0;
            int maximumB = 0;
            int maximumPrimes = 0;
            for(int a = -maxA; a < maxA; a++)
            {
                for(int b = -maxB; b < maxB; b++)
                {
                    int primes = CountPrimes(a, b);
                    if(maximumPrimes < primes)
                    {
                        maximumPrimes = primes;
                        maximumA = a;
                        maximumB = b;
                    }
                }
            }

            return maximumA * maximumB;
        }
    }
}
