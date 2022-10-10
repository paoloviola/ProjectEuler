using ProjectEuler.Common.Problem;

namespace ProjectEuler.Chapter2
{
    [ProblemSolved] // I think this is cheating :/
    internal class Problem19 : IProblem
    {
        public string Name => "Counting Sundays";
        public string TestResult => "";
        public string SolveResult => "171";

        public string Test()
        {
            return "";
        }

        public string Solve()
        {
            var start = DateTime.Parse("01-01-1901");
            var end = DateTime.Parse("31-12-2000");
            return CountSundaysOnFirstOfMonth(start, end).ToString();
        }

        public DateTime GetDateOfNextSunday(DateTime start)
        {
            int distanceToSunday = 7 - (int)start.DayOfWeek;
            return start.AddDays(distanceToSunday);
        }

        public int CountSundaysOnFirstOfMonth(DateTime start, DateTime end)
        {
            int count = 0;
            DateTime currentDate = start;
            while (currentDate < end)
            {
                currentDate = GetDateOfNextSunday(currentDate);
                if(currentDate.DayOfWeek == DayOfWeek.Sunday && currentDate.Day == 1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
