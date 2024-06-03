using CQRSProject.CQRS.Commands.Category;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly CqrsContext _context;

        public CreateCategoryCommandHandler(CqrsContext context)
        {
            _context = context;
        }

        public void Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new Category
            {
                Name = command.Name
            });

            _context.SaveChanges();
        }
    }
}
