using CQRSProject.CQRS.Commands.Category;
using CQRSProject.CQRS.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly GetCategoryQueryHandler _handlerList;
        private readonly GetCategoryByIdQueryHandler _handlerID;
        private readonly CreateCategoryCommandHandler _handlerCreate;
        private readonly RemoveCategoryCommandHandler _handleRemove;
        private readonly UpdateCategoryCommandHandler _handleUpdate;

        public CategoryController(GetCategoryQueryHandler handler, GetCategoryByIdQueryHandler handlerID, CreateCategoryCommandHandler handlerCreate, RemoveCategoryCommandHandler handleRemove, UpdateCategoryCommandHandler handleUpdate)
        {
            _handlerList = handler;
            _handlerID = handlerID;
            _handlerCreate = handlerCreate;
            _handleRemove = handleRemove;
            _handleUpdate = handleUpdate;
        }

        public IActionResult CategoryList()
        {
            var values = _handlerList.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult GetCategory(int id)
        {
            var values = _handlerID.Handle(new CQRS.Queries.GetCategoryByIdQuery(id));
            return View(values);
        }

        [HttpPost]
        public IActionResult GetCategory(UpdateCategoryCommand command)
        {
            _handleUpdate.Handle(command);
            return RedirectToAction("CategoryList");
        }


        [HttpGet]
        public IActionResult CreateCategory()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryCommand command)
        {
            _handlerCreate.Handle(command);
            return RedirectToAction("CategoryList");
        }

        public IActionResult DeleteCategory(int id)
        {
            // parametre olarak command sınıfından command parametre geçilirse alttaki sutün kullanılabilir.
            //_handleRemove.Handle(command);
            _handleRemove.Handle(new DeleteCategoryCommand(id));
            return RedirectToAction("CategoryList");
        }
    }
}
