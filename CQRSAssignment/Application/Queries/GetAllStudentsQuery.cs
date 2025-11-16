using CQRSAssignment.Models;
using MediatR;

namespace CQRSAssignment.Application.Queries
{
    public class GetAllStudentsQuery : IRequest<IEnumerable<Student>> {}
}
