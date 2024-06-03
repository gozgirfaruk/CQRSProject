using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.Controllers
{
    public class CategoryMediatRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
