using System.Collections.Generic;
using System.Threading.Tasks;

namespace Problems.Services
{
    public interface IProblemsService
    {
        AnswerDTO GetAnswer(string fullName);
        Task<AnswerDTO> GetAnswerAsync(string fullName);

        Task<IEnumerable<string>> GetAllProblemsAsync();
    }
}