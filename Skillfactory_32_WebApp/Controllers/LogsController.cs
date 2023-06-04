using Microsoft.AspNetCore.Mvc;
using Skillfactory_32_WebApp.Models.Db;

namespace Skillfactory_32_WebApp.Controllers
{
    public class LogsController : Controller
    {

        private readonly IRequestRepository _repo;

        public LogsController(IRequestRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var requests = await _repo.GetRequest();
            var sortedRequests = from r in requests
                                 orderby r.Date descending
                                 select r;

            return View(sortedRequests);
        }
    }
}
