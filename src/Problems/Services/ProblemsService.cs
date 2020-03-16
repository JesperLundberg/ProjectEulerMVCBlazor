using System.Collections.Generic;
using System.Threading.Tasks;
using Problems.Repositories;

namespace Problems.Services
{
    public class ProblemsService : IProblemsService
    {
        private IProblemsRepository ProblemsRepository { get; }

        public ProblemsService(IProblemsRepository problemsRepository)
        {
            ProblemsRepository = problemsRepository;
        }
        
        public AnswerDTO GetAnswer(string fullName)
        {
            var problemInstanciated = ProblemsRepository.GetSpecificProblemInstance(fullName);
            var problemResult = problemInstanciated.Run();

            return problemResult;
        }
        
        public Task<AnswerDTO> GetAnswerAsync(string fullName)
        {
            var problemInstanciated = ProblemsRepository.GetSpecificProblemInstance(fullName);
            var problemResult = problemInstanciated.Run();

            return Task.FromResult(problemResult);
        }

        public Task<IEnumerable<string>> GetAllProblemsAsync()
        {
            return Task.FromResult(ProblemsRepository.GetAllProblems());
        }
    }
}