using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter2
{
    [ProblemSolved]
    internal class Problem17 : IProblem
    {
        private readonly string[] FACTOR1 = {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
        };

        private readonly string[] FACTOR10 = {
            "zero", "teen", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
        };

        public string Name => "Number letter counts";
        public string TestResult => "19";
        public string SolveResult => "21124";

        public string Test()
        {
            var count = Count(1, 6);
            return string.Join("", count)
                .Replace("-", "").Replace(" ", "")
                .Length.ToString();
        }

        public string Solve()
        {
            var count = Count(1, 1001);
            return string.Join("", count)
                .Replace("-", "").Replace(" ", "")
                .Length.ToString();
        }

        private int GetNumberIndex(int number, int digit)
        {
            var str = number.ToString();
            return int.Parse(str[digit].ToString());
        }

        private string[] Count(int start, int end)
        {
            var output = new string[end - start];
            for (int i = 0; i < output.Length; i++)
            {
                int currNum = i + start;
                if (currNum < 20)
                {
                    output[i] = FACTOR1[i + start];
                }
                else if (currNum < 100)
                {
                    int index0 = GetNumberIndex(currNum, 0);
                    int index1 = GetNumberIndex(currNum, 1);
                    if (index1 == 0) { output[i] = FACTOR10[index0]; }
                    else { output[i] = $"{FACTOR10[index0]}-{FACTOR1[index1]}"; }
                }
                else if (currNum < 1000)
                {
                    int index0 = GetNumberIndex(currNum, 0);

                    if (currNum % 100 < 20)
                    {
                        if (currNum % 100 == 0) { output[i] = $"{FACTOR1[index0]} hundred"; }
                        else { output[i] = $"{FACTOR1[index0]} hundred and {FACTOR1[currNum % 100]}"; }
                    }
                    else
                    {
                        int index1 = GetNumberIndex(currNum, 1);
                        int index2 = GetNumberIndex(currNum, 2);
                        if (index1 == 0 && index2 == 0) { output[i] = $"{FACTOR1[index0]} hundred"; }
                        else if (index1 == 0 && index2 != 0) { output[i] = $"{FACTOR1[index0]} hundred and {FACTOR1[index2]}"; }
                        else if (index1 != 0 && index2 == 0) { output[i] = $"{FACTOR1[index0]} hundred and {FACTOR10[index1]}"; }
                        else { output[i] = $"{FACTOR1[index0]} hundred and {FACTOR10[index1]}-{FACTOR1[index2]}"; }
                    }
                }
                else
                {
                    int index0 = GetNumberIndex(currNum, 0);

                    if (currNum % 1000 < 20)
                    {
                        if (currNum % 1000 == 0) { output[i] = $"{FACTOR1[index0]} thousand"; }
                        else { output[i] = $"{FACTOR1[index0]} thousand and {FACTOR1[currNum % 1000]}"; }
                    }
                    else
                    {
                        int index1 = GetNumberIndex(currNum, 1);
                        int index2 = GetNumberIndex(currNum, 2);
                        int index3 = GetNumberIndex(currNum, 3);
                        if (index1 == 0 && index2 == 0 && index3 == 0) { output[i] = $"{FACTOR1[index0]} thousand"; }
                        else if (index1 != 0 && index2 == 0 && index3 == 0) { output[i] = $"{FACTOR1[index0]} thousand {FACTOR1[index1]} hundret"; }
                        else if (index1 == 0 && index2 != 0 && index3 == 0) { output[i] = $"{FACTOR1[index0]} thousand and {FACTOR10[index2]}"; }
                        else if (index1 == 0 && index2 == 0 && index3 != 0) { output[i] = $"{FACTOR1[index0]} thousand and {FACTOR1[index3]}"; }
                        else if (index1 != 0 && index2 != 0 && index3 == 0) { output[i] = $"{FACTOR1[index0]} thousand {FACTOR1[index1]} hundret and {FACTOR10[index2]}"; }
                        else if (index1 == 0 && index2 != 0 && index3 != 0) { output[i] = $"{FACTOR1[index0]} thousand and {FACTOR10[index2]}-{FACTOR1[index3]}"; }
                        else { output[i] = $"{FACTOR1[index0]} thousand {FACTOR1[index1]} hundret and {FACTOR10[index2]}-{FACTOR1[index3]}"; }
                    }
                }
            }
            return output;
        }
    }
}
