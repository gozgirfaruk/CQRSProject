using MediatR;

namespace CQRSProject.MediatorPattern.Commands
{
    public class RemoveEmployeeCommand : IRequest
    {
        public int EmployeeID { get; set; }

        public RemoveEmployeeCommand(int employeeID)
        {
            EmployeeID = employeeID;
        }
    }
}
