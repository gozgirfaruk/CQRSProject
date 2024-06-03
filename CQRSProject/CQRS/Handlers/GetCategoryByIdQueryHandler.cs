using CQRSProject.CQRS.Queries;
using CQRSProject.CQRS.Results.Category;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly CqrsContext _context;

        public GetCategoryByIdQueryHandler(CqrsContext context)
        {
            _context = context;
        }

        public GetCategoryByIdQueryResult Handle(GetCategoryByIdQuery query)
        {
            var values = _context.Categories.Find(query.CategoryID);
            return new GetCategoryByIdQueryResult
            {
                CategoryID = values.CategoryID,
                Name = values.Name
            };
        }
    }
}
