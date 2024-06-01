using CQRSProject.CQRS.Results.Category;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handlers
{
    public class GetCategoryQueryHandler
    {
        private readonly CqrsContext _context;

        public GetCategoryQueryHandler(CqrsContext context)
        {
            _context = context;
        }

        public List<GetCategoryQueryResult> Handle()
        {
            var values = _context.Categories.Select(x => new GetCategoryQueryResult
            {
                Name = x.Name,
                CategoryID = x.CategoryID
            }).ToList();
            return values;
        }
    }
}
