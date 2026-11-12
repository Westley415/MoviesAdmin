using Microsoft.AspNetCore.Mvc;

namespace MoviesAdmin.Controllers
{
    public class MovieReview : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
