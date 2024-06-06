using MediatR;

namespace CQRSProject.MediatorPattern.Commands
{
    public class UpdateEmployeeCommand : IRequest
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
    }
}
