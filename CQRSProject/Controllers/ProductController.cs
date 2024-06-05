using CQRSProject.CQRS.Commands.Product;
using CQRSProject.CQRS.Handlers;
using CQRSProject.CQRS.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductQueryHandler _handler;
        private readonly CreateProductCommandHandler  _handlerCreate;
        private readonly DeleteProductCommandHandler  _handlerDelete;
        private readonly GetProductByIdQueryHandler   _handlerById;

        public ProductController(GetProductQueryHandler handler, CreateProductCommandHandler handlerCreate, DeleteProductCommandHandler handlerDelete, GetProductByIdQueryHandler handlerById)
        {
            _handler = handler;
            _handlerCreate = handlerCreate;
            _handlerDelete = handlerDelete;
            _handlerById = handlerById;
        }

        public IActionResult ProductList()
        {
            var values = _handler.Handle();
            return View(values);
        }


        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        public IActionResult CreateProduct(CreateProductCommand command)
        {
            _handlerCreate.Handle(command);
            return RedirectToAction("ProductList");
        }

        public IActionResult DeleteProduct(int id)
        {
            _handlerDelete.Handle(new DeleteProductCommand(id));
            return RedirectToAction("ProductList");
        }

        public IActionResult UpdateProduct(int id)
        {
            return View();
        }

     
    }
}
