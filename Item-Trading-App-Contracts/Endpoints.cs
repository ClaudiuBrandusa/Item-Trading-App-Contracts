namespace Item_Trading_App_Contracts
{
    public static class Endpoints
    {
        public static class Identity
        {
            private static readonly string Base = "identity";

            public static readonly string Register = Base + "/register";

            public static readonly string Login = Base + "/login";

            public static readonly string Refresh = Base + "/refresh";
        }
    }
}
