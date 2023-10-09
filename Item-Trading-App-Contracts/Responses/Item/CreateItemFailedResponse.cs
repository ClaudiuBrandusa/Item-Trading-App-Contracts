using Item_Trading_App_Contracts.Responses.Base;

namespace Item_Trading_App_Contracts.Responses.Item;

public record CreateItemFailedResponse : FailedResponse
{
    public string ItemName { get; set; }
}
