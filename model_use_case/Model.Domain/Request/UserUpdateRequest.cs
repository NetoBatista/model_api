using System.ComponentModel.DataAnnotations;

namespace Model.Domain.Request
{
    public class UserUpdateRequest
    {
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Id { get; set; } = null!;
    }
}
