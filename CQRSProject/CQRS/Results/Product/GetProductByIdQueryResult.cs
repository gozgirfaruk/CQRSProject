namespace CQRSProject.CQRS.Results.Product
{
    public class GetProductByIdQueryResult
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
