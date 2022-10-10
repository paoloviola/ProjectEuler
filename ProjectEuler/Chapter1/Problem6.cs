using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter1
{
    [ProblemSolved]
    internal class Problem6 : IProblem
    {
        public string Name => "Sum square difference";
        public string TestResult => "2640";
        public string SolveResult => "25164150";

        public string Test()
        {
            long sumOfSquares = SumOfSquares(10);
            long squareOfSum = SquareOfSum(10);

            long difference = Math.Abs(sumOfSquares - squareOfSum);
            return difference.ToString();
        }

        public string Solve()
        {
            long sumOfSquares = SumOfSquares(100);
            long squareOfSum = SquareOfSum(100);

            long difference = Math.Abs(sumOfSquares - squareOfSum);
            return difference.ToString();
        }

        private static long SumOfSquares(int toNum)
        {
            long sum = 0;
            for (int i = 1; i <= toNum; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        private static long SquareOfSum(int toNum)
        {
            long sum = 0;
            for (int i = 1; i <= toNum; i++)
            {
                sum += i;
            }
            return sum * sum;
        }
    }
}
