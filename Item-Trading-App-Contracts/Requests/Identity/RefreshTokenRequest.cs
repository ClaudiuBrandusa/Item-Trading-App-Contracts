using System.ComponentModel.DataAnnotations;

namespace Item_Trading_App_Contracts.Requests.Identity;

public record RefreshTokenRequest
{
    [Required]
    public string Token { get; set; }

    [Required]
    public string RefreshToken { get; set; }
}
