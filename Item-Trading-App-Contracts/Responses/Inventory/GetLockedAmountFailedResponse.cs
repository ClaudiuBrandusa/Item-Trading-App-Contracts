using Item_Trading_App_Contracts.Responses.Base;

namespace Item_Trading_App_Contracts.Responses.Inventory;

public record GetLockedAmountFailedResponse : FailedResponse
{
    public string ItemId { get; set; }
}
