using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter1
{
    [ProblemSolved]
    internal class Problem5 : IProblem
    {
        public string Name => "Smallest multiple";
        public string TestResult => "2520";
        public string SolveResult => "232792560";

        public string Test()
        {
            return SmallestNumberDividableTo(10).ToString();
        }

        public string Solve()
        {
            return SmallestNumberDividableTo(20).ToString();
        }

        private static bool AllNumbersDivide(int divideTo, long num)
        {
            for (long i = 1; i < divideTo; i++)
            {
                if (num % i != 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static long SmallestNumberDividableTo(int num)
        {
            for (long i = 1; ; i++)
            {
                if (AllNumbersDivide(num, i))
                {
                    return i;
                }
            }
        }
    }
}
