using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter2
{
    [ProblemSolved]
    internal class Problem15 : IProblem
    {
        public string Name => "Lattice paths";
        public string TestResult => "6";
        public string SolveResult => "137846528820";

        public string Test()
        {
            return CountGridRoutes(2, 2).ToString();
        }

        public string Solve()
        {
            return CountGridRoutes(20, 20).ToString();
        }

        private static long CountGridRoutes(int width, int height)
        { // Build Pascals triangle (TODO@Paolo: Can we make more efficient?)
            long[,] values = new long[width + 1, height + 1];
            for (int x = 0; x < values.GetLength(0); x++)
            {
                for (int y = 0; y < values.GetLength(1); y++)
                {
                    if (x == 0 || y == 0)
                    {
                        values[x, y] = 1;
                    }
                    else
                    {
                        values[x, y] = values[x - 1, y] + values[x, y - 1];
                    }
                }
            }

            // Get last value
            return values[width, height];
        }
    }
}
