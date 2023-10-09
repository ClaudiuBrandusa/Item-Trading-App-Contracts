namespace Item_Trading_App_Contracts.Responses.Item;

public record CreateItemSuccessResponse
{
    public string ItemId { get; set; }

    public string ItemName { get; set; }

    public string ItemDescription { get; set; }
}
