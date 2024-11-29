using System.ComponentModel.DataAnnotations;
using MediatR;
using Model.Domain.Response;

namespace Model.Domain.Command.Request
{
    public class HelloWorldRequest : IRequest<HelloWorldResponse>
    {
        [Required]
        public string Name { get; set; } = null!;
    }
}
