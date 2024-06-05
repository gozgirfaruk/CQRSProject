using CQRSProject.CQRS.Queries;
using CQRSProject.CQRS.Results.Product;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly CqrsContext _context;

        public GetProductByIdQueryHandler(CqrsContext context)
        {
            _context = context;
        }

        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var value = _context.Products.Find(query.ProductID);
            return new GetProductByIdQueryResult
            {
                ProductID = value.ProductID,
                Name = value.Name,
                Price = value.Price,
            };
        }
    }
}
