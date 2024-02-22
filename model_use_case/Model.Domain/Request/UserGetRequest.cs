using System.ComponentModel.DataAnnotations;

namespace Model.Domain.Request
{
    public class UserGetRequest
    {
        [Required]
        public string Id { get; set; } = null!;
    }
}
