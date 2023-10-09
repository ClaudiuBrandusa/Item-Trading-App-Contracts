namespace Item_Trading_App_Contracts.Requests.Inventory;

// used when we want to remove an amount of an item from our inventory
public record DropItemRequest
{
    public string ItemId { get; set; }

    public int ItemQuantity { get; set; }
}
