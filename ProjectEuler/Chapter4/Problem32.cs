using ProjectEuler.Common.Problem;
using System.Text;

namespace ProjectEuler.Chapter4
{
    [ProblemSolved]
    internal class Problem32 : IProblem
    {
        public string Name => "Pandigital products";
        public string TestResult => "True";
        public string SolveResult => "45228";

        public string Test()
        {
            return IsPandigital("15234", 5).ToString();
        }

        public string Solve()
        {
            return SumOfPandigitalProducts(9).ToString();
        }

        private static bool IsPandigital(string str, int cap)
        {
            if(str.Length != cap || str.Contains('0'))
            {
                return false;
            }

            for(int i = 1; i <= cap; i++)
            {
                if(str.Count(c => c.ToString() == i.ToString()) != 1)
                {
                    return false;
                }
            }
            return true;
        }

        private static long SumOfPandigitalProducts(int cap)
        {
            var sums = new HashSet<long>();
            for(int a = 1; a < 100; a++)
            {
                for (int b = 1; b < 10000; b++)
                {
                    var str = new StringBuilder();
                    str.Append(a).Append(b).Append(a * b);
                    if(IsPandigital(str.ToString(), cap) && !sums.Contains(a * b))
                    {
                        sums.Add(a * b);
                    }
                }
            }
            return sums.Sum();
        }
    }
}
