using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter4
{
    [ProblemSolved]
    internal class Problem31 : IProblem
    {
        private readonly int[] COINS = { 001, 002, 005, 010, 020, 050, 100, 200 };

        public string Name => "Coin sums";
        public string TestResult => "";
        public string SolveResult => "73682";

        public string Test()
        {
            return "";
        }

        public string Solve()
        {
            return GetPossibilities(200).ToString();
        }

        private int GetPossibilities(int value)
        {
            int[] possibilities = new int[value + 1];

            possibilities[0] = 1;
            for(int coin = 0; coin < COINS.Length; coin++)
            {
                for(int amount = 1; amount < possibilities.Length; amount++)
                {
                    if(amount - COINS[coin] < 0)
                    {
                        continue;
                    }

                    possibilities[amount] += possibilities[amount - COINS[coin]];
                }
            }
            return possibilities[value];
        }
    }
}
