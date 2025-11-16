using MediatR;
 
namespace CQRSAssignment.Application.Commands
{
    public record DeleteStudentCommand(int Id) : IRequest<bool>{}
}
