using System.ComponentModel.DataAnnotations;
using MediatR;
using Model.Domain.Response;

namespace Model.Domain.Command.Request
{
    public class UserDeleteRequest: IRequest<UserDeleteResponse>
    {
        [Required]
        public string Id { get; set; } = null!;
    }
}
