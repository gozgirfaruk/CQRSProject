using CQRSProject.CQRS.Commands.Product;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly CqrsContext _context;

        public CreateProductCommandHandler(CqrsContext context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand command)
        {
             _context.Products.Add(new Product
            {
                Name = command.Name,
                Price = command.Price
            });
            _context.SaveChanges();
        }
    }
}
