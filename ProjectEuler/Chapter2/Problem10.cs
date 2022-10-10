using ProjectEuler.Common;
using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter2
{
    [ProblemSolved]
    internal class Problem10 : IProblem
    {
        public string Name => "Summation of primes";
        public string TestResult => "17";
        public string SolveResult => "142913828922";

        public string Test()
        {
            return SumOfPrimesBelow(10).ToString();
        }

        public string Solve()
        {
            return SumOfPrimesBelow(2000000).ToString();
        }

        private static long SumOfPrimesBelow(int num)
        {
            long sum = 0;
            for (int i = 0; i < num; i++)
            {
                if (i.IsPrime())
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
