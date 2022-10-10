using ProjectEuler.Common;
using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter3
{
    [ProblemSolved]
    internal class Problem22 : IProblem
    {
        public string Name => "Names scores";
        public string TestResult => "49714";
        public string SolveResult => "871198282";

        public string Test()
        {
            return GetNameScore("COLIN", 938).ToString();
        }

        public string Solve()
        {
            var names = ResourceLoader.ReadResource("p022names.txt")!
                .Replace("\"", "").Split(',').OrderBy(name => name);
            return GetTotalNameScores(names).ToString();
        }

        private static long GetNameScore(string name, int index)
        {
            long sum = 0;
            for(int i = 0; i < name.Length; i++)
            {
                sum += name[i] - 0x40;
            }
            return sum * index;
        }

        private static long GetTotalNameScores(IEnumerable<string> names)
        {
            return names.Select((n, i) => GetNameScore(n, i + 1)).Sum();
        }
    }
}
