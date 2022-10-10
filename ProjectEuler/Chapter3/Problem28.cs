using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter3
{
    [ProblemSolved]
    internal class Problem28 : IProblem
    {
        public string Name => "Number spiral diagonals";
        public string TestResult => "101";
        public string SolveResult => "669171001";

        public string Test()
        {
            var spiral = CreateSpiral(5, 5);
            return DiagonalSum(spiral).ToString();
        }

        public string Solve()
        {
            var spiral = CreateSpiral(1001, 1001);
            return DiagonalSum(spiral).ToString();
        }

        private static int DiagonalSum(int[,] spiral)
        {
            int sum = 0;
            for(int i = 0; i < spiral.GetLength(0); i++)
            {
                sum += spiral[i, i];
                int j = spiral.GetLength(0) - i - 1;
                sum += spiral[j, i];
            }
            return sum - 1;
        }

        private static int[,] CreateSpiral(int width, int height)
        {
            var spiral = new int[width, height];

            int steps = 0, maxSteps = 1;
            int dirX = 1, dirY = 0;
            int colX = 0, colY = 0;

            for (int i = 1; i <= width * height; i++)
            {
                int x = (width - 1) / 2 + colX;
                int y = (height - 1) / 2 + colY;
                spiral[x, y] = i;

                if (dirY != 0 && steps == maxSteps)
                {
                    steps = 0;
                    maxSteps++;
                    dirX = dirY <= 0 ? 1 : -1;
                    dirY = 0;
                }

                if (dirX != 0 && steps == maxSteps)
                {
                    steps = 0;
                    dirY = dirX <= 0 ? -1 : 1;
                    dirX = 0;
                }

                colX += dirX;
                colY += dirY;
                steps++;
            }

            return spiral;
        }
    }
}
