using ProjectEuler.Common.Problem;
using System.Numerics;

namespace ProjectEuler.Chapter3
{
    [ProblemSolved]
    internal class Problem29 : IProblem
    {
        public string Name => "Distinct powers";
        public string TestResult => "15";
        public string SolveResult => "9183";

        public string Test()
        {
            return GetDistinctNumbers(5, 5)
                .Count().ToString();
        }

        public string Solve()
        {
            return GetDistinctNumbers(100, 100)
                .Count().ToString();
        }

        private static HashSet<BigInteger> GetDistinctNumbers(int maxA, int maxB)
        {
            var numbers = new HashSet<BigInteger>();
            for (int a = 2; a <= maxA; a++)
            {
                for (int b = 2; b <= maxB; b++)
                {
                    numbers.Add(BigInteger.Pow(a, b));
                }
            }
            return numbers;
        }
    }
}
