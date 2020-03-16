using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Problems.Repositories;
using ProjectEulerMVCBlazor.Models;

namespace ProjectEulerMVCBlazor.Controllers
{
    public class ProblemsController : Controller
    {
        private ILogger<ProblemsController> Logger { get; }
        private IProblemsRepository ProblemsRepository { get; }

        public ProblemsController(ILogger<ProblemsController> logger, IProblemsRepository problemsRepository)
        {
            Logger = logger;
            ProblemsRepository = problemsRepository;
        }

        public IActionResult Index()
        {
            var viewModel = new ProblemsViewModel
            {
                Text = "See problems and solution below:",
                ProblemsLinks = GetProblemsWithUrls()
            };

            return View(viewModel);
        }

        private IEnumerable<(string, string)> GetProblemsWithUrls()
        {
            // List of all full names of classes implementing the IProblem Interface
            var allProblems = ProblemsRepository.GetAllProblems().Select(x => (name: x.Split('.').Last(), fullName: x));

            return allProblems;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}