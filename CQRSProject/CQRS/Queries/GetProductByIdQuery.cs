namespace CQRSProject.CQRS.Queries
{
    public class GetProductByIdQuery
    {
        public int ProductID { get; set; }

        public GetProductByIdQuery(int productID)
        {
            ProductID = productID;
        }
    }
}
