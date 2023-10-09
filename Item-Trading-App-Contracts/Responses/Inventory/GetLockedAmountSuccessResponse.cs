namespace Item_Trading_App_Contracts.Responses.Inventory;

public record GetLockedAmountSuccessResponse
{
    public string ItemId { get; set; }

    public string ItemName { get; set; }

    public int LockedAmount { get; set; }
}
