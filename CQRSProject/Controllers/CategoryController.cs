using CQRSProject.CQRS.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly GetCategoryQueryHandler _handler;

        public CategoryController(GetCategoryQueryHandler handler)
        {
            _handler = handler;
        }

        public IActionResult CategoryList()
        {
            var values = _handler.Handle();
            return View(values);
        }
    }
}
