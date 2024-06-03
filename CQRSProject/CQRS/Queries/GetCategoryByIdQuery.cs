namespace CQRSProject.CQRS.Queries
{
    public class GetCategoryByIdQuery
    {
        public GetCategoryByIdQuery(int categoryID)
        {
            CategoryID = categoryID;
        }

        public int CategoryID { get; set; }
    }
}
