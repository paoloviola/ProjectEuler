using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter1
{
    [ProblemSolved]
    internal class Problem2 : IProblem
    {
        public string Name => "Even Fibonacci numbers";
        public string TestResult => "";
        public string SolveResult => "4613732";

        public string Test()
        {
            return "";
        }

        public string Solve()
        {
            return SumOfEvenFibonacciNumbers(4000000).ToString();
        }

        private static long SumOfEvenFibonacciNumbers(int num)
        {
            long sum = 0;
            long lastNumber = 1;
            long currentNumber = 2;

            while (currentNumber <= num)
            {
                if (currentNumber % 2 == 0)
                {
                    sum += currentNumber;
                }

                long cachedNumber = currentNumber;
                currentNumber = lastNumber + currentNumber;
                lastNumber = cachedNumber;
            }
            return sum;
        }
    }
}
