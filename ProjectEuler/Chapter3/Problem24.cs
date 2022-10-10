using ProjectEuler.Common.Problem;
using System.Text;

namespace ProjectEuler.Chapter3
{
    [ProblemSolved]
    internal class Problem24 : IProblem
    {
        public string Name => "Lexicographic permutations";
        public string TestResult => "210";
        public string SolveResult => "2783915460";

        public string Test()
        {
            return FindPermutation("012", 5);
        }

        public string Solve()
        {
            return FindPermutation("0123456789", 999999);
        }

        private static int FindPX(string str)
        {
            for (int i = str.Length - 1; i > 0; i--)
            {
                if (str[i] > str[i - 1])
                {
                    return i - 1;
                }
            }

            return 0;
        }

        private static int FindPY(string str, int px)
        {
            for(int i = px; i < str.Length; i++)
            {
                if (str[px] > str[i])
                {
                    return i - 1;
                }
            }

            return str.Length - 1;
        }

        private static string FindNextPermutation(string str)
        {
            int indexPX = FindPX(str);
            int indexPY = FindPY(str, indexPX);

            var temp = new StringBuilder(str);
            temp[indexPX] = str[indexPY];
            temp[indexPY] = str[indexPX];

            var str0 = temp.ToString(0, indexPX + 1);
            var str1 = temp.ToString(indexPX + 1, temp.Length - indexPX - 1);
            return $"{str0}{new string(str1.Reverse().ToArray())}";
        }

        private static string FindPermutation(string start, int number)
        {
            for(int i = 0; i < number; i++)
            {
                var permutation = FindNextPermutation(start);
                if(permutation == start)
                {
                    break;
                }

                start = permutation;
            }

            return start;
        }
    }
}
