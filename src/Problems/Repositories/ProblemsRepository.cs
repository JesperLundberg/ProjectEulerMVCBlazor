using System;
using System.Collections.Generic;
using System.Linq;
using Problems.Interfaces;

namespace Problems.Repositories
{
    public class ProblemsRepository : IProblemsRepository
    {
        public IEnumerable<string> GetAllProblems()
        {
            var type = typeof(IProblem);
            
            var problems= AppDomain.CurrentDomain.GetAssemblies().AsParallel()
                .SelectMany(x => x.GetTypes())
                .Where(x => type.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(x => x.FullName);

            return problems.OrderBy(x => x);
        }

        public IProblem GetSpecificProblemInstance(string fullName)
        {
            if (string.IsNullOrEmpty(fullName))
            {
                throw new ArgumentNullException(nameof(fullName));
            }
            
            var problem = typeof(IProblem).Assembly.CreateInstance(fullName) as IProblem;

            return problem;
        }
    }
}