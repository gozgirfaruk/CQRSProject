using CQRSProject.CQRS.Commands.Category;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly CqrsContext _context;

        public UpdateCategoryCommandHandler(CqrsContext context)
        {
            _context = context;
        }

        public void Handle(UpdateCategoryCommand command)
        {
            var values = _context.Categories.Find(command.CategoryID);
            values.Name = command.Name;
            _context.Categories.Update(values);
            _context.SaveChanges();

        }
    }
}
