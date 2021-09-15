using Item_Trading_App_Contracts.Responses.Base;

namespace Item_Trading_App_Contracts.Responses.Item
{
    public class DropItemFailedResponse : FailedResponse
    {
        public string ItemId { get; set; }

        public string ItemName { get; set; }
    }
}
