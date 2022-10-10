using ProjectEuler.Common;
using ProjectEuler.Common.Problem;
using System.Text;

namespace ProjectEuler.Chapter4
{
    [ProblemSolved]
    internal class Problem35 : IProblem
    {
        public string Name => "Circular primes";
        public string TestResult => "True";
        public string SolveResult => "55";

        public string Test()
        {
            return IsCircularPrime(197).ToString();
        }

        public string Solve()
        {
            return CountCircularPrimesBelow(1000000).ToString();
        }

        private static bool IsCircularPrime(int num)
        {
            var lastRotation = new StringBuilder(num.ToString());
            for(int i = 0; i < lastRotation.Length; i++)
            {
                char firstChar = lastRotation[0];
                for (int j = 0; j < lastRotation.Length; j++)
                { // rotate string
                    lastRotation[j] = j + 1 == lastRotation.Length ? firstChar : lastRotation[j + 1];
                }

                if(!int.Parse(lastRotation.ToString()).IsPrime())
                {
                    return false;
                }
            }
            return true;
        }

        private static int CountCircularPrimesBelow(int cap)
        {
            int count = 0;
            for(int i = 2; i < cap; i++)
            {
                if(IsCircularPrime(i))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
