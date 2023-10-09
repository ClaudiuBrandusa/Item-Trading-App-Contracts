namespace Item_Trading_App_Contracts.Responses.Inventory;

public record GetItemSuccessResponse
{
    public string ItemId { get; set; }

    public string ItemName { get; set; }

    public string ItemDescription { get; set; }

    public int Quantity { get; set; }
}
