using ProjectEuler.Common.Problem;
using System.Numerics;

namespace ProjectEuler.Chapter2
{
    [ProblemSolved]
    internal class Problem16 : IProblem
    {
        public string Name => "Power digit sum";
        public string TestResult => "26";
        public string SolveResult => "1366";

        public string Test()
        {
            string digits = Exp(2, 15);
            return SumOfDigits(digits).ToString();
        }

        public string Solve()
        {
            string digits = Exp(2, 1000);
            return SumOfDigits(digits).ToString();
        }

        private static string Exp(int num, int exp)
        {
            BigInteger value = BigInteger.Parse(num.ToString());
            return BigInteger.Pow(value, exp).ToString();
        }

        private static int SumOfDigits(string digits)
        {
            int sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += int.Parse(digits[i].ToString());
            }
            return sum;
        }
    }
}
