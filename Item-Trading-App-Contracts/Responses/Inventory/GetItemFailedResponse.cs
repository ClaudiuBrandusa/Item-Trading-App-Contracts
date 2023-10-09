using Item_Trading_App_Contracts.Responses.Base;

namespace Item_Trading_App_Contracts.Responses.Inventory;

public record GetItemFailedResponse : FailedResponse
{
    public string ItemId { get; set; }
}
