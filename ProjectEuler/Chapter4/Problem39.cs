using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter4
{
    [ProblemSolved]
    internal class Problem39 : IProblem
    {
        public string Name => "Integer right triangles";
        public string TestResult => "";
        public string SolveResult => "840";

        public string Test()
        {
            return "";
        }

        public string Solve()
        {
            return NumberOfSolutionsForPBelow(1001).ToString();
        }

        private static int NumberOfSolutionsForPBelow(int maxP)
        {
            var numbers = new int[maxP];
            for(int p = 1; p < maxP; p++)
            {
                for(int a = 1; a < p; a++)
                {
                    for(int b = 1; b < p; b++)
                    {
                        if(a + b + Math.Sqrt(a * a + b * b) == p)
                        {
                            numbers[p - 1]++;
                        }
                    }
                }
            }
            return Array.IndexOf(numbers, numbers.Max()) + 1;
        }
    }
}
