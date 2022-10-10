using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter3
{
    [ProblemSolved]
    internal class Problem23 : IProblem
    {
        public string Name => "Non-abundant sums";
        public string TestResult => "28";
        public string SolveResult => "4179871";

        public string Test()
        {
            return SumOfDivisors(28).ToString();
        }

        public string Solve()
        {
            var abundandNumbers = FindAbundantNumbers(28123);
            var combinations = FindAllCombinations(abundandNumbers);
            return SumOfNonAbundandNumbers(combinations, 28123).ToString();
        }

        private static int SumOfDivisors(int num)
        {
            int sum = 0;
            for(int i = 1; i < num; i++)
            {
                if(num % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        private static int[] FindAbundantNumbers(int limit)
        {
            var set = new HashSet<int>();
            for(int i = 1; i < limit; i++)
            {
                if(SumOfDivisors(i) > i)
                {
                    set.Add(i);
                }
            }
            return set.ToArray();
        }

        private static HashSet<int> FindAllCombinations(int[] numbers)
        {
            var set = new HashSet<int>();
            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j = 0; j < numbers.Length; j++)
                {
                    set.Add(numbers[i] + numbers[j]);
                }
            }
            return set;
        }

        private static long SumOfNonAbundandNumbers(HashSet<int> numbers, int limit)
        {
            long sum = 0;
            for(int i = 1; i <= limit; i++)
            {
                if(!numbers.Contains(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
