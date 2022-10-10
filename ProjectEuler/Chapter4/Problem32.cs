using ProjectEuler.Common.Problem;
using System.Text;

namespace ProjectEuler.Chapter4
{
    internal class Problem32 : IProblem
    {
        public string Name => "Pandigital products";
        public string TestResult => "True";
        public string SolveResult => "268218";

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
            for(int i = 1; i <= cap; i++)
            {
                if(str.Count(c => c.ToString() == i.ToString()) != 1)
                {
                    return false;
                }
            }
            return true;
        }

        private static bool ContainsDuplicates(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                for(int digit = 0; digit <= 9; digit++)
                {
                    if (str.Count(c => c.ToString() == digit.ToString()) > 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static long SumOfPandigitalProducts(int cap)
        {
            var sums = new HashSet<long>();
            for(int a = 10; a < 1e+3; a++)
            {
                if(ContainsDuplicates(a.ToString()))
                {
                    continue;
                }

                for (int b = 100; b < 1e+4; b++)
                {
                    if (ContainsDuplicates(a.ToString() + b.ToString()))
                    {
                        continue;
                    }

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
