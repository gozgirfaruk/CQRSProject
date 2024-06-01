using CQRSProject.CQRS.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductQueryHandler _handler;

        public ProductController(GetProductQueryHandler handler)
        {
            _handler = handler;
        }

        public IActionResult ProductList()
        {
            var values = _handler.Handle();
            return View(values);
        }
    }
}
