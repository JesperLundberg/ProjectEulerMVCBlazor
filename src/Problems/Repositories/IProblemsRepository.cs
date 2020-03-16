using System.Collections.Generic;
using Problems.Interfaces;

namespace Problems.Repositories
{
    public interface IProblemsRepository
    {
        IEnumerable<string> GetAllProblems();
        IProblem GetSpecificProblemInstance(string fullName);
    }
}