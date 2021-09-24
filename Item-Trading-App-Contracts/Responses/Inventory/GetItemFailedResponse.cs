using Item_Trading_App_Contracts.Responses.Base;

namespace Item_Trading_App_Contracts.Responses.Inventory
{
    public class GetItemFailedResponse : FailedResponse
    {
        public string ItemId { get; set; }
    }
}
