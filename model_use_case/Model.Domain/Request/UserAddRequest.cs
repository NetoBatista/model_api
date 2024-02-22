using System.ComponentModel.DataAnnotations;

namespace Model.Domain.Request
{
    public class UserAddRequest
    {
        [Required]
        public string Name { get; set; } = null!;
    }
}
