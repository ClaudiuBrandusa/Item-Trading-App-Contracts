namespace Item_Trading_App_Contracts.Requests.Item;

public record CreateItemRequest
{
    public string ItemName { get; set; }

    public string ItemDescription { get; set; }
}
