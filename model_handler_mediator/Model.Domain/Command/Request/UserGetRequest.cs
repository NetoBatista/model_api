using System.ComponentModel.DataAnnotations;
using MediatR;
using Model.Domain.Response;

namespace Model.Domain.Command.Request
{
    public class UserGetRequest: IRequest<UserGetResponse>
    {
        [Required]
        public string Id { get; set; } = null!;
    }
}
