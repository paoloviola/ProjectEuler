using ProjectEuler.Common.Problem;
using System.Text;

namespace ProjectEuler.Chapter4
{
    [ProblemSolved]
    internal class Problem38 : IProblem
    {
        public string Name => "Pandigital multiples";
        public string TestResult => "True";
        public string SolveResult => "932718654";

        public string Test()
        {
            return IsPandigital(MultiplicateTo9Digits(192)).ToString();
        }

        public string Solve()
        {
            return GetLargestPandigitalNumber().ToString();
        }

        private static bool IsPandigital(string? str)
        {
            if (str == null)
            {
                return false;
            }

            for(int i = 1; i <= 9; i++)
            {
                if(str.Count(c => c.ToString() == i.ToString()) != 1)
                {
                    return false;
                }
            }
            return true;
        }

        private static string? MultiplicateTo9Digits(int num)
        {
            var sb = new StringBuilder(num.ToString()); // num * 1
            for(int i = 2; sb.Length < 9; i++)
            {
                sb.Append(num * i);
            }
            return sb.Length > 9 ? null : sb.ToString();
        }

        private static string GetLargestPandigitalNumber()
        {
            string lastPandigitalNumber = "";
            for(int i = 2; i < 1e+6; i++)
            {
                var panNum = MultiplicateTo9Digits(i);
                if(panNum != null && IsPandigital(panNum))
                {
                    lastPandigitalNumber = panNum;
                }
            }
            return lastPandigitalNumber;
        }
    }
}
