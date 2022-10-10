using ProjectEuler.Common.Problem;
using System.Text;

namespace ProjectEuler.Chapter4
{
    [ProblemSolved]
    internal class Problem36 : IProblem
    {
        public string Name => "Double-base palindromes";
        public string TestResult => "1001001001";
        public string SolveResult => "872187";

        public string Test()
        {
            return ToBinary(585);
        }

        public string Solve()
        {
            return SumOfPalindromicNumbersBelow(1000000).ToString();
        }

        private static int FindBinaryBase(int num)
        {
            for(int b = 1; ; b++)
            {
                if(Math.Pow(2, b) > num)
                {
                    return b - 1;
                }
            }
        }

        private static string ToBinary(int num)
        {
            var binary = new StringBuilder();
            for(int b = FindBinaryBase(num); b >= 0; b--)
            {
                int pow = (int)Math.Pow(2, b);
                if(num >= pow)
                {
                    binary.Append(1);
                    num -= pow;
                }
                else
                {
                    binary.Append(0);
                }
            }
            return binary.ToString();
        }

        private static long SumOfPalindromicNumbersBelow(int maximum)
        {
            long sum = 0;
            for(int i = 0; i < maximum; i++)
            {
                var base10Str = i.ToString();
                var base10Reverse = new string(base10Str.Reverse().ToArray());
                if(base10Str != base10Reverse)
                {
                    continue;
                }

                var base2Str = ToBinary(i);
                var base2Reverse = new string(base2Str.Reverse().ToArray());
                if(base2Str != base2Reverse)
                {
                    continue;
                }

                sum += i;
            }
            return sum;
        }
    }
}
