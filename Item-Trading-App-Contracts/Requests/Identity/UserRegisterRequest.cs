namespace Item_Trading_App_Contracts.Requests.Identity
{
    public class UserRegisterRequest
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
