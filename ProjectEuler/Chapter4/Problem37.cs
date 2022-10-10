using ProjectEuler.Common;
using ProjectEuler.Common.Problem;
using System.Text;

namespace ProjectEuler.Chapter4
{
    [ProblemSolved]
    internal class Problem37 : IProblem
    {
        public string Name => "Truncatable primes";
        public string TestResult => "True";
        public string SolveResult => "748317";

        public string Test()
        {
            return IsTruncatablePrime(3797).ToString();
        }

        public string Solve()
        {
            return GetSumOfTruncatablePrimes().ToString();
        }

        private static bool IsTruncatablePrime(int num)
        {
            var sb = new StringBuilder(num.ToString());
            do
            {
                if (!int.Parse(sb.ToString()).IsPrime())
                {
                    return false;
                }
                sb.Remove(0, 1);
            }
            while (sb.Length > 0);

            sb = new StringBuilder(num.ToString());
            do
            {
                if (!int.Parse(sb.ToString()).IsPrime())
                {
                    return false;
                }
                sb.Remove(sb.Length - 1, 1);
            }
            while (sb.Length > 0);

            return true;
        }

        private static long GetSumOfTruncatablePrimes()
        {
            int found = 0;

            long sum = 0;
            for(int i = 10; found < 11; i++)
            {
                if(IsTruncatablePrime(i))
                {
                    sum += i;
                    found++;
                }
            }
            return sum;
        }
    }
}
