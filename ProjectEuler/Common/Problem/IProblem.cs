namespace ProjectEuler.Common.Problem
{
    public interface IProblem
    {
        string Name { get; }
        string TestResult { get; }
        string SolveResult { get; }

        string Test();
        string Solve();
    }
}
