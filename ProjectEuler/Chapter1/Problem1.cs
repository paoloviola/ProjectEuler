using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter1
{
    [ProblemSolved]
    internal class Problem1 : IProblem
    {
        public string Name => "Multiples of 3 or 5";
        public string TestResult => "23";
        public string SolveResult => "233168";

        public string Test()
        {
            return SumOfMultiply3And5(10).ToString();
        }

        public string Solve()
        {
            return SumOfMultiply3And5(1000).ToString();
        }

        private static long SumOfMultiply3And5(int num)
        {
            long sum = 0;
            for (long i = 0; i < num; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
