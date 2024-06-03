namespace CQRSProject.CQRS.Commands.Category
{
    public class DeleteCategoryCommand
    {
        public DeleteCategoryCommand(int categoryID)
        {
            CategoryID = categoryID;
        }

        public int CategoryID { get; set; }
    }
}
