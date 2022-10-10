using FluentAssertions;
using NUnit.Framework;
using ProjectEuler.Common.Problem;
using System.Reflection;

namespace ProjectEuler.Tests
{
    [TestFixture]
    internal class ProblemTests
    {

        [Test]
        public void AllProblemsAreSolved()
        {
            var assembly = typeof(IProblem).Assembly;
            var types = assembly.GetTypes()
                .Where(t => t.IsClass && t.Namespace != null && t.Namespace.StartsWith("ProjectEuler"))
                .Where(t => t.IsAssignableTo(typeof(IProblem)) && t.GetCustomAttribute(typeof(ProblemSolved)) == null)
                .ToArray();

            foreach(Type t in types)
            {
                IProblem? problem = Activator.CreateInstance(t) as IProblem;
                problem.Should().NotBeNull();

                Console.Write($"Executing: {problem!.Name}... ");
                problem.Test().Should().Be(problem.TestResult);
                Console.Write("[Test: OK] ");
                problem.Solve().Should().Be(problem.SolveResult);
                Console.WriteLine("[Solve: OK]");
            }
        }

    }
}
