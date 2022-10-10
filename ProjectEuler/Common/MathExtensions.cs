namespace ProjectEuler.Common
{
    internal static class MathExtensions
    {
        public static int NumDivisors(this int num)
        {
            return NumDivisors((long)num);
        }

        public static int NumDivisors(this long num)
        {
            int numDivisors = 0;
            for(int i = 1; i < Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    numDivisors += num / i == i ? 1 : 2;
                }
            }
            return numDivisors;
        }

        public static long Factorial(this int num)
        {
            long product = 1L;
            for(int i = 1; i <= num; i++)
            {
                product *= i;
            }
            return product;
        }

        public static bool IsPrime(this int num)
        {
            return IsPrime((long)num);
        }

        public static bool IsPrime(this long num)
        {
            if (num < 2)
            {
                return false;
            }
            else if(num == 2 || num == 3)
            {
                return true;
            }

            for(long i = 2; i <= Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
