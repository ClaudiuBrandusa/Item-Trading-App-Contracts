using System;

namespace Item_Trading_App_Contracts.Responses.Identity;

public record AuthenticationSuccessResponse
{
    public string Token { get; set; }

    public string RefreshToken { get; set; }

    public DateTime ExpirationDateTime { get; set; }
}
