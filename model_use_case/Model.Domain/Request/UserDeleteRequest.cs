using System.ComponentModel.DataAnnotations;

namespace Model.Domain.Request
{
    public class UserDeleteRequest
    {
        [Required]
        public string Id { get; set; } = null!;
    }
}
