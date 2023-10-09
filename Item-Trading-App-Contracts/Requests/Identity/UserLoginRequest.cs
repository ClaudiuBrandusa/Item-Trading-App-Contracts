namespace Item_Trading_App_Contracts.Requests.Identity;

public record UserLoginRequest
{
    public string Username { get; set; }

    public string Password { get; set; }
}
