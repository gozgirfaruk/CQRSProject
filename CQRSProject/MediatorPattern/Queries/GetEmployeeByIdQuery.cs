using CQRSProject.MediatorPattern.Results;
using MediatR;

namespace CQRSProject.MediatorPattern.Queries
{
    public class GetEmployeeByIdQuery : IRequest<GetEmployeeByIdQueryResult>
    {
        public int EmployeeID { get; set; }

        public GetEmployeeByIdQuery(int employeeID)
        {
            EmployeeID = employeeID;
        }
    }
}
