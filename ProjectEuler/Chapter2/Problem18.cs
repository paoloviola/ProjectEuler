﻿using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter2
{
    [ProblemSolved]
    internal class Problem18 : IProblem
    {
        private readonly int[][] TRIANGLE = {
            new int[]                             { 75 },
            new int[]                           { 95, 64 },
            new int[]                         { 17, 47, 82 },
            new int[]                       { 18, 35, 87, 10 },
            new int[]                     { 20, 04, 82, 47, 65 },
            new int[]                   { 19, 01, 23, 75, 03, 34 },
            new int[]                 { 88, 02, 77, 73, 07, 63, 67 },
            new int[]               { 99, 65, 04, 28, 06, 16, 70, 92 },
            new int[]             { 41, 41, 26, 56, 83, 40, 80, 70, 33 },
            new int[]           { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 },
            new int[]         { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 },
            new int[]       { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 },
            new int[]     { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 },
            new int[]   { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 },
            new int[] { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23 }
        };

        public string Name => "Maximum path sum I";
        public string TestResult => "23";
        public string SolveResult => "1074";

        public string Test()
        {
            int[][] testTriangle = {
                new int[]       { 03 },
                new int[]     { 07, 04 },
                new int[]   { 02, 04, 06 },
                new int[] { 08, 05, 09, 03 }
            };
            return FindSumOfMaximumPath(testTriangle).ToString();
        }

        public string Solve()
        {
            return FindSumOfMaximumPath(TRIANGLE).ToString();
        }

        private static int[] CalcLargestSum(int[] smaller, int[] larger)
        {
            int[] output = new int[smaller.Length];
            for(int i = 0; i < smaller.Length; i++)
            {
                output[i] = smaller[i] + (larger[i] > larger[i + 1] ? larger[i] : larger[i + 1]);
            }
            return output;
        }

        private static int FindSumOfMaximumPath(int[][] triangle)
        {
            int[] largestSum = triangle[triangle.Length - 1];
            for (int row = triangle.Length - 2; row >= 0; row--)
            {
                largestSum = CalcLargestSum(triangle[row], largestSum);
            }
            return largestSum.Max();
        }
    }
}
