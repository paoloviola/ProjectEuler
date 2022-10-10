using ProjectEuler.Common;
using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter2
{
    [ProblemSolved]
    internal class Problem12 : IProblem
    {
        public string Name => "Highly divisible triangular number";
        public string TestResult => "28";
        public string SolveResult => "76576500";

        public string Test()
        {
            return TriangularNumDivisorNumOver(6).ToString();
        }

        public string Solve()
        {
            return TriangularNumDivisorNumOver(501).ToString();
        }

        private static long GetTriangularNumber(int num)
        {
            // CR: https://www.mathsisfun.com/algebra/triangular-numbers.html
            return num * (num + 1) / 2;
        }

        private static long TriangularNumDivisorNumOver(int divisorNum)
        {
            for (int i = 0; ; i++)
            {
                long triangularNumber = GetTriangularNumber(i);
                if (triangularNumber.NumDivisors() >= divisorNum)
                {
                    return triangularNumber;
                }
            }
        }
    }
}
