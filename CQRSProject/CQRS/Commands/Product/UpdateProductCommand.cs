namespace CQRSProject.CQRS.Commands.Product
{
    public class UpdateProductCommand
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
