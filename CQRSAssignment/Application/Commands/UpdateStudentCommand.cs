using MediatR;

namespace CQRSAssignment.Application.Commands
{
    public record UpdateStudentCommand(int Id,string Name,string Email,int Age) : IRequest<bool>;

}
