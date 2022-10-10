using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter4
{
    [ProblemSolved]
    internal class Problem30 : IProblem
    {
        public string Name => "Digit fifth powers";
        public string TestResult => "19316";
        public string SolveResult => "443839";

        public string Test()
        {
            return SumOfNumbers(4).ToString();
        }

        public string Solve()
        {
            return SumOfNumbers(5).ToString();
        }

        private static long SumOfDigits(long num, int pow)
        {
            long sum = 0;
            string numStr = num.ToString();
            for (int i = 0; i < numStr.Length; i++)
            {
                byte digit = byte.Parse(numStr[i].ToString());
                sum += (long)Math.Pow(digit, pow);
            }
            return sum;
        }

        private static long SumOfNumbers(int pow)
        {
            long sum = 0;
            for (long i = 10; i < Math.Pow(10, pow + 1); i++)
            {
                if (SumOfDigits(i, pow) == i)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
