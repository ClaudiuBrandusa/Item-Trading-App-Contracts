using System.ComponentModel.DataAnnotations;

namespace Item_Trading_App_Contracts.Requests.Identity;

public record UserRegisterRequest
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    public string ConfirmPassword { get; set; }
}
