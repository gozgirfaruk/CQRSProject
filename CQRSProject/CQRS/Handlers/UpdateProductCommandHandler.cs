using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly CqrsContext _context;

        public UpdateProductCommandHandler(CqrsContext context)
        {
            _context = context;
        }
    }
}
