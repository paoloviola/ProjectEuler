using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter3
{
    [ProblemSolved]
    internal class Problem21 : IProblem
    {
        public string Name => "Amicable numbers";
        public string TestResult => "284";
        public string SolveResult => "31626";

        public string Test()
        {
            return D(220).ToString();
        }

        public string Solve()
        {
            return Sum(10000).ToString();
        }

        private static int Sum(int max)
        {
            int sum = 0;
            for(int a = 0; a < max; a++)
            {
                int b = D(a);
                if (a != b && D(b) == a)
                    sum += b;
            }
            return sum;
        }

        private static int D(int n)
        {
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
