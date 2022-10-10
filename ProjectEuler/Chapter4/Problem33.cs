using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter4
{
    [ProblemSolved]
    internal class Problem33 : IProblem
    {
        public string Name => "Digit cancelling fractions";
        public string TestResult => "True";
        public string SolveResult => "100";

        public string Test()
        {
            return CanBeSimplifiedIncorrectly(49, 98).ToString();
        }

        public string Solve()
        {
            decimal product = GetProductOfIncorrectlySimplifiedTerms();
            return GetDenominator(product).ToString();
        }

        private static int GetDenominator(decimal val)
        {
            for(int nominator = 1; ; nominator *= 10)
            {
                if(nominator / val % 1 == 0)
                {
                    return (int)(nominator / val);
                }
            }
        }

        private static bool CanBeSimplifiedIncorrectly(int nominator, int denominator)
        {
            if(nominator > 99 || nominator < 10
                || denominator > 99 || denominator < 10)
            {
                return false;
            }

            int[] nominatorVals = nominator.ToString().Select(c => int.Parse(c.ToString())).ToArray();
            int[] denominatorVals = denominator.ToString().Select(c => int.Parse(c.ToString())).ToArray();

            return (nominatorVals[0] == denominatorVals[1] && (double)nominatorVals[1] / denominatorVals[0] == (double)nominator / denominator)
                || (nominatorVals[1] == denominatorVals[0] && (double)nominatorVals[0] / denominatorVals[1] == (double)nominator / denominator);
        }

        private static decimal GetProductOfIncorrectlySimplifiedTerms()
        {
            decimal product = 1.0M;
            for (int denominator = 10; denominator < 100; denominator++)
            {
                for (int nominator = 10; nominator < denominator; nominator++)
                {
                    if (CanBeSimplifiedIncorrectly(nominator, denominator))
                    {
                        product *= (decimal)nominator / denominator;
                    }
                }
            }
            return product;
        }
    }
}
