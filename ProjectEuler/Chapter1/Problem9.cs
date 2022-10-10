using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter1
{
    [ProblemSolved]
    internal class Problem9 : IProblem
    {
        public string Name => "Special Pythagorean triplet";
        public string TestResult => "";
        public string SolveResult => "31875000";

        public string Test()
        {
            return "";
        }

        public string Solve()
        {
            return FindProductOfPythagoreanTripletFor(1000).ToString();
        }

        private static int FindProductOfPythagoreanTripletFor(int num)
        {
            int b, a;
            for (b = 0; ; b++)
            {
                for (a = 0; a < b; a++)
                {
                    double c = Math.Sqrt(a * a + b * b);
                    if (c % 1 == 0 && a + b + c == num)
                    {
                        return b * a * (int)c;
                    }
                }
            }
        }
    }
}
