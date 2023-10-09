using Item_Trading_App_Contracts.Responses.Base;

namespace Item_Trading_App_Contracts.Responses.Item;

public record DeleteItemFailedResponse : FailedResponse
{
    public string ItemId { get; set; }

    public string ItemName { get; set; }
}
