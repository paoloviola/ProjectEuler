using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter5
{
    [ProblemSolved]
    internal class Problem40 : IProblem
    {
        public string Name => "Champernowne's constant";
        public string TestResult => "1";
        public string SolveResult => "210";

        public string Test()
        {
            return FindProductDigitsOfD(12).ToString();
        }

        public string Solve()
        {
            int[] ds = { 1, 10, 100, 1000, 10000, 100000, 1000000 };
            return FindProductDigitsOfD(ds).ToString();
        }

        private static int FindProductDigitsOfD(params int[] ds)
        {
            int currIndex = 0;
            int currLength = 0;

            int product = 1;
            for(int i = 1; currIndex < ds.Length; i++)
            {
                string currStr = i.ToString();
                currLength += currStr.Length;

                if (currLength >= ds[currIndex])
                {
                    int position = currStr.Length - currLength + ds[currIndex];
                    product *= int.Parse(currStr[position - 1].ToString());
                    currIndex++;
                }
            }

            return product;
        }
    }
}
