namespace Item_Trading_App_Contracts.Responses.Identity;

public record UsernameSuccessResponse
{
    public string UserId { get; set; }

    public string Username { get; set; }
}
