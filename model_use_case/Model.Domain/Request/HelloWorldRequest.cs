using System.ComponentModel.DataAnnotations;

namespace Model.Domain.Request
{
    public class HelloWorldRequest
    {
        [Required]
        public string Name { get; set; } = null!;
    }
}
