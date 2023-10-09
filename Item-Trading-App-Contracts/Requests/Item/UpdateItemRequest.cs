namespace Item_Trading_App_Contracts.Requests.Item;

// used when we update data about an item
public record UpdateItemRequest
{
    public string ItemId { get; set; }

    public string ItemName { get; set; }

    public string ItemDescription { get; set; }
}
