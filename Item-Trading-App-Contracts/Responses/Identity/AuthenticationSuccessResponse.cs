namespace Item_Trading_App_Contracts.Responses.Identity
{
    public class AuthenticationSuccessResponse
    {
        public string Token { get; set; }

        public string RefreshToken { get; set; }
    }
}
