namespace Item_Trading_App_Contracts
{
    public static class Endpoints
    {
        public static class Identity
        {
            private const string Base = "identity";

            public const string Register = Base + "/register";

            public const string Login = Base + "/login";

            public const string Refresh = Base + "/refresh";
        }
    }
}
