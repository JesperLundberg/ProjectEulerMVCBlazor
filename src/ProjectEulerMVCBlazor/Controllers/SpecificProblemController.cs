using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Problems.Repositories;
using Problems.Services;
using ProjectEulerMVCBlazor.Models;

namespace ProjectEulerMVCBlazor.Controllers
{
    public class SpecificProblemController : Controller
    {
        private ILogger<SpecificProblemController> Logger { get; }
        private IProblemsRepository ProblemsRepository { get; }
        private IProblemsService ProblemsService { get; }

        public SpecificProblemController(ILogger<SpecificProblemController> logger, IProblemsRepository problemsRepository, IProblemsService problemsService)
        {
            Logger = logger;
            ProblemsRepository = problemsRepository;
            ProblemsService = problemsService;
        }

        public IActionResult Index(string fullName, string answer = default, string timeTaken = default)
        {
            var problemInstanciated = ProblemsRepository.GetSpecificProblemInstance(fullName);

            var viewModel = new SpecificProblemViewModel
            {
                Header = problemInstanciated.Name(),
                Text = problemInstanciated.Description(),
                Answer = answer,
                TimeTaken = timeTaken,
                RequestedProblemName = fullName
            };

            return View(viewModel);
        }

        [HttpPost]
        public RedirectToActionResult GetAnswer(string fullName)
        {
            var problemResult = ProblemsService.GetAnswer(fullName);

            return RedirectToAction("Index", "SpecificProblem",new {fullName, answer = problemResult.Answer, timeTaken = problemResult.TimeTaken});
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}