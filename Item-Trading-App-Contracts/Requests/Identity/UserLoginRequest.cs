using System.ComponentModel.DataAnnotations;

namespace Item_Trading_App_Contracts.Requests.Identity;

public record UserLoginRequest
{
    [Required]
    public required string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
