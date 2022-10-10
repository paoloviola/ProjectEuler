using ProjectEuler.Common;
using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter4
{
    [ProblemSolved]
    internal class Problem34 : IProblem
    {
        public string Name => "Digit factorials";
        public string TestResult => "True";
        public string SolveResult => "40730";

        public string Test()
        {
            return SumOfFactorialsIs(145).ToString();
        }

        public string Solve()
        {
            return FindSumOfCuriousNumbers().ToString();
        }

        private static bool SumOfFactorialsIs(int num)
        {
            var digits = num.ToString().Select(c => int.Parse(c.ToString()));

            long sum = 0;
            foreach(int i in digits)
            {
                if (sum >= num)
                {
                    return false;
                }

                sum += i.Factorial();
            }

            return sum == num;
        }

        private static long FindSumOfCuriousNumbers()
        {
            long sum = 0;
            for(int i = 10; i < 1e+5; i++)
            {
                if(SumOfFactorialsIs(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
