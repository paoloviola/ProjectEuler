using ProjectEuler.Common.Problem;
using System.Numerics;

namespace ProjectEuler.Chapter3
{
    [ProblemSolved]
    internal class Problem20 : IProblem
    {
        public string Name => "Factorial digit sum";
        public string TestResult => "27";
        public string SolveResult => "648";

        public string Test()
        {
            BigInteger factorial = BigFactorial(10);
            return CalculateSum(factorial.ToString()).ToString();
        }

        public string Solve()
        {
            BigInteger factorial = BigFactorial(100);
            return CalculateSum(factorial.ToString()).ToString();
        }

        private static int CalculateSum(string str)
        {
            int sum = 0;
            for(int i = 0; i < str.Length; i++)
            {
                sum += int.Parse(str[i].ToString());
            }
            return sum;
        }

        private static BigInteger BigFactorial(int num)
        {
            BigInteger factorial = BigInteger.Parse("1");
            for(int i = 1; i <= num; i++)
            {
                factorial *= BigInteger.Parse(i.ToString());
            }
            return factorial;
        }
    }
}
