using CQRSProject.DAL;
using CQRSProject.MediatorPattern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace CQRSProject.MediatorPattern.Handlers
{
    public class RemoveEmployeeCommandHandler : IRequestHandler<RemoveEmployeeCommand>
    {
        private readonly CqrsContext _context;

        public RemoveEmployeeCommandHandler(CqrsContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveEmployeeCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Employees.FindAsync(request.EmployeeID);
             _context.Employees.Remove(values);
            await _context.SaveChangesAsync();
        }

       
    }
}
