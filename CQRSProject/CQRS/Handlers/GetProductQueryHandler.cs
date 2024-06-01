using CQRSProject.CQRS.Results.Product;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly CqrsContext _context;

        public GetProductQueryHandler(CqrsContext context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x =>new  GetProductQueryResult{
                ProductID=x.ProductID,
                Name = x.Name,
                Price = x.Price

            }).ToList();
            return values;
        }
    }
}
