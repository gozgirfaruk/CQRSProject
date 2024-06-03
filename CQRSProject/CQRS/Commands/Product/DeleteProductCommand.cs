namespace CQRSProject.CQRS.Commands.Product
{
    public class DeleteProductCommand
    {
        public DeleteProductCommand(int productID)
        {
            ProductID = productID;
        }

        public int ProductID { get; set; }
    }
}
