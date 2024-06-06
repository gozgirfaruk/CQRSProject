using CQRSProject.DAL;
using CQRSProject.MediatorPattern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace CQRSProject.MediatorPattern.Handlers
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand>
    {
        private readonly CqrsContext _context;

        public UpdateEmployeeCommandHandler(CqrsContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Employees.FindAsync(request.EmployeeID);
            values.Name = request.Name;
            values.Surname = request.Surname;
            values.Salary = request.Salary;

            _context.Employees.Update(values);
            await _context.SaveChangesAsync();

        }
    }
}
