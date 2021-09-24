using Item_Trading_App_Contracts.Responses.Base;

namespace Item_Trading_App_Contracts.Responses.Inventory
{
    public class AddItemFailedResponse : FailedResponse
    {
        public string ItemId { get; set; }

        public string ItemName { get; set; }

        public int Quantity { get; set; }
    }
}
