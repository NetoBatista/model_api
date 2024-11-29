using System.ComponentModel.DataAnnotations;
using MediatR;
using Model.Domain.Response;

namespace Model.Domain.Command.Request
{
    public class UserUpdateRequest: IRequest<UserUpdateResponse>
    {
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Id { get; set; } = null!;
    }
}
