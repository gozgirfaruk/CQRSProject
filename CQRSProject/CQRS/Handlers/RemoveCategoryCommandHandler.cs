using CQRSProject.CQRS.Commands.Category;
using CQRSProject.DAL;
using Microsoft.AspNetCore.Razor.Language.Intermediate;

namespace CQRSProject.CQRS.Handlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly CqrsContext _context;

        public RemoveCategoryCommandHandler(CqrsContext context)
        {
            _context = context;
        }

        public void Handle(DeleteCategoryCommand command)
        {
            var values = _context.Categories.Find(command.CategoryID);
            _context.Categories.Remove(values);
            _context.SaveChanges();
        }
    }
}
