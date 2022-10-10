using ProjectEuler.Common.Problem;
using System.Numerics;

namespace ProjectEuler.Chapter3
{
    [ProblemSolved]
    internal class Problem25 : IProblem
    {
        public string Name => "1000-digit Fibonacci number";
        public string TestResult => "12";
        public string SolveResult => "4782";

        public string Test()
        {
            return FindFibonacciNumberIndex(3).ToString();
        }

        public string Solve()
        {
            return FindFibonacciNumberIndex(1000).ToString();
        }

        private static int FindFibonacciNumberIndex(int numDigits)
        {
            BigInteger firstNumber = BigInteger.Parse("1");
            BigInteger secondNumber = BigInteger.Parse("1");

            int i;
            for (i = 2; secondNumber.ToString().Length < numDigits; i++)
            {
                BigInteger sum = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = sum;
            }
            return i;
        }
    }
}
