namespace Item_Trading_App_Contracts
{
    public static class Endpoints
    {
        public static class Identity
        {
            private const string Base = "identity/";

            public const string Register = Base + "register";

            public const string Login = Base + "login";

            public const string Refresh = Base + "refresh";

            public const string GetUsername = Base + "get_username";

            public const string ListUsers = Base + "list_users";
        }

        public static class Inventory
        {
            private const string Base = "inventory/";

            public const string Add = Base + "add";

            public const string Drop = Base + "drop";

            public const string Get = Base + "get";

            public const string List = Base + "list";
        }

        public static class Item
        {
            private const string Base = "item/";

            public const string Create = Base + "create";

            public const string Get = Base + "get";

            public const string List = Base + "list";

            public const string Update = Base + "update";

            public const string Delete = Base + "delete";
        }

        public static class Trade
        {
            private const string Base = "trade/";

            public const string Offer = Base + "offer";

            public const string Accept = Base + "accept";

            public const string Reject = Base + "reject";

            private const string Get = Base + "get_";

            public const string GetSent = Get + "sent";

            public const string GetReceived = Get + "received";

            public const string GetSentResponded = GetSent + "_responded";

            public const string GetReceivedResponded = GetReceived + "_responded";

            private const string List = Base + "list_";

            public const string ListSent = List + "sent";

            public const string ListReceived = List + "received";
            
            public const string ListSentResponded = ListSent + "_responded";

            public const string ListReceivedResponded = ListReceived + "_responded";

            public const string Cancel = Base + "cancel";
        }

        public static class Wallet
        {
            private const string Base = "wallet/";

            public const string Get = Base + "get";

            public const string Update = Base + "update";
        }
    }
}
