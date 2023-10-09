namespace Item_Trading_App_Contracts.Requests.Identity;

public record RefreshTokenRequest
{
    public string Token { get; set; }

    public string RefreshToken { get; set; }
}
