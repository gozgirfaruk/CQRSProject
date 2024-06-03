using CQRSProject.CQRS.Commands.Product;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handlers
{
    public class DeleteProductCommandHandler
    {
        private readonly CqrsContext _context;

        public DeleteProductCommandHandler(CqrsContext context)
        {
            _context = context;
        }

        public void Handle(DeleteProductCommand command)
        {
            var values = _context.Products.Find(command.ProductID);
            if (values != null) {
                _context.Products.Remove(values);
            }
             _context.SaveChanges();

        }
    }
}
